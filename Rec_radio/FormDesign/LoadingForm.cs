using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rec_radio.FormDesign
{
    public partial class LoadingForm : Form
    {
        private ProgressBar progressBar;

        public LoadingForm()
        {
            InitializeComponent();
            InitializeProgressBar();
            LoadDataAsync();
        }

        private void InitializeProgressBar()
        {
            // Create and configure the progress bar.
            progressBar = new ProgressBar();
            progressBar.Dock = DockStyle.Bottom;
            Controls.Add(progressBar);
        }

        private async void LoadDataAsync()
        {
            try
            {
                // Simulate a time-consuming operation (e.g., loading data).
                await Task.Run(() =>
                {
                    // Perform your time-consuming operation here.
                    for (int i = 0; i <= 100; i += 10)
                    {
                        Thread.Sleep(160); // Simulating progress every 160 milliseconds
                        UpdateProgressBar(i); // Update progress bar
                    }
                });

                // Close the loading form when the operation is complete.
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private void UpdateProgressBar(int value)
        {
            if (progressBar.InvokeRequired)
            {
                // If called from a different thread, invoke the method on the UI thread.
                progressBar.Invoke(new Action<int>(UpdateProgressBar), value);
            }
            else
            {
                // Update the progress bar value.
                progressBar.Value = value;
            }
        }
    }
}
