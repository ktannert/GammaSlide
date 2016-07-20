namespace GammaSlide
{
    partial class FormGammaSlide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGammaSlide));
            this.trackBarGamma = new System.Windows.Forms.TrackBar();
            this.buttonSet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGamma)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarGamma
            // 
            this.trackBarGamma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarGamma.Location = new System.Drawing.Point(12, 12);
            this.trackBarGamma.Maximum = 15;
            this.trackBarGamma.Minimum = -15;
            this.trackBarGamma.Name = "trackBarGamma";
            this.trackBarGamma.Size = new System.Drawing.Size(310, 45);
            this.trackBarGamma.TabIndex = 0;
            this.trackBarGamma.TickFrequency = 3;
            this.trackBarGamma.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBarGamma.ValueChanged += new System.EventHandler(this.trackBarGamma_ValueChanged);
            // 
            // buttonSet
            // 
            this.buttonSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSet.BackColor = System.Drawing.Color.Black;
            this.buttonSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSet.ForeColor = System.Drawing.Color.White;
            this.buttonSet.Location = new System.Drawing.Point(12, 63);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(310, 46);
            this.buttonSet.TabIndex = 1;
            this.buttonSet.Text = "Reset Gamma";
            this.buttonSet.UseVisualStyleBackColor = false;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // FormGammaSlide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(334, 126);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.trackBarGamma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGammaSlide";
            this.Text = "GammaSlide";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormToggleGamma_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGamma)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarGamma;
        private System.Windows.Forms.Button buttonSet;
    }
}

