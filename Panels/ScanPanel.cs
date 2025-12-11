using System;
using System.Drawing;
using System.Windows.Forms;

namespace CyberShield_V3
{
    public partial class ScanPanel : UserControl
    {
        // Logic Variables
        private int totalFilesScanned = 0;
        private int threatsFound = 0;

        public event EventHandler? BackClicked;
        public event EventHandler? ScanCancelled;

        public ScanPanel()
        {
            InitializeComponent();

            // Prevent crash with circular bar animation
            if (scanCircularBar != null)
            {
                scanCircularBar.Animated = false;
            }
        }

        // ---------------- Safe Invoke Wrapper ----------------
        private void SafeInvoke(Action action)
        {
            if (this.Disposing || this.IsDisposed) return;
            if (this.IsHandleCreated)
            {
                if (this.InvokeRequired)
                {
                    try { this.BeginInvoke(action); } catch { }
                }
                else
                {
                    action();
                }
            }
        }

        // ---------------- Scan Control ----------------
        public void StartScan()
        {
            totalFilesScanned = 0;
            threatsFound = 0;

            SafeInvoke(() =>
            {
                if (scanCircularBar != null) { scanCircularBar.Value = 0; scanCircularBar.Animated = true; }
                if (progressLabel != null) progressLabel.Text = "0%";

                if (statusLabel != null)
                {
                    statusLabel.Text = "Initializing...";
                    statusLabel.ForeColor = Color.FromArgb(100, 150, 255);
                }

                if (cancelButton != null)
                {
                    cancelButton.Visible = true;
                    cancelButton.Enabled = true; // Make sure it's enabled
                    cancelButton.Text = "STOP";  // Reset text
                    cancelButton.FillColor = Color.FromArgb(220, 50, 50); // Red color
                }

                if (backButton != null) backButton.Visible = false;

                UpdateFilesScanned(0);
                UpdateThreatsFound(0);
            });
        }

        public void UpdateProgress(int percentage)
        {
            percentage = Math.Max(0, Math.Min(percentage, 100));
            SafeInvoke(() =>
            {
                if (scanCircularBar != null) scanCircularBar.Value = percentage;
                if (progressLabel != null) progressLabel.Text = $"{percentage}%";
            });
        }

        public void UpdateStatus(string status)
        {
            SafeInvoke(() => { if (statusLabel != null) statusLabel.Text = status; });
        }

        public void UpdateCurrentFile(string filePath)
        {
            SafeInvoke(() =>
            {
                if (filePath.Length > 40)
                    filePath = "..." + filePath.Substring(filePath.Length - 37);
                if (currentFileLabel != null) currentFileLabel.Text = filePath;
            });
        }

        public void UpdateFilesScanned(int count)
        {
            totalFilesScanned = count;
            SafeInvoke(() => { if (filesScannedLabel != null) filesScannedLabel.Text = $"{count}"; });
        }

        public void UpdateThreatsFound(int count)
        {
            threatsFound = count;
            SafeInvoke(() =>
            {
                if (threatsFoundLabel != null)
                {
                    threatsFoundLabel.Text = $"{count}";
                    threatsFoundLabel.ForeColor = count > 0 ? Color.FromArgb(255, 80, 80) : Color.LimeGreen;
                }
            });
        }

        public void ScanComplete(bool wasCancelled)
        {
            SafeInvoke(() =>
            {
                if (scanCircularBar != null) scanCircularBar.Animated = false;

                if (statusLabel != null)
                {
                    if (wasCancelled)
                    {
                        statusLabel.Text = "Scan Cancelled";
                        statusLabel.ForeColor = Color.Orange;
                    }
                    else
                    {
                        statusLabel.Text = "Scan Complete";
                        statusLabel.ForeColor = Color.LimeGreen;
                    }
                }

                if (cancelButton != null) cancelButton.Visible = false;
                if (backButton != null) backButton.Visible = true;
            });
        }

        // ---------------- Button Events ----------------
        // This is the method linked in your Designer.cs
        private void CancelButton_Click(object sender, EventArgs e)
        {
            // 1. Give Instant Visual Feedback
            if (cancelButton != null)
            {
                cancelButton.Text = "Stopping...";
                cancelButton.Enabled = false; // Prevent double clicks
                cancelButton.FillColor = Color.Gray;
            }

            if (statusLabel != null)
            {
                statusLabel.Text = "Stopping scan process...";
            }

            // 2. Trigger the Event to notify Form1
            ScanCancelled?.Invoke(this, EventArgs.Empty);
        }

        private void BackButton_Click(object sender, EventArgs e) => BackClicked?.Invoke(this, EventArgs.Empty);
    }
}