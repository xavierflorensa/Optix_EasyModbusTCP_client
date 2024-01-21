# <a name="_toc156635100"></a>Modbus server with FTOptix
You can try this example on Modbus TCP Server from Rockwell Automation repository

You can download the Server FactoryTalk Optix code from here

<https://github.com/FactoryTalk-Optix/ModbusServerTCP>

You can see this working in this video

<https://youtu.be/UpRB72bkKkA>


![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 001](https://github.com/xavierflorensa/Readme_test/assets/55208134/a412e085-528a-43ef-bc89-56d1f3ef068a)

Let’s run the Optix application, and open a Modbus client

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 002](https://github.com/xavierflorensa/Readme_test/assets/55208134/f8f0acd0-f34d-4930-8f93-e2d2e5ffcdc6)

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 003](https://github.com/xavierflorensa/Readme_test/assets/55208134/69bc3db8-2a8d-4e02-873e-ceaf369af0d9)

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 004](https://github.com/xavierflorensa/Readme_test/assets/55208134/f078b495-cbc4-49f8-9b0f-a6a155e64eaa)

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 005](https://github.com/xavierflorensa/Readme_test/assets/55208134/78ee76e9-da84-425d-96f8-140c8a17a710)


# <a name="_toc156635101"></a>Native Modbus TCP client with FactoryTalk Optix
You can see it on this video

<https://youtu.be/UpRB72bkKkA>

Since FT OPtix has drivers for Modbus, let’s use it to test the above server

Build and application and on Communication drivers add a Modbus driver, and declare three Tags

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 006](https://github.com/xavierflorensa/Readme_test/assets/55208134/586ad1e7-68db-4aad-b338-2c2f9d0e1c30)

Give the right IP address

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 007](https://github.com/xavierflorensa/Readme_test/assets/55208134/e5f9e27a-bf89-4bd1-b1b0-2d947217ea41)

Make the corresponding dynamic links between Modbus variables and Values on circular gauges.

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 008](https://github.com/xavierflorensa/Readme_test/assets/55208134/a01cbb51-b9dc-4097-bb1b-3a4babfd3433)

Run the server, and start the application to test our client

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 009](https://github.com/xavierflorensa/Readme_test/assets/55208134/1d5966d2-4b57-4098-a6d4-e40b992602be)

Here you can find the code

<https://github.com/xavierflorensa/Optix_Native_Modbus_client>

# <a name="_toc156635102"></a>DotNet ModbusTCP client with C# and FactoryTalk Optix

Let’s try to build a Modbus client application with FT Optix and the EasyModbus library

Here the dll library EasyModbusTCP is used

<https://www.nuget.org/packages/EasyModbusTCP>

You can see how to use this library (with a client)

<https://www.youtube.com/watch?v=qcyJoDu7cok&t=726s>

You can see the final result on this video

<https://youtu.be/UpRB72bkKkA>

Copy the two dll from the FTOptix example

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 010](https://github.com/xavierflorensa/Readme_test/assets/55208134/a1586130-bd72-42c7-84db-b247ba4707dc)

And locate anywhere in your new client project

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 011](https://github.com/xavierflorensa/Readme_test/assets/55208134/4e8bf14e-c4eb-4b30-b654-95d88bc7f2c4)

Create a new Runtime Netlogic

### Installing libraries with Visual Studio 2022

change editor to Visual Studio 2022

Open code and go to

Project / Add references

Browse and install the two dll one after the other.

Close Visual Studio.

### Installing libraries with Visual Studio Code

You can also do this on VScode, this way

Got to View/Command Pallette/Open NUGetManager UI

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 012](https://github.com/xavierflorensa/Readme_test/assets/55208134/63d65d40-e9df-4b41-bda0-988041a1cc50)

Search for ModbusEasy. Install

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 013](https://github.com/xavierflorensa/Readme_test/assets/55208134/17e9dc0a-fc94-4991-a37b-e8f7378e9681)

Then go to Update

Load

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 014](https://github.com/xavierflorensa/Readme_test/assets/55208134/e8547a21-f7f4-4ba6-82ef-960ad1a2482f)

Then Update

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 015](https://github.com/xavierflorensa/Readme_test/assets/55208134/1e26b293-e155-4d22-92cf-6ba572bbfcae)


Install also System.IO.Ports

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 016](https://github.com/xavierflorensa/Readme_test/assets/55208134/264416df-4067-4bef-9f76-20eb52eed4d6)

Then Load and update

Open the code,

Look at the \*.csproj file

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 017](https://github.com/xavierflorensa/Readme_test/assets/55208134/0b4b08d9-b6ff-4bc5-ab86-dc482e543e9b)

Now add the using directive

Using EasyModbus;

And this code inside the start procedure

```C#
#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.Retentivity;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.CoreBase;
using FTOptix.Core;
using FTOptix.NetLogic;
using EasyModbus;
#endregion
public class RuntimeNetLogic1 : BaseNetLogic
{
      public override void Start()
      {
          ModbusClient myModbusClient = new ModbusClient("127.0.0.1",502);
          myModbusClient.Connect();
          // Insert code to be executed when the user-defined logic is started
          }
          public override void Stop()
          {
          // Insert code to be executed when the user-defined logic is stopped
          }
}
```

Execute the project

Opening a Server, we are connected to the server

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 018](https://github.com/xavierflorensa/Readme_test/assets/55208134/c9c1ba6b-17b4-4bde-9c7a-c724e3c91173)

Now let’s read a holding register

With this code

```C#
int[] readHoldingRegisters = myModbusClient.ReadHoldingRegisters(0,2);

Log.Info(readHoldingRegisters[0].ToString());
```

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 019](https://github.com/xavierflorensa/Readme_test/assets/55208134/f67db4bb-6585-4188-bb08-ef5649ee4193)

This is the code

```C#
#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.Retentivity;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.CoreBase;
using FTOptix.Core;
using FTOptix.NetLogic;
using EasyModbus;
#endregion
public class RuntimeNetLogic1 : BaseNetLogic
{
      public override void Start()
      {
            ModbusClient myModbusClient = new ModbusClient("127.0.0.1",502);
            myModbusClient.Connect();
            int[] readHoldingRegisters = myModbusClient.ReadHoldingRegisters(0,2);
            Log.Info(readHoldingRegisters[0].ToString());
            // Insert code to be executed when the user-defined logic is started
      }
      public override void Stop()
      {
            // Insert code to be executed when the user-defined logic is stopped
      }
}
```

Let’s use a dashboard, 

Add a new Gauge to your project and use this code

```C#
var myGauge = Project.Current.Get<CircularGauge>("UI/MainWindow/CircularGauge1");

myGauge.Value=readHoldingRegisters[0];
```

This is the whole code

```C#
#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.Retentivity;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.CoreBase;
using FTOptix.Core;
using FTOptix.NetLogic;
using EasyModbus;
#endregion
public class RuntimeNetLogic1 : BaseNetLogic
{
      public override void Start()
      {
            ModbusClient myModbusClient = new ModbusClient("127.0.0.1",502);
            myModbusClient.Connect();
            int[] readHoldingRegisters = myModbusClient.ReadHoldingRegisters(0,2);
            Log.Info(readHoldingRegisters[0].ToString());
            // Insert code to be executed when the user-defined logic is started
            var myGauge = Project.Current.Get<CircularGauge>("UI/MainWindow/CircularGauge1");
            myGauge.Value=readHoldingRegisters[0];
      }
      public override void Stop()
      {
            // Insert code to be executed when the user-defined logic is stopped
      }
}
```

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 020](https://github.com/xavierflorensa/Readme_test/assets/55208134/bd21b73d-696e-45b2-893a-d821ba38eca5)

But we need a periodic task to update the value

First of all, delete the former Netlogic and create a Netlogic under the Main Window (it will not work with Netlogic on the project level

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 021](https://github.com/xavierflorensa/Readme_test/assets/55208134/dd598bfa-78ac-4fd5-87de-b2066f82752e)

Use this logic and test the project

```C#
#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.Retentivity;
using FTOptix.NetLogic;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.CoreBase;
using FTOptix.Core;
using EasyModbus;
#endregion

public class RuntimeNetLogic1 : BaseNetLogic
{
      PeriodicTask myTask;
      ModbusClient myModbusClient;
      public override void Start()
      {
            // Insert code to be executed when the user-defined logic is started
            myModbusClient = new ModbusClient("127.0.0.1",502);
            myModbusClient.Connect();
            int[] readHoldingRegisters = myModbusClient.ReadHoldingRegisters(0,2);
            Log.Info(readHoldingRegisters[0].ToString());
            myTask = new PeriodicTask(MB\_Server\_Task, 100, LogicObject);
            myTask.Start();
      }
      public override void Stop()
      {
            // Insert code to be executed when the user-defined logic is stopped
            myTask.Dispose();
      }
      private void MB\_Server\_Task()
      {
            int[] readHoldingRegisters = myModbusClient.ReadHoldingRegisters(0,2);
            Log.Info(readHoldingRegisters[0].ToString());
            Owner.Get<CircularGauge>("CircularGauge1").Value=readHoldingRegisters[0];
      }
}
```

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 022](https://github.com/xavierflorensa/Readme_test/assets/55208134/c8bd10a0-e027-4f76-ad50-73c576eba043)

Now let’s modify the program to show three values

```C#
#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.Retentivity;
using FTOptix.NetLogic;
using FTOptix.UI;
using FTOptix.NativeUI;
using FTOptix.CoreBase;
using FTOptix.Core;
using EasyModbus;
#endregion

public class RuntimeNetLogic1 : BaseNetLogic

{
      PeriodicTask myTask;
      ModbusClient myModbusClient;
      public override void Start()
      {
            // Insert code to be executed when the user-defined logic is started
            myModbusClient = new ModbusClient("127.0.0.1",502);
            myModbusClient.Connect();
            myTask = new PeriodicTask(MB\_Server\_Task, 100, LogicObject);
            myTask.Start();
      }
      public override void Stop()
      {
            // Insert code to be executed when the user-defined logic is stopped
            myTask.Dispose();
      }
      private void MB\_Server\_Task()
      {
            int[] readHoldingRegisters = myModbusClient.ReadHoldingRegisters(0,3);
            Owner.Get<CircularGauge>("CircularGauge1").Value=readHoldingRegisters[0];
            Owner.Get<CircularGauge>("CircularGauge2").Value=readHoldingRegisters[1];
            Owner.Get<CircularGauge>("CircularGauge3").Value=readHoldingRegisters[2];
      }
}
```

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 023](https://github.com/xavierflorensa/Readme_test/assets/55208134/997d7b83-7bbc-4188-9b08-a5636d7c4b2e)


You have the code here

<https://github.com/xavierflorensa/Optix_EasyModbusTCP_client>

You can see this working in this video

<https://youtu.be/UpRB72bkKkA>

