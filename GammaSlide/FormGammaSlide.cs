using System;
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
            originalGamma = GetCurrentGamma();
            buttonReset_Click(this, new EventArgs());
        }

        #region Private Methods

        #endregion Private Methods

        #region Event Handlers

        private void formGammaSlide_FormClosing(object sender, FormClosingEventArgs e)
        {
            SetGamma(originalGamma);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            trackBarGamma.Value = (int)(GetGammaFromRamp(originalGamma) * 50);
        }

        private void trackBarGamma_ValueChanged(object sender, EventArgs e)
        {
            if (trackBarGamma.Value > 0)
            {
                var gamma = (float)((double)trackBarGamma.Value / 50);
                var ramp = CalcRampFromGamma(gamma);
                SetGamma(ramp);
                this.Text = Application.ProductName + " (" + gamma.ToString() + ")";
            }
        }

        #endregion Event Handlers
    }
}
