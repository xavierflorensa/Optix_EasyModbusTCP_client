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
        myTask = new PeriodicTask(MB_Server_Task, 100, LogicObject);
        myTask.Start();
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
        myTask.Dispose();
    }
    private void MB_Server_Task()
    {
        int[] readHoldingRegisters = myModbusClient.ReadHoldingRegisters(0,3);
        Owner.Get<CircularGauge>("CircularGauge1").Value=readHoldingRegisters[0];
        Owner.Get<CircularGauge>("CircularGauge2").Value=readHoldingRegisters[1];
        Owner.Get<CircularGauge>("CircularGauge3").Value=readHoldingRegisters[2];
    }
}
