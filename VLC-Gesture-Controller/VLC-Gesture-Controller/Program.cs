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
            Bilderkennung erkennung = new Bilderkennung();
            erkennung.Kamera_Starten();
            Thread.Sleep(5000);
            //erkennung.Starten();
        }
    }
}
