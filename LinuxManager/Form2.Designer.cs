namespace PrimalMediaManager
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.endBox = new System.Windows.Forms.MaskedTextBox();
            this.startBox = new System.Windows.Forms.MaskedTextBox();
            this.convertEnd = new System.Windows.Forms.CheckBox();
            this.convertStart = new System.Windows.Forms.CheckBox();
            this.downloadButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.fileType = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.audioButton = new System.Windows.Forms.RadioButton();
            this.videoButton = new System.Windows.Forms.RadioButton();
            this.fileBox = new System.Windows.Forms.TextBox();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.convertOpen = new System.Windows.Forms.OpenFileDialog();
            this.convertSave = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(381, 241);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.endBox);
            this.tabPage1.Controls.Add(this.startBox);
            this.tabPage1.Controls.Add(this.convertEnd);
            this.tabPage1.Controls.Add(this.convertStart);
            this.tabPage1.Controls.Add(this.downloadButton);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.fileType);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.fileBox);
            this.tabPage1.Controls.Add(this.urlBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(373, 215);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Download";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "File Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "URL";
            // 
            // endBox
            // 
            this.endBox.BackColor = System.Drawing.SystemColors.Window;
            this.endBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.endBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.endBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.endBox.Location = new System.Drawing.Point(273, 155);
            this.endBox.Mask = "00:00:00";
            this.endBox.Name = "endBox";
            this.endBox.Size = new System.Drawing.Size(63, 24);
            this.endBox.TabIndex = 18;
            this.endBox.Text = "000000";
            this.endBox.Visible = false;
            // 
            // startBox
            // 
            this.startBox.BackColor = System.Drawing.SystemColors.Window;
            this.startBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.startBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.startBox.Location = new System.Drawing.Point(24, 155);
            this.startBox.Mask = "00:00:00";
            this.startBox.Name = "startBox";
            this.startBox.Size = new System.Drawing.Size(63, 24);
            this.startBox.TabIndex = 17;
            this.startBox.Text = "000000";
            this.startBox.Visible = false;
            // 
            // convertEnd
            // 
            this.convertEnd.AutoSize = true;
            this.convertEnd.Enabled = false;
            this.convertEnd.Location = new System.Drawing.Point(268, 132);
            this.convertEnd.Name = "convertEnd";
            this.convertEnd.Size = new System.Drawing.Size(83, 17);
            this.convertEnd.TabIndex = 9;
            this.convertEnd.Text = "End at Time";
            this.convertEnd.UseVisualStyleBackColor = true;
            this.convertEnd.CheckedChanged += new System.EventHandler(this.convertEnd_CheckedChanged);
            // 
            // convertStart
            // 
            this.convertStart.AutoSize = true;
            this.convertStart.Enabled = false;
            this.convertStart.Location = new System.Drawing.Point(24, 132);
            this.convertStart.Name = "convertStart";
            this.convertStart.Size = new System.Drawing.Size(86, 17);
            this.convertStart.TabIndex = 8;
            this.convertStart.Text = "Start at Time";
            this.convertStart.UseVisualStyleBackColor = true;
            this.convertStart.CheckedChanged += new System.EventHandler(this.convertStart_CheckedChanged);
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(143, 176);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(75, 23);
            this.downloadButton.TabIndex = 7;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // fileType
            // 
            this.fileType.FormattingEnabled = true;
            this.fileType.Location = new System.Drawing.Point(293, 100);
            this.fileType.Name = "fileType";
            this.fileType.Size = new System.Drawing.Size(55, 21);
            this.fileType.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.audioButton);
            this.panel1.Controls.Add(this.videoButton);
            this.panel1.Location = new System.Drawing.Point(21, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 27);
            this.panel1.TabIndex = 2;
            // 
            // audioButton
            // 
            this.audioButton.AutoSize = true;
            this.audioButton.Location = new System.Drawing.Point(211, 3);
            this.audioButton.Name = "audioButton";
            this.audioButton.Size = new System.Drawing.Size(52, 17);
            this.audioButton.TabIndex = 1;
            this.audioButton.Text = "Audio";
            this.audioButton.UseVisualStyleBackColor = true;
            this.audioButton.CheckedChanged += new System.EventHandler(this.audioButton_CheckedChanged);
            // 
            // videoButton
            // 
            this.videoButton.AutoSize = true;
            this.videoButton.Checked = true;
            this.videoButton.Location = new System.Drawing.Point(3, 3);
            this.videoButton.Name = "videoButton";
            this.videoButton.Size = new System.Drawing.Size(52, 17);
            this.videoButton.TabIndex = 0;
            this.videoButton.TabStop = true;
            this.videoButton.Text = "Video";
            this.videoButton.UseVisualStyleBackColor = true;
            this.videoButton.CheckedChanged += new System.EventHandler(this.videoButton_CheckedChanged);
            // 
            // fileBox
            // 
            this.fileBox.Location = new System.Drawing.Point(21, 60);
            this.fileBox.Name = "fileBox";
            this.fileBox.Size = new System.Drawing.Size(246, 20);
            this.fileBox.TabIndex = 1;
            // 
            // urlBox
            // 
            this.urlBox.Location = new System.Drawing.Point(21, 21);
            this.urlBox.Name = "urlBox";
            this.urlBox.Size = new System.Drawing.Size(327, 20);
            this.urlBox.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(373, 215);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Convert";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(373, 215);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "About";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.labelProductName, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelVersion, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 1, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 6;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.35885F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(367, 209);
            this.tableLayoutPanel.TabIndex = 2;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 6);
            this.logoPictureBox.Size = new System.Drawing.Size(115, 203);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // labelProductName
            // 
            this.labelProductName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProductName.Location = new System.Drawing.Point(127, 0);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelProductName.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(237, 17);
            this.labelProductName.TabIndex = 19;
            this.labelProductName.Text = "Primal\'s Media Manager";
            this.labelProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelVersion
            // 
            this.labelVersion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVersion.Location = new System.Drawing.Point(127, 20);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.labelVersion.MaximumSize = new System.Drawing.Size(0, 17);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(237, 17);
            this.labelVersion.TabIndex = 0;
            this.labelVersion.Text = "0.0.1.0 Alpha Build";
            this.labelVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Location = new System.Drawing.Point(127, 43);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.tableLayoutPanel.SetRowSpan(this.textBoxDescription, 4);
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescription.Size = new System.Drawing.Size(237, 163);
            this.textBoxDescription.TabIndex = 23;
            this.textBoxDescription.TabStop = false;
            this.textBoxDescription.Text = "Made using:\r\nyoutube-dl\r\nffmpeg\r\nbuntifu\r\nMaterialSkin\r\nMetroFramework";
            // 
            // convertOpen
            // 
            this.convertOpen.Filter = "All files (*.*)|*.*";
            this.convertOpen.Title = "Choose file to convert";
            // 
            // convertSave
            // 
            this.convertSave.Filter = resources.GetString("convertSave.Filter");
            this.convertSave.Title = "Choose where to save converted file";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 241);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Primal\'s Media Manager";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.TextBox fileBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton audioButton;
        private System.Windows.Forms.RadioButton videoButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox fileType;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog convertOpen;
        private System.Windows.Forms.SaveFileDialog convertSave;
        private System.Windows.Forms.CheckBox convertEnd;
        private System.Windows.Forms.CheckBox convertStart;
        private System.Windows.Forms.MaskedTextBox startBox;
        private System.Windows.Forms.MaskedTextBox endBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TabPage tabPage3;
    }
}