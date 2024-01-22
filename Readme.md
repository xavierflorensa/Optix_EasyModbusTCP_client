# <a name="_toc156635100"></a>Modbus server with FTOptix
You can try this example on Modbus TCP Server from Rockwell Automation repository

You can download the Server FactoryTalk Optix code from here

<https://github.com/FactoryTalk-Optix/ModbusServerTCP>

You can see this working in this video

<https://youtu.be/UpRB72bkKkA>

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 001](https://github.com/xavierflorensa/Optix_EasyModbusTCP_client/assets/55208134/3f23e876-2c3b-4fcb-beb5-ec531fce87e4)


Let’s run the Optix application, and open a Modbus client

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 002](https://github.com/xavierflorensa/Optix_EasyModbusTCP_client/assets/55208134/6429306d-1f26-4c6c-ad83-918cb30ee4c0)

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 003](https://github.com/xavierflorensa/Optix_EasyModbusTCP_client/assets/55208134/dea9e7f2-49f4-4f2f-b933-cf1fe72702a1)

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 004](https://github.com/xavierflorensa/Optix_EasyModbusTCP_client/assets/55208134/15925349-07e3-4b7d-af58-c0d888249a55)

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 005](https://github.com/xavierflorensa/Optix_EasyModbusTCP_client/assets/55208134/eb6dc3a5-6e5b-4938-8797-7229a96d76cf)


# <a name="_toc156635101"></a>Native Modbus TCP client with FactoryTalk Optix
You can see it on this video

<https://youtu.be/UpRB72bkKkA>

Since FT OPtix has drivers for Modbus, let’s use it to test the above server

Build and application and on Communication drivers add a Modbus driver, and declare three Tags

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 006](https://github.com/xavierflorensa/Optix_EasyModbusTCP_client/assets/55208134/898f946f-1225-447c-921f-ec2ba19d8273)

Give the right IP address

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 007](https://github.com/xavierflorensa/Optix_EasyModbusTCP_client/assets/55208134/7444483c-3c03-4f8d-ad94-1310eaa9a426)


Make the corresponding dynamic links between Modbus variables and Values on circular gauges.

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 008](https://github.com/xavierflorensa/Optix_EasyModbusTCP_client/assets/55208134/930b37fe-93da-4e60-88e9-2684989d3f9b)

Run the server, and start the application to test our client

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 009](https://github.com/xavierflorensa/Optix_EasyModbusTCP_client/assets/55208134/f5c790c0-a164-486c-83b1-1531f9831aa1)

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

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 010](https://github.com/xavierflorensa/Optix_EasyModbusTCP_client/assets/55208134/7d1ffb43-933d-4125-80ca-2cf86d333fef)

And locate anywhere in your new client project

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 011](https://github.com/xavierflorensa/Optix_EasyModbusTCP_client/assets/55208134/9f2fe46a-3f8e-46fb-8ead-c2230bc91a40)

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

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 012](https://github.com/xavierflorensa/Optix_EasyModbusTCP_client/assets/55208134/95800d64-d80e-40cc-8028-c75d0f7f277c)

Search for ModbusEasy. Install

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 013](https://github.com/xavierflorensa/Optix_EasyModbusTCP_client/assets/55208134/4e65fe84-b627-408a-b8d2-f8311586e4e9)

Then go to Update

Load

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 014](https://github.com/xavierflorensa/Optix_EasyModbusTCP_client/assets/55208134/fe40e3e6-58fe-4af8-8b65-af638fce6c13)

Then Update

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 015](https://github.com/xavierflorensa/Optix_EasyModbusTCP_client/assets/55208134/788317e6-9aee-4e4a-babb-921089e10d9a)



Install also System.IO.Ports

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 016](https://github.com/xavierflorensa/Optix_EasyModbusTCP_client/assets/55208134/4d5f0af5-9ebb-4b60-ac29-67c730dad0db)


Then Load and update

Open the code,

Look at the \*.csproj file

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 017](https://github.com/xavierflorensa/Optix_EasyModbusTCP_client/assets/55208134/803af8e1-2950-4ba6-879c-9dbfe73072c1)

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

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 018](https://github.com/xavierflorensa/Optix_EasyModbusTCP_client/assets/55208134/23cadb68-9ec0-4859-b2f6-469fa2e8fb79)

Now let’s read a holding register

With this code

```C#
int[] readHoldingRegisters = myModbusClient.ReadHoldingRegisters(0,2);

Log.Info(readHoldingRegisters[0].ToString());
```

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 019](https://github.com/xavierflorensa/Optix_EasyModbusTCP_client/assets/55208134/396683e3-fdd6-49a9-8ac6-aaf01b582305)


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

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 020](https://github.com/xavierflorensa/Optix_EasyModbusTCP_client/assets/55208134/63abeab1-8055-4089-bb3c-8c375d887e39)


But we need a periodic task to update the value

First of all, delete the former Netlogic and create a Netlogic under the Main Window (it will not work with Netlogic on the project level

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 021](https://github.com/xavierflorensa/Optix_EasyModbusTCP_client/assets/55208134/46ad58cc-ccac-4675-a6c4-b8ade33499bf)


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

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 022](https://github.com/xavierflorensa/Optix_EasyModbusTCP_client/assets/55208134/5d028f1f-2cf7-4c9b-bfe1-3d7b2317df2c)

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

![Aspose Words 0fa7330a-1af4-4f6a-8a4f-08e18f25960b 023](https://github.com/xavierflorensa/Optix_EasyModbusTCP_client/assets/55208134/bbdddb4f-6f03-46e1-9f97-5fc4a3a32d6b)



You have the code here

<https://github.com/xavierflorensa/Optix_EasyModbusTCP_client>

You can see this working in this video

<https://youtu.be/UpRB72bkKkA>

