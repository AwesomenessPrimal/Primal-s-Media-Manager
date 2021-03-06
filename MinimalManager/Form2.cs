﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PrimalMediaManager
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            fileType.Items.AddRange(new string[] { "mp4", "avi", "mov", "flv", "wmv" });
            fileType.SelectedIndex = 0;
        }

        public int parseTime(Control c)
        {
            int r;
            string[] p = c.Text.Split(':');
            r = int.Parse(p[0]) * 3600;
            r += int.Parse(p[1]) * 60;
            r += int.Parse(p[2]);
            return r;
        }

        private void convertStart_CheckedChanged(object sender, EventArgs e)
        {
            startBox.Visible = convertStart.Checked;
        }

        private void convertEnd_CheckedChanged(object sender, EventArgs e)
        {
            endBox.Visible = convertEnd.Checked;
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            fileBox.Text = System.IO.Path.ChangeExtension(saveFileDialog1.FileName, null);
        }

        private void videoButton_CheckedChanged(object sender, EventArgs e)
        {
            string[] videoTypes = { "mp4", "avi", "mov", "flv", "wmv" };
            fileType.Items.Clear();
            fileType.Items.AddRange(videoTypes);
            fileType.SelectedIndex = 0;
        }

        private void audioButton_CheckedChanged(object sender, EventArgs e)
        {
            string[] audioTypes = { "mp3", "wav", "opus", "aac", "flac" };
            fileType.Items.Clear();
            fileType.Items.AddRange(audioTypes);
            fileType.SelectedIndex = 0;
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            int startTime, endTime;
            bool notifyStop = false;
            if (convertStart.Checked)
            {
                startTime = parseTime(startBox);
            }
            else
            {
                startTime = 0;
            }
            if (convertEnd.Checked)
            {
                endTime = parseTime(endBox);
            }
            else
            {
                endTime = 0;
            }
            if (urlBox.Text == "" || fileBox.Text == "")
            {
                MessageBox.Show("Please make sure you put in the URL and chose a file location.", "Empty Text Box", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                notifyStop = true;
            }
            else if (videoButton.Checked)
            {
                string readError;
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.FileName = "cmd.exe";
                //Command that downloads. Do not modify.
                startInfo.Arguments = "/c youtube-dl.exe -o " + "\"" + fileBox.Text + "." +
                    fileType.Items[fileType.SelectedIndex] + "\"" + " -f " + fileType.Items[fileType.SelectedIndex] +
                    " \"" + urlBox.Text + "\"" + " --ffmpeg-location \"" + System.AppDomain.CurrentDomain.BaseDirectory;
                startInfo.UseShellExecute = false;
                startInfo.RedirectStandardError = true;
                process.StartInfo = startInfo;
                process.Start();
                StreamReader reader = process.StandardError;
                readError = reader.ReadLine();
                if (!(readError == null))
                {
                    MessageBox.Show(readError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    notifyStop = true;
                }
                process.WaitForExit();
            }
            else
            {
                System.Diagnostics.Process process = new System.Diagnostics.Process();
                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                startInfo.FileName = "cmd.exe";
                //Command that downloads. Do not modify.
                startInfo.Arguments = "/c youtube-dl.exe -o " + "\"" + fileBox.Text + ".m4a \"" +
                    " --extract-audio --audio-format " + fileType.Items[fileType.SelectedIndex] + " --audio-quality 0 \"" +
                    urlBox.Text + "\"" + " --ffmpeg-location \"" + System.AppDomain.CurrentDomain.BaseDirectory;
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
            }

            if (!notifyStop)
            {
                if (File.Exists(fileBox.Text + "." + fileType.Items[fileType.SelectedIndex]))
                {
                    notifyIcon1.BalloonTipText = "Your file has finished downloading.";
                    notifyIcon1.BalloonTipTitle = "Download Complete";
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                    notifyIcon1.ShowBalloonTip(5);
                }
                else
                {
                    notifyIcon1.BalloonTipText = "Please make sure the URL is valid. If this keeps up, notify the developer.";
                    notifyIcon1.BalloonTipTitle = "Failed to Download";
                    notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                    notifyIcon1.ShowBalloonTip(5);
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                tabControl1.SelectedIndex = 0;
                var input = convertOpen.ShowDialog();
                if (input == DialogResult.Cancel)
                {
                    //Stops
                }
                else
                {
                    var output = convertSave.ShowDialog();
                    if (output == DialogResult.Cancel)
                    {

                    }
                    else
                    {
                        System.Diagnostics.Process process = new System.Diagnostics.Process();
                        System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                        startInfo.FileName = "cmd.exe";
                        //Command that converts. Do not modify.
                        startInfo.Arguments = "/c ffmpeg.exe -i " + "\"" + convertOpen.FileName + "\"" + " " + "\"" + convertSave.FileName + "\"";
                        process.StartInfo = startInfo;
                        process.Start();
                        process.WaitForExit();
                        if (File.Exists(convertSave.FileName))
                        {
                            notifyIcon1.BalloonTipText = "Your file has successfully been converted.";
                            notifyIcon1.BalloonTipTitle = "File Converted";
                            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                            notifyIcon1.ShowBalloonTip(5);
                        }
                        else
                        {
                            notifyIcon1.BalloonTipText = "Is the file a supported video or audio type?";
                            notifyIcon1.BalloonTipTitle = "Failed to Convert";
                            notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
                            notifyIcon1.ShowBalloonTip(5);
                        }
                    }
                }
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c youtube-dl.exe --update";
            process.StartInfo = startInfo;
            process.Start();
            process.WaitForExit();
        }
    }
}
