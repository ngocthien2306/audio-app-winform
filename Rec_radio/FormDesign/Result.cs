using Rec_radio.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rec_radio.FormDesign
{
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        private void btnSaveTN_Click(object sender, EventArgs e)
        {
            byte[] audioBytes = File.ReadAllBytes(txtPath.Text);

            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string selectedFolder = dialog.SelectedPath;

                    string fileName = $"WavFile_{DateTime.Now:yyyyMMdd_HHmmss}.wav";

                    string filePath = Path.Combine(selectedFolder, fileName);

                    File.WriteAllBytes(filePath, audioBytes);

                    MessageBox.Show($"WAV file saved to: {filePath}", "File Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSaveFN_Click(object sender, EventArgs e)
        {

        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            AudioPlayer.PlayAudio(txtPath.Text);
        }
    }
}
