using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace DisableGameDVR
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            updateDVRCheckBox();
            updateBarCheckBox();
        }

        private void toggleDVRCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            setGameDVREnabled(toggleDVRCheckbox.Checked);
            updateDVRCheckBox();            
        }

        private void toggleBarCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            setGameBarEnabled(toggleBarCheckbox.Checked);
            updateBarCheckBox();
        }

        private void setGameDVREnabled(bool enabled)
        {
            using (RegistryKey dvrKey = Registry.CurrentUser.OpenSubKey("System\\GameConfigStore", true))
            {
                dvrKey.SetValue("GameDVR_Enabled", enabled ? 1 : 0, RegistryValueKind.DWord);
            }

            using (RegistryKey dvrKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Policies\\Microsoft\\Windows", true))
            {
                if (dvrKey == null)
                    return;

                dvrKey.SetValue("AllowGameDVR", enabled ? 1 : 0, RegistryValueKind.DWord);
            }
        }

        private void setGameBarEnabled(bool enabled)
        {
            using (RegistryKey dvrKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\GameDVR", true))
            {
                if (dvrKey != null)
                {
                    dvrKey.SetValue("AppCaptureEnabled", enabled ? 1 : 0, RegistryValueKind.DWord);
                }                
            }           
        }

        private void updateDVRCheckBox()
        {
            using (RegistryKey dvrKey = Registry.CurrentUser.OpenSubKey("System\\GameConfigStore"))
            {
                if (dvrKey == null)
                {
                    toggleDVRCheckbox.Enabled = false;
                    gameDVRPictureBox.Enabled = false;
                    return;
                }
            }

            toggleDVRCheckbox.CheckedChanged -= toggleDVRCheckbox_CheckedChanged;
            using (RegistryKey dvrKey = Registry.CurrentUser.OpenSubKey("System\\GameConfigStore"))
            {
                bool dvrEnabled = dvrKey.GetValueNames().Contains("GameDVR_Enabled") ?
                    dvrKey.GetValue("GameDVR_Enabled").ToString() == "1" : true;
                toggleDVRCheckbox.Checked = dvrEnabled;
            }
            toggleDVRCheckbox.CheckedChanged += toggleDVRCheckbox_CheckedChanged;
        }      
        
        private void updateBarCheckBox()
        {
            using (RegistryKey barKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\GameDVR"))
            {
                if (barKey == null)
                {
                    toggleBarCheckbox.Enabled = false;
                    gameBarPictureBox.Enabled = false;
                    return;
                }
            }

            toggleBarCheckbox.CheckedChanged -= toggleBarCheckbox_CheckedChanged;
            using (RegistryKey barKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\GameDVR", true))
            {
                bool barEnabled = barKey.GetValueNames().Contains("AppCaptureEnabled") ?
                    barKey.GetValue("AppCaptureEnabled").ToString() == "1" : true;
                toggleBarCheckbox.Checked = barEnabled;
            }
            toggleBarCheckbox.CheckedChanged += toggleBarCheckbox_CheckedChanged;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/vasinnet");
        }
    }
}
