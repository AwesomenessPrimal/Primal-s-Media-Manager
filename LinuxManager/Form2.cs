using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

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

        public void linuxNotify(String t, String m, bool b)
        {
            Process process = new System.Diagnostics.Process();
            Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "/usr/bin/notify-send";
            if(b)
            {
                proc.StartInfo.Arguments = "\"" + t + "\" " +
                "\"" + m + "\" -c transfer.complete";
            }
            else
            {
                proc.StartInfo.Arguments = "\"" + t + "\" " +
                "\"" + m + "\" -c transfer.error";
            }
            Console.Write(proc.StartInfo.Arguments);
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.Start();
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
                startInfo.FileName = "/usr/bin/youtube-dl";
                //Command that downloads. Do not modify.
                startInfo.Arguments = "-o " + "\"" + fileBox.Text + "." +
                    fileType.Items[fileType.SelectedIndex] + "\"" + " -f " + fileType.Items[fileType.SelectedIndex] +
                    " \"" + urlBox.Text + "\"";
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
                startInfo.FileName = "/usr/bin/youtube-dl";
                //Command that downloads. Do not modify.
                startInfo.Arguments = "-o " + "\"" + fileBox.Text + ".m4a \"" +
                    " --extract-audio --audio-format " + fileType.Items[fileType.SelectedIndex] + " --audio-quality 0 \"" +
                    urlBox.Text + "\"";
                process.StartInfo = startInfo;
                process.Start();
                process.WaitForExit();
            }

            if (!notifyStop)
            {
                if (File.Exists(fileBox.Text + "." + fileType.Items[fileType.SelectedIndex]))
                {
                    linuxNotify("Download Complete", "Your file has finished downloading.", true);
                }
                else
                {
                    linuxNotify("Failed to Download", "Please make sure the URL is valid. " +
                    	"If this keeps up, notify the developer.", false);
                }
            }
        }

        private void convertButton_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
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
                    //Command still a work in progress
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
                        linuxNotify("File Converted", "Your file has successfully been converted.", true);
                    }
                    else
                    {
                        linuxNotify("Failed to Convert", "Is the file a supported video or audio type?", false);
                    }
                }
            }
        }
    }
}
