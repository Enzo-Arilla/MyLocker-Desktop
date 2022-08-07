﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLocker
{
    class Elipse : Component
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn(int nL, int nT, int nR, int nB, int nWidthElipse, int nHeightElipse);


        private Control control;
        private int cornerRadius = 25;

        public Control TargetControl
        {
            get { return control; }
            set
            {
                control = value;
                control.SizeChanged += (sender, eventArgs) => control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, cornerRadius, cornerRadius));
            }
        }

        public int CornerRedius 
        {
            get { return cornerRadius; }
            set
            {
                cornerRadius = value;
                if(control != null)
                {
                    control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, cornerRadius, cornerRadius));
                }
            }

        }

    }
}
