namespace TikzEdtWForms
{
    partial class ZoomCtrl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb = new System.Windows.Forms.TrackBar();
            this.cmdIn = new System.Windows.Forms.Button();
            this.cmdOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tb)).BeginInit();
            this.SuspendLayout();
            // 
            // tb
            // 
            this.tb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb.Location = new System.Drawing.Point(20, 0);
            this.tb.Maximum = 200;
            this.tb.MaximumSize = new System.Drawing.Size(0, 20);
            this.tb.Minimum = 5;
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(110, 20);
            this.tb.TabIndex = 0;
            this.tb.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tb.Value = 5;
            this.tb.ValueChanged += new System.EventHandler(this.tb_ValueChanged);
            // 
            // cmdIn
            // 
            this.cmdIn.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdIn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdIn.FlatAppearance.BorderSize = 0;
            this.cmdIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdIn.Image = global::TikzEdtWForms.Properties.Resources.ZoomInHSSmall;
            this.cmdIn.Location = new System.Drawing.Point(130, 0);
            this.cmdIn.Name = "cmdIn";
            this.cmdIn.Size = new System.Drawing.Size(20, 20);
            this.cmdIn.TabIndex = 2;
            this.cmdIn.UseVisualStyleBackColor = true;
            this.cmdIn.Click += new System.EventHandler(this.cmdIn_Click);
            // 
            // cmdOut
            // 
            this.cmdOut.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmdOut.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdOut.FlatAppearance.BorderSize = 0;
            this.cmdOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdOut.Image = global::TikzEdtWForms.Properties.Resources.ZoomOutHSSmall;
            this.cmdOut.Location = new System.Drawing.Point(0, 0);
            this.cmdOut.Name = "cmdOut";
            this.cmdOut.Size = new System.Drawing.Size(20, 20);
            this.cmdOut.TabIndex = 1;
            this.cmdOut.UseVisualStyleBackColor = true;
            this.cmdOut.Click += new System.EventHandler(this.cmdOut_Click);
            // 
            // ZoomCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tb);
            this.Controls.Add(this.cmdIn);
            this.Controls.Add(this.cmdOut);
            this.Name = "ZoomCtrl";
            this.Size = new System.Drawing.Size(150, 20);
            ((System.ComponentModel.ISupportInitialize)(this.tb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tb;
        private System.Windows.Forms.Button cmdOut;
        private System.Windows.Forms.Button cmdIn;
    }
}
