#iRacingSDK.Net - Alternative

This dot.net library allows access to the raw data stream from the iRacing Motorsport Racing simulation (www.iracing.com).  It also provides an interface to control certain aspects of the game.  It is based on the official C++ SDK.

It provides access to the game's data interface using conventional dot.net paradigms.

At this point in time, it is heavily focused on supporting the data stream provided by the game during a replay session.  But it should also be useful for live non-replay mode.

There are other dot.net implementations of the iRacing SDK library - see the iRacing Developer's forum for references and downloads for those.

##Accessing game data

You can use the enumeration access of the iRacing class to access a stream of data samples, generated by the game.  For example, to get a single sample you can use the following:

`var data = iRacing.GetDataFeed().First()`
 
This will return a single `DataSample` value.  

Alternatively you can get a infinite sample set, or a set of samples until some condition is met.

```
foreach( var data in iRacing
             .GetDataFeed()
             .TakeWhile( d => d.Telemetry.SessionState != SessionState.CoolDown ))
{
    Console.WriteLine(data.Telemetry.RaceLaps);

    Thread.Sleep(1000);
}

Console.WriteLine("Finished.");

```
For more examples of accessing this data - checkout the Sample project within this repo.

##Access game data via Events

You can access the DataSample in an event handler.  Add your event handler to the NewData event of the iRacing type.

```
public void Setup()
{
    ...
    iRacing.NewData += iRacing_NewData;
    iRacing.StartListening();
}

void iRacing_NewData(DataSample data)
{
    var tractionControl = data.Telemetry.dcTractionControl;

    ...
}

```
NB:  You can not access the GetDataFeed() enumerator inside an Event Handler - You can not use the two types of accessors to DataSamples - events or enumerators - but not both.

##Sending Messages to the game

You can use the Replay object to control various aspects of the game.  For example, to change the camera to a specific car:

```
var data = iRacing.GetDataFeed().First();
var camera = data.SessionData.CameraInfo.Groups.First(g => g.GroupName == "TV3");

var carIdx = 3;
var number = data.SessionData.DriverInfo.Drivers[carIdx].CarNumber;
iRacing.Replay.CameraOnDriver((short)number, (short)camera.GroupNum, 0);
```

##DataSample

This type is the container for all data retrieved from iRacing.  iRacing exposes two main data sets: SessionData and Telemetry data. 

###SessionData
The session data provides a highly structured set of read only fields that detail all kinds of interesting bits of information regarding the games current running sessions.  This data does not change very often - unless, for example, the user loads a different track.

This data is extracted from an underlying YAML payload provided by game.  This structure may be changed by iRacing in future builds (new fields added).  You can use the GenerateDataModels project to update the structures to match the latest YAML payload.

Most fields are self explanatory.  The SessionData type is coded as a partial class - and this allows a bunch of extra helper methods to simplify common data requests.

###Telemetry
The Telemetry accessor of the DataSample, provides access to the realtime data set generated by the iRacing game.  

The Telemetry type is a dictionary keyed by a string name, and an object value (number or string).

The type also exposes the known key values in handy accessors.  The GenerateDataModels project can be used to update the known key value pairs.

Most of the keys of the Telemetry type should generally be self-explanatory.
