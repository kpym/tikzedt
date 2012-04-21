namespace TikzEdtWForms
{
    partial class SnippetEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnippetEntry));
            this.imgImage = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.cmdUseStyle = new System.Windows.Forms.Button();
            this.cmdInsertAsStyle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgImage)).BeginInit();
            this.SuspendLayout();
            // 
            // imgImage
            // 
            this.imgImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.imgImage.Location = new System.Drawing.Point(5, 5);
            this.imgImage.Name = "imgImage";
            this.imgImage.Size = new System.Drawing.Size(67, 33);
            this.imgImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgImage.TabIndex = 0;
            this.imgImage.TabStop = false;
            this.imgImage.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.imgImage_LoadCompleted);
            this.imgImage.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblName_MouseDoubleClick);
            // 
            // lblName
            // 
            this.lblName.AutoEllipsis = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(72, 5);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(153, 33);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "label1";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblName.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblName_MouseDoubleClick);
            // 
            // cmdUseStyle
            // 
            this.cmdUseStyle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdUseStyle.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdUseStyle.Image = ((System.Drawing.Image)(resources.GetObject("cmdUseStyle.Image")));
            this.cmdUseStyle.Location = new System.Drawing.Point(210, 5);
            this.cmdUseStyle.MaximumSize = new System.Drawing.Size(40, 30);
            this.cmdUseStyle.Name = "cmdUseStyle";
            this.cmdUseStyle.Size = new System.Drawing.Size(15, 30);
            this.cmdUseStyle.TabIndex = 3;
            this.cmdUseStyle.UseVisualStyleBackColor = false;
            this.cmdUseStyle.Click += new System.EventHandler(this.cmdUseStyle_Click);
            // 
            // cmdInsertAsStyle
            // 
            this.cmdInsertAsStyle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmdInsertAsStyle.Dock = System.Windows.Forms.DockStyle.Right;
            this.cmdInsertAsStyle.Location = new System.Drawing.Point(195, 5);
            this.cmdInsertAsStyle.MaximumSize = new System.Drawing.Size(40, 30);
            this.cmdInsertAsStyle.Name = "cmdInsertAsStyle";
            this.cmdInsertAsStyle.Size = new System.Drawing.Size(15, 30);
            this.cmdInsertAsStyle.TabIndex = 4;
            this.cmdInsertAsStyle.Text = "S";
            this.cmdInsertAsStyle.UseVisualStyleBackColor = false;
            this.cmdInsertAsStyle.Click += new System.EventHandler(this.cmdInsertAsStyle_Click);
            // 
            // SnippetEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.cmdInsertAsStyle);
            this.Controls.Add(this.cmdUseStyle);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.imgImage);
            this.MinimumSize = new System.Drawing.Size(0, 35);
            this.Name = "SnippetEntry";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(230, 43);
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lblName_MouseDoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.imgImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgImage;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button cmdUseStyle;
        private System.Windows.Forms.Button cmdInsertAsStyle;
    }
}
