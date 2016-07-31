namespace GammaSlide
{
    partial class formGammaSlide
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGammaSlide));
            this.trackBarGamma = new System.Windows.Forms.TrackBar();
            this.buttonReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGamma)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarGamma
            // 
            this.trackBarGamma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarGamma.BackColor = System.Drawing.Color.Black;
            this.trackBarGamma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarGamma.Location = new System.Drawing.Point(12, 12);
            this.trackBarGamma.Maximum = 100;
            this.trackBarGamma.Name = "trackBarGamma";
            this.trackBarGamma.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBarGamma.RightToLeftLayout = true;
            this.trackBarGamma.Size = new System.Drawing.Size(310, 45);
            this.trackBarGamma.TabIndex = 0;
            this.trackBarGamma.TickFrequency = 10;
            this.trackBarGamma.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarGamma.Value = 50;
            this.trackBarGamma.ValueChanged += new System.EventHandler(this.trackBarGamma_ValueChanged);
            // 
            // buttonReset
            // 
            this.buttonReset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReset.BackColor = System.Drawing.Color.Black;
            this.buttonReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.ForeColor = System.Drawing.Color.White;
            this.buttonReset.Location = new System.Drawing.Point(12, 63);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(310, 46);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Reset Gamma";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // formGammaSlide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(334, 126);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.trackBarGamma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formGammaSlide";
            this.Text = "GammaSlide";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formGammaSlide_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGamma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarGamma;
        private System.Windows.Forms.Button buttonReset;
    }
}

