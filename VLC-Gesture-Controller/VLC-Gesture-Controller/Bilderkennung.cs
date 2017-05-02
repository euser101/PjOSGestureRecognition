using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;

namespace VLC_Gesture_Controller
{
    class Bilderkennung
    {

        Bitmap bild;
        Bitmap bild_ueberprüfen;
        int farberotbild;
        int farbegelbbild;
        int farbeblaubild;

        public void Kamera_Starten()
        {
            FilterInfoCollection videoquellen = new FilterInfoCollection(FilterCategory.VideoInputDevice); ;
            VideoCaptureDevice kamera;
            kamera = new VideoCaptureDevice(videoquellen[0].MonikerString);
            kamera.NewFrame += new NewFrameEventHandler(kamera_neuer_Frame);
            kamera.Start();
        }

        private void kamera_neuer_Frame(object sender, NewFrameEventArgs eventArgs)
        {
            bild = new Bitmap(eventArgs.Frame);
        }

        public void Starten()
        {
            while(true)
            {
                Sprung_zurueck();
                Leiser();
                Start_Pause();
                lauter();
                sprung_vorwaerts();
                Thread.Sleep(1000);
            }
            
        }

        //Erster Bereich
        public void Sprung_zurueck()
        {
            bild_ueberprüfen = bild;
            bild_ueberprüfen = new Bitmap(bild);
            int teile = bild_ueberprüfen.Width / 15;
            int bereich_zurueck = teile + teile;


            for (int i = teile; i < bereich_zurueck; i++)
            {
                for (int x = 0; x < bild_ueberprüfen.Height; x++)
                {
                    farberotbild = bild_ueberprüfen.GetPixel(i, x).R;
                    farbegelbbild = bild_ueberprüfen.GetPixel(i, x).G;
                    farbeblaubild = bild_ueberprüfen.GetPixel(i, x).B;

                    if (farberotbild >= 80 && farberotbild <= 230 && farbegelbbild >= 80 && farbegelbbild <= 230 && farbeblaubild >= 80 && farbeblaubild <= 230)
                    {
                        fokus_vlc();

                        SendKeys.Send("^{LEFT}");
                    }
                }
            }
        }

        //Zweiter Bereich
        public void Leiser()
        {
            bild_ueberprüfen = bild;
            bild_ueberprüfen = new Bitmap(bild);
            int teile = bild_ueberprüfen.Width / 15;
            int start_bereich_leiser = 4 * teile;
            int end_bereich_leiser = 5 * teile;

            for (int i = start_bereich_leiser; i < end_bereich_leiser; i++)
            {
                for (int x = 0; x < bild_ueberprüfen.Height; x++)
                {
                    farberotbild = bild_ueberprüfen.GetPixel(i, x).R;
                    farbegelbbild = bild_ueberprüfen.GetPixel(i, x).G;
                    farbeblaubild = bild_ueberprüfen.GetPixel(i, x).B;

                    if (farberotbild >= 80 && farberotbild <= 230 && farbegelbbild >= 80 && farbegelbbild <= 230 && farbeblaubild >= 80 && farbeblaubild <= 230)
                    {
                        fokus_vlc();
                        SendKeys.Send("^{DOWN}");
                    }
                }
            }
        }

        //Dritter Bereich
        public void Start_Pause()
        {
            bild_ueberprüfen = bild;
            bild_ueberprüfen = new Bitmap(bild);
            int teile = bild_ueberprüfen.Width / 5;
            int start_bereich_pause = 7 * teile;
            int end_bereich_pause = 8 * teile;

            for (int i = start_bereich_pause; i < end_bereich_pause; i++)
            {
                for (int x = 0; x < bild_ueberprüfen.Height; x++)
                {
                    farberotbild = bild_ueberprüfen.GetPixel(i, x).R;
                    farbegelbbild = bild_ueberprüfen.GetPixel(i, x).G;
                    farbeblaubild = bild_ueberprüfen.GetPixel(i, x).B;

                    if (farberotbild >= 80 && farberotbild <= 230 && farbegelbbild >= 80 && farbegelbbild <= 230 && farbeblaubild >= 80 && farbeblaubild <= 230)
                    {
                        fokus_vlc();
                        SendKeys.Send(" ");
                    }
                }
            }
        }

        //
        public void lauter()
        {
            bild_ueberprüfen = bild;
            bild_ueberprüfen = new Bitmap(bild);
            int teile = bild_ueberprüfen.Width / 5;
            int start_bereich_lauter = 10 * teile;
            int end_bereich_lauter = 11 * teile;

            for (int i = start_bereich_lauter; i < end_bereich_lauter; i++)
            {
                for (int x = 0; x < bild_ueberprüfen.Height; x++)
                {
                    farberotbild = bild_ueberprüfen.GetPixel(i, x).R;
                    farbegelbbild = bild_ueberprüfen.GetPixel(i, x).G;
                    farbeblaubild = bild_ueberprüfen.GetPixel(i, x).B;

                    if (farberotbild >= 80 && farberotbild <= 230 && farbegelbbild >= 80 && farbegelbbild <= 230 && farbeblaubild >= 80 && farbeblaubild <= 230)
                    {
                        fokus_vlc();
                        SendKeys.Send("^{UP}");
                    }
                }
            }
        }

        public void sprung_vorwaerts()
        {
            bild_ueberprüfen = bild;
            bild_ueberprüfen = new Bitmap(bild);
            int teile = bild_ueberprüfen.Width / 5;
            int start_bereich_vorwaerts = 13 * teile;
            int end_bereich_vorwaerts = 14 * teile; ;

            for (int i = start_bereich_vorwaerts; i < end_bereich_vorwaerts; i++)
            {
                for (int x = 0; x < bild_ueberprüfen.Height; x++)
                {
                    farberotbild = bild_ueberprüfen.GetPixel(i, x).R;
                    farbegelbbild = bild_ueberprüfen.GetPixel(i, x).G;
                    farbeblaubild = bild_ueberprüfen.GetPixel(i, x).B;

                    if (farberotbild >= 80 && farberotbild <= 230 && farbegelbbild >= 80 && farbegelbbild <= 230 && farbeblaubild >= 80 && farbeblaubild <= 230)
                    {
                        fokus_vlc();
                        SendKeys.Send("^{RIGHT}");
                    }
                }
            }
        }

        [DllImport("user32.dll")]
        internal static extern IntPtr SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        internal static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public void fokus_vlc()
        {
            IntPtr hWnd;
            Process[] processRunning = Process.GetProcesses();
            foreach (Process pr in processRunning)
            {
                if(pr.ProcessName == "VLC media player")
                {
                    hWnd = pr.MainWindowHandle;
                    ShowWindow(hWnd, 3);
                    SetForegroundWindow(hWnd);
                }
            }
        }
    }
}
