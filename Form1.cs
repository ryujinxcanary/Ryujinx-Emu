using System;
using System.IO;
using System.Windows.Forms;

namespace RyujinxLauncher
{
    public partial class MainForm : Form
    {
        private readonly GameLibrary _library = new();

        public MainForm()
        {
            InitializeComponent();
            RefreshStatus();
        }

        private void RefreshStatus()
        {
            lblKeysStatus.Text      = KeysHelper.GetStatusMessage();
            lblKeysStatus.ForeColor = KeysHelper.ValidateProdKeys()
                ? System.Drawing.Color.LimeGreen
                : System.Drawing.Color.OrangeRed;

            lblFirmware.Text      = FirmwareInstaller.GetStatusMessage();
            lblFirmware.ForeColor = FirmwareInstaller.FirmwareInstalled()
                ? System.Drawing.Color.LimeGreen
                : System.Drawing.Color.OrangeRed;

            lstGames.Items.Clear();
            foreach (var g in _library.Scan())
                lstGames.Items.Add($"{g.Name}  [{g.Extension}]  {g.SizeBytes / 1048576} MB");

            lblStatus.Text = KeysHelper.GetSetupInstructions();
        }

        private void btnLaunch_Click(object sender, EventArgs e)
        {
            var exe = Path.Combine(Application.StartupPath, "publish", "Ryujinx.exe");
            if (!File.Exists(exe)) { MessageBox.Show("Ryujinx.exe not found. Extract the full archive."); return; }
            System.Diagnostics.Process.Start(exe);
        }

        private void btnRefresh_Click(object sender, EventArgs e) => RefreshStatus();

        private void btnOpenKeys_Click(object sender, EventArgs e)
        {
            KeysHelper.EnsureKeysDirExists();
            System.Diagnostics.Process.Start("explorer.exe", Path.GetDirectoryName(KeysHelper.ProdKeysPath));
        }
    }
}