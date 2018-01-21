namespace QuickNetChat.Client
{
    partial class SplashScreen
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Processing = new System.Windows.Forms.ProgressBar();
            this.LabelProcessing = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Processing
            // 
            this.Processing.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Processing.Location = new System.Drawing.Point(9, 238);
            this.Processing.Name = "Processing";
            this.Processing.Size = new System.Drawing.Size(417, 23);
            this.Processing.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.Processing.TabIndex = 0;
            // 
            // LabelProcessing
            // 
            this.LabelProcessing.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LabelProcessing.Location = new System.Drawing.Point(9, 261);
            this.LabelProcessing.Name = "LabelProcessing";
            this.LabelProcessing.Size = new System.Drawing.Size(417, 13);
            this.LabelProcessing.TabIndex = 1;
            this.LabelProcessing.Text = "LabelProcessing";
            this.LabelProcessing.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 283);
            this.Controls.Add(this.Processing);
            this.Controls.Add(this.LabelProcessing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashScreen";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AboutBox1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar Processing;
        private System.Windows.Forms.Label LabelProcessing;
    }
}
