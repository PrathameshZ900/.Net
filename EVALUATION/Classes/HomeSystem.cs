using System;
using System.Collections.Generic;

class SmartHomeSystem
{
    private List<string> devices = new List<string>();
    private bool allDevicesOn = false;

    public static void Main()
    {
        SmartHomeSystem home = new SmartHomeSystem();
        home.AddDevice("Living Room Light");
        home.AddDevice("Kitchen Light");

        home.TurnOnAll();
        home.PrintDevices();

        home.RemoveDevice("Kitchen Light");
        home.PrintDevices();
    }

    public void AddDevice(string name)
    {
        devices.Add(name);
    }

    public void RemoveDevice(string name)
    {
        devices.Remove(name);
    }

    public void TurnOnAll()
    {
        allDevicesOn = true;
    }

    public void PrintDevices()
    {
        foreach (var device in devices)
        {
            Console.WriteLine(device + " is " + (allDevicesOn ? "On" : "Off"));
        }
    }
}