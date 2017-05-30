using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace VLC_Gesture_Controller
{
    class Program
    {
        static void Main(string[] args)
        {   
            string streamURL = "http://10.1.34.115:8080/";
            Bilderkennung erkennung = new Bilderkennung();
            erkennung.VLC_Starten(streamURL); //streamURL oder args[0]
            erkennung.Kamera_Starten();
            Thread.Sleep(5000);
        }
    }
}
