namespace FindReplaceNoWPF
{
    partial class FindReplaceDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblReplace = new System.Windows.Forms.Label();
            this.txtTextToFind = new System.Windows.Forms.TextBox();
            this.txtReplaceWith = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioFind = new System.Windows.Forms.RadioButton();
            this.radioReplace = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkWildcards = new System.Windows.Forms.CheckBox();
            this.chkSearchUp = new System.Windows.Forms.CheckBox();
            this.chkMatchCase = new System.Windows.Forms.CheckBox();
            this.chkRegex = new System.Windows.Forms.CheckBox();
            this.chkWholeWord = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmdFind = new System.Windows.Forms.Button();
            this.cmdReplaceAll = new System.Windows.Forms.Button();
            this.cmdReplace = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search for";
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Location = new System.Drawing.Point(5, 44);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(69, 13);
            this.lblReplace.TabIndex = 1;
            this.lblReplace.Text = "Replace with";
            this.lblReplace.Visible = false;
            // 
            // txtTextToFind
            // 
            this.txtTextToFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTextToFind.Location = new System.Drawing.Point(5, 21);
            this.txtTextToFind.Name = "txtTextToFind";
            this.txtTextToFind.Size = new System.Drawing.Size(351, 20);
            this.txtTextToFind.TabIndex = 2;
            // 
            // txtReplaceWith
            // 
            this.txtReplaceWith.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReplaceWith.Location = new System.Drawing.Point(5, 60);
            this.txtReplaceWith.Name = "txtReplaceWith";
            this.txtReplaceWith.Size = new System.Drawing.Size(351, 20);
            this.txtReplaceWith.TabIndex = 3;
            this.txtReplaceWith.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.radioFind);
            this.panel1.Controls.Add(this.radioReplace);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 32);
            this.panel1.TabIndex = 4;
            // 
            // radioFind
            // 
            this.radioFind.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioFind.Checked = true;
            this.radioFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioFind.Location = new System.Drawing.Point(6, 3);
            this.radioFind.Name = "radioFind";
            this.radioFind.Size = new System.Drawing.Size(100, 24);
            this.radioFind.TabIndex = 1;
            this.radioFind.TabStop = true;
            this.radioFind.Text = "Find";
            this.radioFind.UseVisualStyleBackColor = true;
            this.radioFind.CheckedChanged += new System.EventHandler(this.radioFind_CheckedChanged);
            // 
            // radioReplace
            // 
            this.radioReplace.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioReplace.Location = new System.Drawing.Point(112, 3);
            this.radioReplace.Name = "radioReplace";
            this.radioReplace.Size = new System.Drawing.Size(104, 24);
            this.radioReplace.TabIndex = 0;
            this.radioReplace.Text = "Replace";
            this.radioReplace.UseVisualStyleBackColor = true;
            this.radioReplace.CheckedChanged += new System.EventHandler(this.radioFind_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTextToFind, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtReplaceWith, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblReplace, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 32);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5, 3, 3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(361, 210);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkWildcards);
            this.groupBox1.Controls.Add(this.chkSearchUp);
            this.groupBox1.Controls.Add(this.chkMatchCase);
            this.groupBox1.Controls.Add(this.chkRegex);
            this.groupBox1.Controls.Add(this.chkWholeWord);
            this.groupBox1.Location = new System.Drawing.Point(5, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 90);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // chkWildcards
            // 
            this.chkWildcards.AutoSize = true;
            this.chkWildcards.Location = new System.Drawing.Point(109, 42);
            this.chkWildcards.Name = "chkWildcards";
            this.chkWildcards.Size = new System.Drawing.Size(73, 17);
            this.chkWildcards.TabIndex = 10;
            this.chkWildcards.Text = "Wildcards";
            this.chkWildcards.UseVisualStyleBackColor = true;
            // 
            // chkSearchUp
            // 
            this.chkSearchUp.AutoSize = true;
            this.chkSearchUp.Location = new System.Drawing.Point(6, 65);
            this.chkSearchUp.Name = "chkSearchUp";
            this.chkSearchUp.Size = new System.Drawing.Size(75, 17);
            this.chkSearchUp.TabIndex = 9;
            this.chkSearchUp.Text = "Search up";
            this.chkSearchUp.UseVisualStyleBackColor = true;
            // 
            // chkMatchCase
            // 
            this.chkMatchCase.AutoSize = true;
            this.chkMatchCase.Location = new System.Drawing.Point(6, 19);
            this.chkMatchCase.Name = "chkMatchCase";
            this.chkMatchCase.Size = new System.Drawing.Size(83, 17);
            this.chkMatchCase.TabIndex = 8;
            this.chkMatchCase.Text = "Match Case";
            this.chkMatchCase.UseVisualStyleBackColor = true;
            // 
            // chkRegex
            // 
            this.chkRegex.AutoSize = true;
            this.chkRegex.Location = new System.Drawing.Point(109, 19);
            this.chkRegex.Name = "chkRegex";
            this.chkRegex.Size = new System.Drawing.Size(116, 17);
            this.chkRegex.TabIndex = 7;
            this.chkRegex.Text = "Regular expression";
            this.chkRegex.UseVisualStyleBackColor = true;
            // 
            // chkWholeWord
            // 
            this.chkWholeWord.AutoSize = true;
            this.chkWholeWord.Location = new System.Drawing.Point(6, 42);
            this.chkWholeWord.Name = "chkWholeWord";
            this.chkWholeWord.Size = new System.Drawing.Size(86, 17);
            this.chkWholeWord.TabIndex = 6;
            this.chkWholeWord.Text = "Whole Word";
            this.chkWholeWord.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmdFind);
            this.panel2.Controls.Add(this.cmdReplaceAll);
            this.panel2.Controls.Add(this.cmdReplace);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 211);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 31);
            this.panel2.TabIndex = 6;
            // 
            // cmdFind
            // 
            this.cmdFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdFind.Location = new System.Drawing.Point(283, 5);
            this.cmdFind.Name = "cmdFind";
            this.cmdFind.Size = new System.Drawing.Size(75, 23);
            this.cmdFind.TabIndex = 2;
            this.cmdFind.Text = "Find Next";
            this.cmdFind.UseVisualStyleBackColor = true;
            this.cmdFind.Click += new System.EventHandler(this.cmdFind_Click);
            // 
            // cmdReplaceAll
            // 
            this.cmdReplaceAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdReplaceAll.Location = new System.Drawing.Point(121, 5);
            this.cmdReplaceAll.Name = "cmdReplaceAll";
            this.cmdReplaceAll.Size = new System.Drawing.Size(75, 23);
            this.cmdReplaceAll.TabIndex = 1;
            this.cmdReplaceAll.Text = "Replace All";
            this.cmdReplaceAll.UseVisualStyleBackColor = true;
            this.cmdReplaceAll.Visible = false;
            this.cmdReplaceAll.Click += new System.EventHandler(this.cmdReplaceAll_Click);
            // 
            // cmdReplace
            // 
            this.cmdReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdReplace.Location = new System.Drawing.Point(202, 5);
            this.cmdReplace.Name = "cmdReplace";
            this.cmdReplace.Size = new System.Drawing.Size(75, 23);
            this.cmdReplace.TabIndex = 0;
            this.cmdReplace.Text = "Replace";
            this.cmdReplace.UseVisualStyleBackColor = true;
            this.cmdReplace.Visible = false;
            this.cmdReplace.Click += new System.EventHandler(this.cmdReplace_Click);
            // 
            // FindReplaceDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 242);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "FindReplaceDialog";
            this.ShowIcon = false;
            this.Text = "Find/Replace";
            this.Deactivate += new System.EventHandler(this.FindReplaceDialog_Deactivate);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindReplaceDialog_KeyDown);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.TextBox txtReplaceWith;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioFind;
        private System.Windows.Forms.RadioButton radioReplace;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkWildcards;
        private System.Windows.Forms.CheckBox chkSearchUp;
        private System.Windows.Forms.CheckBox chkMatchCase;
        private System.Windows.Forms.CheckBox chkRegex;
        private System.Windows.Forms.CheckBox chkWholeWord;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button cmdFind;
        private System.Windows.Forms.Button cmdReplaceAll;
        private System.Windows.Forms.Button cmdReplace;
        public System.Windows.Forms.TextBox txtTextToFind;
    }
}