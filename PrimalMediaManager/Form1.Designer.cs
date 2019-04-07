namespace PrimalMediaManager
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.endBox = new System.Windows.Forms.MaskedTextBox();
            this.startBox = new System.Windows.Forms.MaskedTextBox();
            this.fileType = new Bunifu.Framework.UI.BunifuDropdown();
            this.audioButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.videoButton = new MaterialSkin.Controls.MaterialRadioButton();
            this.browseButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.fileBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.urlBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.convertEnd = new MaterialSkin.Controls.MaterialCheckBox();
            this.convertStart = new MaterialSkin.Controls.MaterialCheckBox();
            this.downloadButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.updateButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.convertButton = new System.Windows.Forms.LinkLabel();
            this.convertOpen = new System.Windows.Forms.OpenFileDialog();
            this.convertSave = new System.Windows.Forms.SaveFileDialog();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(-3, 63);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(530, 305);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage1.Controls.Add(this.endBox);
            this.tabPage1.Controls.Add(this.startBox);
            this.tabPage1.Controls.Add(this.fileType);
            this.tabPage1.Controls.Add(this.audioButton);
            this.tabPage1.Controls.Add(this.videoButton);
            this.tabPage1.Controls.Add(this.browseButton);
            this.tabPage1.Controls.Add(this.fileBox);
            this.tabPage1.Controls.Add(this.urlBox);
            this.tabPage1.Controls.Add(this.convertEnd);
            this.tabPage1.Controls.Add(this.convertStart);
            this.tabPage1.Controls.Add(this.downloadButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(522, 279);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Download";
            // 
            // endBox
            // 
            this.endBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.endBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.endBox.ForeColor = System.Drawing.Color.White;
            this.endBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.endBox.Location = new System.Drawing.Point(376, 203);
            this.endBox.Mask = "00:00:00";
            this.endBox.Name = "endBox";
            this.endBox.Size = new System.Drawing.Size(63, 24);
            this.endBox.TabIndex = 17;
            this.endBox.Text = "000000";
            this.endBox.Visible = false;
            // 
            // startBox
            // 
            this.startBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.startBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.startBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.startBox.ForeColor = System.Drawing.Color.White;
            this.startBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.startBox.Location = new System.Drawing.Point(84, 203);
            this.startBox.Mask = "00:00:00";
            this.startBox.Name = "startBox";
            this.startBox.Size = new System.Drawing.Size(63, 24);
            this.startBox.TabIndex = 16;
            this.startBox.Text = "000000";
            this.startBox.Visible = false;
            // 
            // fileType
            // 
            this.fileType.BackColor = System.Drawing.Color.Transparent;
            this.fileType.BorderRadius = 3;
            this.fileType.DisabledColor = System.Drawing.Color.Gray;
            this.fileType.ForeColor = System.Drawing.Color.White;
            this.fileType.Items = new string[0];
            this.fileType.Location = new System.Drawing.Point(353, 130);
            this.fileType.Name = "fileType";
            this.fileType.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.fileType.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.fileType.selectedIndex = -1;
            this.fileType.Size = new System.Drawing.Size(99, 30);
            this.fileType.TabIndex = 15;
            // 
            // audioButton
            // 
            this.audioButton.AutoSize = true;
            this.audioButton.Depth = 0;
            this.audioButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.audioButton.Location = new System.Drawing.Point(209, 130);
            this.audioButton.Margin = new System.Windows.Forms.Padding(0);
            this.audioButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.audioButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.audioButton.Name = "audioButton";
            this.audioButton.Ripple = true;
            this.audioButton.Size = new System.Drawing.Size(65, 30);
            this.audioButton.TabIndex = 14;
            this.audioButton.TabStop = true;
            this.audioButton.Text = "Audio";
            this.audioButton.UseVisualStyleBackColor = true;
            this.audioButton.CheckedChanged += new System.EventHandler(this.audioButton_CheckedChanged);
            // 
            // videoButton
            // 
            this.videoButton.AutoSize = true;
            this.videoButton.Checked = true;
            this.videoButton.Depth = 0;
            this.videoButton.Font = new System.Drawing.Font("Roboto", 10F);
            this.videoButton.Location = new System.Drawing.Point(65, 130);
            this.videoButton.Margin = new System.Windows.Forms.Padding(0);
            this.videoButton.MouseLocation = new System.Drawing.Point(-1, -1);
            this.videoButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.videoButton.Name = "videoButton";
            this.videoButton.Ripple = true;
            this.videoButton.Size = new System.Drawing.Size(64, 30);
            this.videoButton.TabIndex = 13;
            this.videoButton.TabStop = true;
            this.videoButton.Text = "Video";
            this.videoButton.UseVisualStyleBackColor = true;
            this.videoButton.CheckedChanged += new System.EventHandler(this.videoButton_CheckedChanged);
            // 
            // browseButton
            // 
            this.browseButton.AutoSize = true;
            this.browseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.browseButton.Depth = 0;
            this.browseButton.Icon = null;
            this.browseButton.Location = new System.Drawing.Point(376, 85);
            this.browseButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.browseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.browseButton.Name = "browseButton";
            this.browseButton.Primary = false;
            this.browseButton.Size = new System.Drawing.Size(76, 36);
            this.browseButton.TabIndex = 9;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // fileBox
            // 
            this.fileBox.Depth = 0;
            this.fileBox.Hint = "File Location";
            this.fileBox.Location = new System.Drawing.Point(73, 92);
            this.fileBox.MaxLength = 32767;
            this.fileBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.fileBox.Name = "fileBox";
            this.fileBox.PasswordChar = '\0';
            this.fileBox.SelectedText = "";
            this.fileBox.SelectionLength = 0;
            this.fileBox.SelectionStart = 0;
            this.fileBox.Size = new System.Drawing.Size(296, 23);
            this.fileBox.TabIndex = 8;
            this.fileBox.TabStop = false;
            this.fileBox.UseSystemPasswordChar = false;
            // 
            // urlBox
            // 
            this.urlBox.Depth = 0;
            this.urlBox.Hint = "URL";
            this.urlBox.Location = new System.Drawing.Point(73, 53);
            this.urlBox.MaxLength = 32767;
            this.urlBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.urlBox.Name = "urlBox";
            this.urlBox.PasswordChar = '\0';
            this.urlBox.SelectedText = "";
            this.urlBox.SelectionLength = 0;
            this.urlBox.SelectionStart = 0;
            this.urlBox.Size = new System.Drawing.Size(379, 23);
            this.urlBox.TabIndex = 7;
            this.urlBox.TabStop = false;
            this.urlBox.UseSystemPasswordChar = false;
            // 
            // convertEnd
            // 
            this.convertEnd.AutoSize = true;
            this.convertEnd.Depth = 0;
            this.convertEnd.Enabled = false;
            this.convertEnd.Font = new System.Drawing.Font("Roboto", 10F);
            this.convertEnd.Location = new System.Drawing.Point(353, 170);
            this.convertEnd.Margin = new System.Windows.Forms.Padding(0);
            this.convertEnd.MouseLocation = new System.Drawing.Point(-1, -1);
            this.convertEnd.MouseState = MaterialSkin.MouseState.HOVER;
            this.convertEnd.Name = "convertEnd";
            this.convertEnd.Ripple = true;
            this.convertEnd.Size = new System.Drawing.Size(99, 30);
            this.convertEnd.TabIndex = 5;
            this.convertEnd.Text = "End at time";
            this.convertEnd.UseVisualStyleBackColor = true;
            this.convertEnd.Visible = false;
            this.convertEnd.CheckedChanged += new System.EventHandler(this.convertEnd_CheckedChanged);
            // 
            // convertStart
            // 
            this.convertStart.AutoSize = true;
            this.convertStart.Depth = 0;
            this.convertStart.Enabled = false;
            this.convertStart.Font = new System.Drawing.Font("Roboto", 10F);
            this.convertStart.Location = new System.Drawing.Point(65, 170);
            this.convertStart.Margin = new System.Windows.Forms.Padding(0);
            this.convertStart.MouseLocation = new System.Drawing.Point(-1, -1);
            this.convertStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.convertStart.Name = "convertStart";
            this.convertStart.Ripple = true;
            this.convertStart.Size = new System.Drawing.Size(106, 30);
            this.convertStart.TabIndex = 4;
            this.convertStart.Text = "Start at time";
            this.convertStart.UseVisualStyleBackColor = true;
            this.convertStart.Visible = false;
            this.convertStart.CheckedChanged += new System.EventHandler(this.convertStart_CheckedChanged);
            // 
            // downloadButton
            // 
            this.downloadButton.AutoSize = true;
            this.downloadButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.downloadButton.Depth = 0;
            this.downloadButton.Icon = null;
            this.downloadButton.Location = new System.Drawing.Point(209, 221);
            this.downloadButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Primary = true;
            this.downloadButton.Size = new System.Drawing.Size(96, 36);
            this.downloadButton.TabIndex = 3;
            this.downloadButton.Text = "Download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPage2.Controls.Add(this.tableLayoutPanel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(522, 279);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "About";
            // 
            // updateButton
            // 
            this.updateButton.AutoSize = true;
            this.updateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.updateButton.Depth = 0;
            this.updateButton.Icon = null;
            this.updateButton.Location = new System.Drawing.Point(3, 40);
            this.updateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.updateButton.Name = "updateButton";
            this.updateButton.Primary = true;
            this.updateButton.Size = new System.Drawing.Size(73, 17);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-3, 62);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(530, 33);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "All files (*.*)|*.*";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Primal\'s Media Manager";
            this.notifyIcon1.Visible = true;
            // 
            // convertButton
            // 
            this.convertButton.ActiveLinkColor = System.Drawing.Color.White;
            this.convertButton.AutoSize = true;
            this.convertButton.BackColor = System.Drawing.Color.Transparent;
            this.convertButton.LinkColor = System.Drawing.Color.White;
            this.convertButton.Location = new System.Drawing.Point(399, 6);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(44, 13);
            this.convertButton.TabIndex = 2;
            this.convertButton.TabStop = true;
            this.convertButton.Text = "Convert";
            this.convertButton.VisitedLinkColor = System.Drawing.Color.White;
            this.convertButton.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.convertButton_LinkClicked);
            // 
            // convertOpen
            // 
            this.convertOpen.Filter = "All files (*.*)|*.*";
            // 
            // convertSave
            // 
            this.convertSave.Filter = resources.GetString("convertSave.Filter");
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67F));
            this.tableLayoutPanel.Controls.Add(this.updateButton, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.logoPictureBox, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.textBoxDescription, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.materialLabel1, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.materialLabel2, 1, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 7;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.55939F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.195402F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.34483F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.21456F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.35885F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(522, 279);
            this.tableLayoutPanel.TabIndex = 3;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(3, 63);
            this.logoPictureBox.Name = "logoPictureBox";
            this.tableLayoutPanel.SetRowSpan(this.logoPictureBox, 5);
            this.logoPictureBox.Size = new System.Drawing.Size(166, 213);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 12;
            this.logoPictureBox.TabStop = false;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBoxDescription.Location = new System.Drawing.Point(178, 89);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.tableLayoutPanel.SetRowSpan(this.textBoxDescription, 4);
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxDescription.Size = new System.Drawing.Size(341, 187);
            this.textBoxDescription.TabIndex = 23;
            this.textBoxDescription.TabStop = false;
            this.textBoxDescription.Text = "Made using:\r\nyoutube-dl\r\nffmpeg\r\nbuntifu\r\nMaterialSkin\r\nMetroFramework";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(175, 37);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(170, 19);
            this.materialLabel1.TabIndex = 24;
            this.materialLabel1.Text = "Primal\'s Media Manager";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(175, 60);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(132, 19);
            this.materialLabel2.TabIndex = 25;
            this.materialLabel2.Text = "0.0.1.0 Alpha Build";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 365);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.Text = "Primal\'s Media Manager";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialRaisedButton downloadButton;
        private MaterialSkin.Controls.MaterialCheckBox convertStart;
        private MaterialSkin.Controls.MaterialCheckBox convertEnd;
        private MaterialSkin.Controls.MaterialFlatButton browseButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField fileBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField urlBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MaterialSkin.Controls.MaterialRadioButton audioButton;
        private MaterialSkin.Controls.MaterialRadioButton videoButton;
        private Bunifu.Framework.UI.BunifuDropdown fileType;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.LinkLabel convertButton;
        private System.Windows.Forms.OpenFileDialog convertOpen;
        private System.Windows.Forms.SaveFileDialog convertSave;
        private MaterialSkin.Controls.MaterialRaisedButton updateButton;
        private System.Windows.Forms.MaskedTextBox startBox;
        private System.Windows.Forms.MaskedTextBox endBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.TextBox textBoxDescription;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}

