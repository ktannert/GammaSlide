using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GammaSlide
{
    public partial class FormGammaSlide : Form
    {
        RAMP originalGamma;

        public FormGammaSlide()
        {
            InitializeComponent();
            originalGamma = GetGamma();
        }

        [DllImport("gdi32.dll")]
        public static extern bool SetDeviceGammaRamp(IntPtr hDC, ref RAMP lpRamp);

        [DllImport("gdi32.dll")]
        public static extern int GetDeviceGammaRamp(IntPtr hDC, ref RAMP lpRamp);

        [DllImport("user32.dll")]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct RAMP
        {
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Red;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Green;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
            public UInt16[] Blue;
        }

        public RAMP GetGamma()
        {
            RAMP ramp = new RAMP();
            GetDeviceGammaRamp(GetDC(IntPtr.Zero), ref ramp);
            return ramp;
        }

        private void FormToggleGamma_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResetGamma();
        }

        private void FormToggleGamma_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void SetGamma()
        {
            RAMP ramp = new RAMP();
            ramp.Red = new ushort[256];
            ramp.Green = new ushort[256];
            ramp.Blue = new ushort[256];

            for (int i = 0; i < ramp.Red.Length; i++)
            {
                var val = Convert.ToUInt16(Math.Max(Math.Min((i * 256) + (trackBarGamma.Value * 0x1000), 0xFFFF), 0));
                ramp.Red[i] = ramp.Blue[i] = ramp.Green[i] = val;
            }
            SetDeviceGammaRamp(GetDC(IntPtr.Zero), ref ramp);
        }

        public void ResetGamma()
        {
            SetDeviceGammaRamp(GetDC(IntPtr.Zero), ref originalGamma);
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            trackBarGamma.Value = 0;
            ResetGamma();
        }

        private void trackBarGamma_ValueChanged(object sender, EventArgs e)
        {
            if (trackBarGamma.Value >= 0)
            {
                buttonSet.BackColor = Color.Black;
                buttonSet.ForeColor = Color.White;
            }
            else
            {
                buttonSet.BackColor = Color.White;
                buttonSet.ForeColor = Color.Black;
            }
            SetGamma();
        }
    }
}
