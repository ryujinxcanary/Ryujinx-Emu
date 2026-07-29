namespace RyujinxLauncher
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblKeysStatus     = new System.Windows.Forms.Label();
            this.lblFirmware       = new System.Windows.Forms.Label();
            this.lblStatus         = new System.Windows.Forms.Label();
            this.btnLaunch         = new System.Windows.Forms.Button();
            this.btnRefresh        = new System.Windows.Forms.Button();
            this.btnOpenKeys       = new System.Windows.Forms.Button();
            this.lstGames          = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            this.lblKeysStatus.Location  = new System.Drawing.Point(16, 16);
            this.lblKeysStatus.Size      = new System.Drawing.Size(400, 22);
            this.lblFirmware.Location    = new System.Drawing.Point(16, 44);
            this.lblFirmware.Size        = new System.Drawing.Size(400, 22);
            this.lstGames.Location       = new System.Drawing.Point(16, 76);
            this.lstGames.Size           = new System.Drawing.Size(540, 160);
            this.lblStatus.Location      = new System.Drawing.Point(16, 248);
            this.lblStatus.Size          = new System.Drawing.Size(540, 40);
            this.btnLaunch.Text          = "Launch Ryujinx";
            this.btnLaunch.Location      = new System.Drawing.Point(16, 296);
            this.btnLaunch.Size          = new System.Drawing.Size(140, 34);
            this.btnLaunch.Click        += new System.EventHandler(this.btnLaunch_Click);
            this.btnRefresh.Text         = "Refresh";
            this.btnRefresh.Location     = new System.Drawing.Point(170, 296);
            this.btnRefresh.Size         = new System.Drawing.Size(90, 34);
            this.btnRefresh.Click       += new System.EventHandler(this.btnRefresh_Click);
            this.btnOpenKeys.Text        = "Open Keys Folder";
            this.btnOpenKeys.Location    = new System.Drawing.Point(274, 296);
            this.btnOpenKeys.Size        = new System.Drawing.Size(140, 34);
            this.btnOpenKeys.Click      += new System.EventHandler(this.btnOpenKeys_Click);

            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblKeysStatus, this.lblFirmware, this.lstGames,
                this.lblStatus, this.btnLaunch, this.btnRefresh, this.btnOpenKeys });

            this.Text          = "Ryujinx Canary Launcher 1.1.1403";
            this.ClientSize    = new System.Drawing.Size(572, 350);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label   lblKeysStatus, lblFirmware, lblStatus;
        private System.Windows.Forms.ListBox lstGames;
        private System.Windows.Forms.Button  btnLaunch, btnRefresh, btnOpenKeys;
    }
}