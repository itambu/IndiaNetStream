using EventExample.Devices;
using System;
using System.Collections.Generic;

// We have devices at home that can generate signals of partilar types (doors, webcams, and e.t.).
// Devices and generated signals have to be stored in collections
// 1) create object model
// 2) create ivent model
// 3) link object and ivent models together
// 4) write simple scenario to illistrate the approach

namespace EventExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // first stage. creating object model-------------------------------------
            ICollection<ISignal> signals = new List<ISignal>();

            NotifyCollection<IDevice> devices = new NotifyCollection<IDevice>( new List<IDevice>() );
            
            Door door = new Door();
            Webcam webcam = new Webcam();

            // second stage. create ivent model and bindings -----------------------------
            // 
            EventHandler<ISignal> signalHandler = (sender, signal) => { signals.Add(signal); };
            EventHandler<IDevice> bindSignalHandler = (sender, device) => { device.Signal += signalHandler; };
            EventHandler<IDevice> unbindSignalHandler = (sender, device) => { device.Signal -= signalHandler; };


            devices.AddEvent += bindSignalHandler;
            devices.RemoveEvent += unbindSignalHandler;

            // thrid stage. try to use object and ivent model together -------------

            devices.Add(door);
            devices.Add(webcam);

            door.Open();
            webcam.MakeShot();
            // the generated signals have been added to the signals list

            //-------------------------------------------------------
            // modify ivent model in the runtime and fire the event again

            devices.Remove(door);

            door.Close();
            webcam.MakeShot();
            // the generated signal have not been added to the signals list

            // view stored signals
            foreach (ISignal signal in signals)
            {
                Console.WriteLine(signal.Message);
            }
        }
    }
}
