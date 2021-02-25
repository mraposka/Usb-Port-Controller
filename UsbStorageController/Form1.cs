using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace UsbStorageController
{
    public partial class UsbStorageController : Form
    {
        public UsbStorageController()
        {
            InitializeComponent();
        }

        private readonly NotifyIcon notify_Icon = new NotifyIcon();//Notify Icon Object
        //Events  
        private void UsbStorageController_Load(object sender, EventArgs e)
        {
            notify_Icon.ContextMenuStrip = menu;
            notify_Icon.Icon = Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location);
            disable.Enabled = true;
            disableAll.Enabled = true;
            enable.Enabled = true;
            NotifyIcon();
        }
        private void Enable_Click(object sender, EventArgs e)
        {
            EnableFunction();
        } 
        private void Disable_Click(object sender, EventArgs e)
        {
            DisableFunction();
        } 
        private void Exit_Click(object sender, EventArgs e)
        {
            notify_Icon.Dispose();
            Application.Exit();
        } 
        private void DisableAll_Click(object sender, EventArgs e)
        {
            DisableAllFunction();
        } 
        private void Restart_Click(object sender, EventArgs e)
        {
            RestartFunction();
        }
        private void Notify_Icon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            enable.Enabled = true;
            enableCooldown.Stop();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        } 
        private void HideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        } 
        private void EnableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableFunction();
        } 
        private void DisableUSBStorageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisableFunction();
        } 
        private void DisableAllUSBPortsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisableAllFunction();
        }
        private void Restartin5sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestartFunction();
        } 
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notify_Icon.Dispose();
            Application.Exit();
        }
        //Events 

        //Functions
        private void NotifyIcon()
        {
            this.Hide();
            notify_Icon.Visible = true;
            notify_Icon.Text = "USB Storage Controller";
            notify_Icon.BalloonTipTitle = "USB Storage Controller";
            notify_Icon.BalloonTipText = "USB Storage Controller is running now!"; 
            notify_Icon.BalloonTipIcon = ToolTipIcon.Info;
            notify_Icon.ShowBalloonTip(1000);

            notify_Icon.MouseDoubleClick += new MouseEventHandler(Notify_Icon_MouseDoubleClick);
        }
        private void RunAsAdminOnCMD(string command)
        {
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                WindowStyle = ProcessWindowStyle.Hidden,
                FileName = "cmd.exe",
                Arguments = "/C " + command,
                Verb = "runas", 
            };
            process.StartInfo = startInfo;
            process.Start();
        }
        private void EnableFunction()
        {
            try
            {
                Microsoft.Win32.Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\USBSTOR", "Start", 3, Microsoft.Win32.RegistryValueKind.DWord);
                RunAsAdminOnCMD("devcon64 enable usb\\*");
                RunAsAdminOnCMD("devcon64 rescan");
                disable.Enabled = true;
                disableAll.Enabled = true;
                enable.Enabled = false;
                enableCooldown.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Error Occured " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        private void DisableFunction()
        {
            try
            {
                RunAsAdminOnCMD("devcon64 remove usbstor\\*");
                disable.Enabled = false;
                disableAll.Enabled = false;
                enable.Enabled = true;
                enableCooldown.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Error Occured " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DisableAllFunction()
        {
            try
            {
                RunAsAdminOnCMD("devcon64 remove usb\\* ");
                disable.Enabled = true;
                disableAll.Enabled = true;
                enable.Enabled = false;
                enableCooldown.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Error Occured " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RestartFunction()
        {
            try
            {
                Process.Start("shutdown -r -f -t 5");
                disable.Enabled = false;
                disableAll.Enabled = false;
                enable.Enabled = false;
                enableCooldown.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(null, "Error Occured " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Functions
    }
}
