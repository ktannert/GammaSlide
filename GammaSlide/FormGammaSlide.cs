using System;
using System.Drawing;
using System.Windows.Forms;
using static GammaSlide.GammaSlideInterop;

namespace GammaSlide
{
    public partial class formGammaSlide : Form
    {
        RAMP originalGamma;

        public formGammaSlide()
        {
            InitializeComponent();
            originalGamma = GetGamma();
        }

        #region Private Methods

        #endregion Private Methods

        #region Event Handlers

        private void formGammaSlide_FormClosing(object sender, FormClosingEventArgs e)
        {
            SetGamma(originalGamma);
        }

        private void buttonSet_Click(object sender, EventArgs e)
        {
            trackBarGamma.Value = 0;
            SetGamma(originalGamma);
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
            SetGamma(CalcRamp());
        }

        #endregion Event Handlers

        #region Private Methods

        private RAMP CalcRamp()
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
            return ramp;
        }

        #endregion Private Methods
    }
}
