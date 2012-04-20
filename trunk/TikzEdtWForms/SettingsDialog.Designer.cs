namespace TikzEdtWForms
{
    partial class SettingsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsDialog));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPdfLatex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHtLatex = new System.Windows.Forms.TextBox();
            this.txtExtViewer = new System.Windows.Forms.TextBox();
            this.numTimeOutSnippetCompile = new System.Windows.Forms.NumericUpDown();
            this.numTimeoutCompile = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.chkShowLineNr = new System.Windows.Forms.CheckBox();
            this.chkCodeCompletion = new System.Windows.Forms.CheckBox();
            this.chkBeginCompletion = new System.Windows.Forms.CheckBox();
            this.chkShowSnippetThumbs = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmdFont = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrepended = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecompArgs = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.numMarginBB = new System.Windows.Forms.NumericUpDown();
            this.numCoordDec = new System.Windows.Forms.NumericUpDown();
            this.cmdColorNode = new System.Windows.Forms.Button();
            this.cmdColorSNode = new System.Windows.Forms.Button();
            this.cmdColorScope = new System.Windows.Forms.Button();
            this.cmdColorSScope = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeOutSnippetCompile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeoutCompile)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMarginBB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCoordDec)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(405, 262);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(397, 236);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPdfLatex, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtHtLatex, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtExtViewer, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.numTimeOutSnippetCompile, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.numTimeoutCompile, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(391, 230);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Command Pdflatx";
            // 
            // txtPdfLatex
            // 
            this.txtPdfLatex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPdfLatex.Location = new System.Drawing.Point(171, 5);
            this.txtPdfLatex.Name = "txtPdfLatex";
            this.txtPdfLatex.Size = new System.Drawing.Size(215, 20);
            this.txtPdfLatex.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Command htlatex";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "External pdf viewer command";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Timeut Compilation (ms)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Timeout snippet compilation (ms)";
            // 
            // txtHtLatex
            // 
            this.txtHtLatex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHtLatex.Location = new System.Drawing.Point(171, 31);
            this.txtHtLatex.Name = "txtHtLatex";
            this.txtHtLatex.Size = new System.Drawing.Size(215, 20);
            this.txtHtLatex.TabIndex = 6;
            // 
            // txtExtViewer
            // 
            this.txtExtViewer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtExtViewer.Location = new System.Drawing.Point(171, 57);
            this.txtExtViewer.Name = "txtExtViewer";
            this.txtExtViewer.Size = new System.Drawing.Size(215, 20);
            this.txtExtViewer.TabIndex = 7;
            // 
            // numTimeOutSnippetCompile
            // 
            this.numTimeOutSnippetCompile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numTimeOutSnippetCompile.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTimeOutSnippetCompile.Location = new System.Drawing.Point(171, 109);
            this.numTimeOutSnippetCompile.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numTimeOutSnippetCompile.Name = "numTimeOutSnippetCompile";
            this.numTimeOutSnippetCompile.Size = new System.Drawing.Size(215, 20);
            this.numTimeOutSnippetCompile.TabIndex = 9;
            // 
            // numTimeoutCompile
            // 
            this.numTimeoutCompile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numTimeoutCompile.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTimeoutCompile.Location = new System.Drawing.Point(171, 83);
            this.numTimeoutCompile.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numTimeoutCompile.Name = "numTimeoutCompile";
            this.numTimeoutCompile.Size = new System.Drawing.Size(215, 20);
            this.numTimeoutCompile.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(397, 236);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Editor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.61098F));
            this.tableLayoutPanel2.Controls.Add(this.chkShowLineNr, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.chkCodeCompletion, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.chkBeginCompletion, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.chkShowSnippetThumbs, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.cmdFont, 1, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(391, 230);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // chkShowLineNr
            // 
            this.chkShowLineNr.AutoSize = true;
            this.chkShowLineNr.Location = new System.Drawing.Point(100, 3);
            this.chkShowLineNr.Name = "chkShowLineNr";
            this.chkShowLineNr.Size = new System.Drawing.Size(115, 17);
            this.chkShowLineNr.TabIndex = 0;
            this.chkShowLineNr.Text = "Show line numbers";
            this.chkShowLineNr.UseVisualStyleBackColor = true;
            // 
            // chkCodeCompletion
            // 
            this.chkCodeCompletion.AutoSize = true;
            this.chkCodeCompletion.Location = new System.Drawing.Point(100, 26);
            this.chkCodeCompletion.Name = "chkCodeCompletion";
            this.chkCodeCompletion.Size = new System.Drawing.Size(140, 17);
            this.chkCodeCompletion.TabIndex = 2;
            this.chkCodeCompletion.Text = "Enable code completion";
            this.chkCodeCompletion.UseVisualStyleBackColor = true;
            // 
            // chkBeginCompletion
            // 
            this.chkBeginCompletion.AutoSize = true;
            this.chkBeginCompletion.Location = new System.Drawing.Point(100, 49);
            this.chkBeginCompletion.Name = "chkBeginCompletion";
            this.chkBeginCompletion.Size = new System.Drawing.Size(155, 17);
            this.chkBeginCompletion.TabIndex = 3;
            this.chkBeginCompletion.Text = "Enable \\begin{} completion";
            this.chkBeginCompletion.UseVisualStyleBackColor = true;
            // 
            // chkShowSnippetThumbs
            // 
            this.chkShowSnippetThumbs.AutoSize = true;
            this.chkShowSnippetThumbs.Location = new System.Drawing.Point(100, 72);
            this.chkShowSnippetThumbs.Name = "chkShowSnippetThumbs";
            this.chkShowSnippetThumbs.Size = new System.Drawing.Size(143, 17);
            this.chkShowSnippetThumbs.TabIndex = 4;
            this.chkShowSnippetThumbs.Text = "Show snippet thumbnails";
            this.chkShowSnippetThumbs.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Font";
            // 
            // cmdFont
            // 
            this.cmdFont.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdFont.Location = new System.Drawing.Point(100, 95);
            this.cmdFont.Name = "cmdFont";
            this.cmdFont.Size = new System.Drawing.Size(288, 23);
            this.cmdFont.TabIndex = 6;
            this.cmdFont.Text = "The quick brown fox jumps over the lazy dog. ";
            this.cmdFont.UseVisualStyleBackColor = true;
            this.cmdFont.Click += new System.EventHandler(this.cmdFont_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(397, 236);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Compiler";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtPrepended, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtPrecompArgs, 0, 3);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(391, 230);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Code pre-appended";
            // 
            // txtPrepended
            // 
            this.txtPrepended.AcceptsReturn = true;
            this.txtPrepended.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrepended.Location = new System.Drawing.Point(3, 16);
            this.txtPrepended.Multiline = true;
            this.txtPrepended.Name = "txtPrepended";
            this.txtPrepended.Size = new System.Drawing.Size(385, 150);
            this.txtPrepended.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Precompilation arguments";
            // 
            // txtPrecompArgs
            // 
            this.txtPrecompArgs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecompArgs.Location = new System.Drawing.Point(3, 185);
            this.txtPrecompArgs.Name = "txtPrecompArgs";
            this.txtPrecompArgs.Size = new System.Drawing.Size(385, 20);
            this.txtPrecompArgs.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(397, 236);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Parser and Overlay";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label12, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label13, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label14, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.label15, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.numMarginBB, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.numCoordDec, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.cmdColorNode, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.cmdColorSNode, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.cmdColorScope, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.cmdColorSScope, 1, 5);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(391, 230);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Margin Auto Bounding Box";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Coordinate decimals";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Color overlay node";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Color overlay node (selected)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 110);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Color overlay scope";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(149, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "Color overlay scope (selected)";
            // 
            // numMarginBB
            // 
            this.numMarginBB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numMarginBB.DecimalPlaces = 1;
            this.numMarginBB.Location = new System.Drawing.Point(171, 3);
            this.numMarginBB.Name = "numMarginBB";
            this.numMarginBB.Size = new System.Drawing.Size(217, 20);
            this.numMarginBB.TabIndex = 6;
            // 
            // numCoordDec
            // 
            this.numCoordDec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numCoordDec.Location = new System.Drawing.Point(171, 29);
            this.numCoordDec.Name = "numCoordDec";
            this.numCoordDec.Size = new System.Drawing.Size(217, 20);
            this.numCoordDec.TabIndex = 7;
            // 
            // cmdColorNode
            // 
            this.cmdColorNode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdColorNode.Location = new System.Drawing.Point(171, 55);
            this.cmdColorNode.Name = "cmdColorNode";
            this.cmdColorNode.Size = new System.Drawing.Size(217, 23);
            this.cmdColorNode.TabIndex = 8;
            this.cmdColorNode.Text = " ";
            this.cmdColorNode.UseVisualStyleBackColor = true;
            this.cmdColorNode.Click += new System.EventHandler(this.cmdColorNode_Click);
            // 
            // cmdColorSNode
            // 
            this.cmdColorSNode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdColorSNode.Location = new System.Drawing.Point(171, 84);
            this.cmdColorSNode.Name = "cmdColorSNode";
            this.cmdColorSNode.Size = new System.Drawing.Size(217, 23);
            this.cmdColorSNode.TabIndex = 9;
            this.cmdColorSNode.Text = " ";
            this.cmdColorSNode.UseVisualStyleBackColor = true;
            this.cmdColorSNode.Click += new System.EventHandler(this.cmdColorNode_Click);
            // 
            // cmdColorScope
            // 
            this.cmdColorScope.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdColorScope.Location = new System.Drawing.Point(171, 113);
            this.cmdColorScope.Name = "cmdColorScope";
            this.cmdColorScope.Size = new System.Drawing.Size(217, 23);
            this.cmdColorScope.TabIndex = 10;
            this.cmdColorScope.Text = " ";
            this.cmdColorScope.UseVisualStyleBackColor = true;
            this.cmdColorScope.Click += new System.EventHandler(this.cmdColorNode_Click);
            // 
            // cmdColorSScope
            // 
            this.cmdColorSScope.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdColorSScope.Location = new System.Drawing.Point(171, 142);
            this.cmdColorSScope.Name = "cmdColorSScope";
            this.cmdColorSScope.Size = new System.Drawing.Size(217, 23);
            this.cmdColorSScope.TabIndex = 11;
            this.cmdColorSScope.Text = " ";
            this.cmdColorSScope.UseVisualStyleBackColor = true;
            this.cmdColorSScope.Click += new System.EventHandler(this.cmdColorNode_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmdCancel);
            this.panel1.Controls.Add(this.cmdSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 33);
            this.panel1.TabIndex = 1;
            // 
            // cmdCancel
            // 
            this.cmdCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(248, 7);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(75, 23);
            this.cmdCancel.TabIndex = 1;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSave.Location = new System.Drawing.Point(327, 7);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(75, 23);
            this.cmdSave.TabIndex = 0;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(405, 295);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsDialog";
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsDialog_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeOutSnippetCompile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTimeoutCompile)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMarginBB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCoordDec)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPdfLatex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHtLatex;
        private System.Windows.Forms.TextBox txtExtViewer;
        private System.Windows.Forms.NumericUpDown numTimeOutSnippetCompile;
        private System.Windows.Forms.NumericUpDown numTimeoutCompile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox chkShowLineNr;
        private System.Windows.Forms.CheckBox chkCodeCompletion;
        private System.Windows.Forms.CheckBox chkBeginCompletion;
        private System.Windows.Forms.CheckBox chkShowSnippetThumbs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrepended;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrecompArgs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numMarginBB;
        private System.Windows.Forms.NumericUpDown numCoordDec;
        private System.Windows.Forms.Button cmdColorNode;
        private System.Windows.Forms.Button cmdColorSNode;
        private System.Windows.Forms.Button cmdColorScope;
        private System.Windows.Forms.Button cmdColorSScope;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button cmdFont;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}