namespace CyberShield_V3.Panels
{
    partial class SettingsPanel
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsPanel));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            pnlProtection = new Guna.UI2.WinForms.Guna2Panel();
            pictureBox1 = new PictureBox();
            lblProtState = new Label();
            toggleProtection = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            lblProtDesc = new Label();
            lblProtHeader = new Label();
            panelStatus = new Guna.UI2.WinForms.Guna2Panel();
            label10 = new Label();
            lblLastScan = new Label();
            label5 = new Label();
            label16 = new Label();
            btnUpdateRules = new Guna.UI2.WinForms.Guna2Button();
            lblUpdateStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Panel1.SuspendLayout();
            pnlProtection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelStatus.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(pnlProtection);
            guna2Panel1.Controls.Add(panelStatus);
            guna2Panel1.Controls.Add(btnUpdateRules);
            guna2Panel1.Controls.Add(lblUpdateStatus);
            guna2Panel1.CustomizableEdges = customizableEdges9;
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.FillColor = Color.FromArgb(30, 33, 57);
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Panel1.Size = new Size(725, 442);
            guna2Panel1.TabIndex = 0;
            // 
            // pnlProtection
            // 
            pnlProtection.BackColor = Color.Transparent;
            pnlProtection.BorderColor = Color.FromArgb(100, 150, 255);
            pnlProtection.BorderRadius = 6;
            pnlProtection.BorderThickness = 1;
            pnlProtection.Controls.Add(pictureBox1);
            pnlProtection.Controls.Add(lblProtState);
            pnlProtection.Controls.Add(toggleProtection);
            pnlProtection.Controls.Add(lblProtDesc);
            pnlProtection.Controls.Add(lblProtHeader);
            pnlProtection.CustomizableEdges = customizableEdges3;
            pnlProtection.FillColor = Color.FromArgb(40, 100, 150, 255);
            pnlProtection.Location = new Point(31, 32);
            pnlProtection.Name = "pnlProtection";
            pnlProtection.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pnlProtection.Size = new Size(656, 100);
            pnlProtection.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // lblProtState
            // 
            lblProtState.AutoSize = true;
            lblProtState.ForeColor = Color.White;
            lblProtState.Location = new Point(550, 45);
            lblProtState.Name = "lblProtState";
            lblProtState.Size = new Size(40, 15);
            lblProtState.TabIndex = 0;
            lblProtState.Text = "Active";
            // 
            // toggleProtection
            // 
            toggleProtection.Checked = true;
            toggleProtection.CheckedState.FillColor = Color.LimeGreen;
            toggleProtection.CustomizableEdges = customizableEdges1;
            toggleProtection.Location = new Point(486, 43);
            toggleProtection.Name = "toggleProtection";
            toggleProtection.ShadowDecoration.CustomizableEdges = customizableEdges2;
            toggleProtection.Size = new Size(49, 22);
            toggleProtection.TabIndex = 1;
            toggleProtection.UncheckedState.FillColor = Color.Gray;
            // 
            // lblProtDesc
            // 
            lblProtDesc.AutoSize = true;
            lblProtDesc.ForeColor = Color.WhiteSmoke;
            lblProtDesc.Location = new Point(58, 53);
            lblProtDesc.Name = "lblProtDesc";
            lblProtDesc.Size = new Size(216, 15);
            lblProtDesc.TabIndex = 3;
            lblProtDesc.Text = "Monitors files in background for threats";
            // 
            // lblProtHeader
            // 
            lblProtHeader.AutoSize = true;
            lblProtHeader.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblProtHeader.ForeColor = Color.White;
            lblProtHeader.Location = new Point(58, 19);
            lblProtHeader.Name = "lblProtHeader";
            lblProtHeader.Size = new Size(219, 30);
            lblProtHeader.TabIndex = 4;
            lblProtHeader.Text = "Real-Time Protection";
            // 
            // panelStatus
            // 
            panelStatus.BackColor = Color.Transparent;
            panelStatus.BorderColor = Color.FromArgb(60, 255, 255, 255);
            panelStatus.BorderRadius = 6;
            panelStatus.BorderThickness = 1;
            panelStatus.Controls.Add(label10);
            panelStatus.Controls.Add(lblLastScan);
            panelStatus.Controls.Add(label5);
            panelStatus.Controls.Add(label16);
            panelStatus.CustomizableEdges = customizableEdges5;
            panelStatus.FillColor = Color.FromArgb(40, 0, 0, 0);
            panelStatus.Location = new Point(31, 147);
            panelStatus.Name = "panelStatus";
            panelStatus.ShadowDecoration.CustomizableEdges = customizableEdges6;
            panelStatus.Size = new Size(294, 99);
            panelStatus.TabIndex = 8;
            // 
            // label10
            // 
            label10.ForeColor = Color.White;
            label10.Location = new Point(100, 35);
            label10.Name = "label10";
            label10.Size = new Size(100, 23);
            label10.TabIndex = 0;
            label10.Text = "Fauzan Gauhar Khan";
            // 
            // lblLastScan
            // 
            lblLastScan.ForeColor = SystemColors.Control;
            lblLastScan.Location = new Point(112, 14);
            lblLastScan.Name = "lblLastScan";
            lblLastScan.Size = new Size(100, 23);
            lblLastScan.TabIndex = 1;
            lblLastScan.Text = "v1.0";
            // 
            // label5
            // 
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(15, 14);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 4;
            label5.Text = "Current Version:";
            // 
            // label16
            // 
            label16.ForeColor = SystemColors.Control;
            label16.Location = new Point(15, 35);
            label16.Name = "label16";
            label16.Size = new Size(100, 23);
            label16.TabIndex = 5;
            label16.Text = "Developed By:";
            // 
            // btnUpdateRules
            // 
            btnUpdateRules.BorderRadius = 6;
            btnUpdateRules.CustomizableEdges = customizableEdges7;
            btnUpdateRules.FillColor = Color.FromArgb(16, 185, 129);
            btnUpdateRules.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnUpdateRules.ForeColor = Color.White;
            btnUpdateRules.Location = new Point(352, 147);
            btnUpdateRules.Name = "btnUpdateRules";
            btnUpdateRules.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnUpdateRules.Size = new Size(180, 40);
            btnUpdateRules.TabIndex = 10;
            btnUpdateRules.Text = "Update YARA Rules";
            btnUpdateRules.Click += btnUpdateRules_Click;
            // 
            // lblUpdateStatus
            // 
            lblUpdateStatus.BackColor = Color.Transparent;
            lblUpdateStatus.Font = new Font("Segoe UI", 8F);
            lblUpdateStatus.ForeColor = Color.Gray;
            lblUpdateStatus.Location = new Point(352, 192);
            lblUpdateStatus.Name = "lblUpdateStatus";
            lblUpdateStatus.Size = new Size(105, 15);
            lblUpdateStatus.TabIndex = 11;
            lblUpdateStatus.Text = "Last updated: Never";
            // 
            // SettingsPanel
            // 
            Controls.Add(guna2Panel1);
            Name = "SettingsPanel";
            Size = new Size(725, 442);
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            pnlProtection.ResumeLayout(false);
            pnlProtection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelStatus.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        // Variables
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel panelStatus;
        private System.Windows.Forms.Label lblLastScan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        public Guna.UI2.WinForms.Guna2Panel pnlProtection;
        public Guna.UI2.WinForms.Guna2ToggleSwitch toggleProtection;
        private System.Windows.Forms.Label lblProtHeader;
        private System.Windows.Forms.Label lblProtDesc;
        public System.Windows.Forms.Label lblProtState;
        private PictureBox pictureBox1;

        // Added variables for update feature
        private Guna.UI2.WinForms.Guna2Button btnUpdateRules;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUpdateStatus;
    }
}