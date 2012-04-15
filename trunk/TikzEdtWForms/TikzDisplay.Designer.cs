namespace TikzEdtWForms
{
    partial class TikzDisplay
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
            this.lblUnavailable = new System.Windows.Forms.Label();
            this.imgImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUnavailable
            // 
            this.lblUnavailable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUnavailable.AutoSize = true;
            this.lblUnavailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnavailable.Location = new System.Drawing.Point(3, 0);
            this.lblUnavailable.Name = "lblUnavailable";
            this.lblUnavailable.Size = new System.Drawing.Size(109, 20);
            this.lblUnavailable.TabIndex = 0;
            this.lblUnavailable.Text = "<Unavailable>";
            this.lblUnavailable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgImage
            // 
            this.imgImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgImage.Location = new System.Drawing.Point(0, 0);
            this.imgImage.Name = "imgImage";
            this.imgImage.Size = new System.Drawing.Size(259, 270);
            this.imgImage.TabIndex = 1;
            this.imgImage.TabStop = false;
            // 
            // TikzDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.lblUnavailable);
            this.Controls.Add(this.imgImage);
            this.Name = "TikzDisplay";
            this.Size = new System.Drawing.Size(259, 270);
            ((System.ComponentModel.ISupportInitialize)(this.imgImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnavailable;
        private System.Windows.Forms.PictureBox imgImage;
    }
}
