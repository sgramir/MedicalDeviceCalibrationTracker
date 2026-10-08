</> C#

using System;

namespace MedicalDeviceCalibrationTracker
{
  public class MedicalDevice
  {
    //Five Properties
    public int DeviceID { get; set; }
    public string DeviceName { get; set; }
    public DateTime CalibrationDate { get; set; }
    public DateTime NextCalibrationDate { get; set; }
    public string Technician { get; set; }
    
    // Method 1: Display device information
    public void DisplayInfo()
    {
      Console.WriteLine("Device ID: " + DeviceID);
      Console.WriteLine("Device Name: " + DeviceName);
      Console.WriteLine("Calibration Date: " + CalibrationDate.ToShortDateString());
      Console.WriteLine("Nest Calibration Date: " + NextCalibrationDate.ToShortDateString());
      Console.WriteLine("Technician: " + Technician);
    }
    
    //Method 2: Check calibration status
    public void CheckCalibration()
    {
      if (NextCalibrationDate < DateTime.Today)
      {
        Console.WriteLine("Calibration Status: Current");
      }
    }
    static void Main(string[] args)
    {
      MedicalDevice device = new MedicalDevice();

      device.DeviceID = 101;
      device.DeviceName = "Digital Caliper";
      device.CalibrationDate = new DateTime (2026, 8, 15);
      device.NextCalibrationDate = new DateTime (2027, 8, 15);
      device.Technician = "Lab Technician";

      device.DisplayInfo();
      device.CheckCalibration();

      Console.ReadLine();
    }
  }
}

    
    
