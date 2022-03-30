using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRPC;
using static DRP.Properties.Settings;

namespace DRP
{
    public partial class FrmMain : Form
    {
        private bool firstShow = true;
        public FrmMain(bool show = true)
        {
            firstShow = show;
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void refreshList()
        {
            listPresences.Items.Clear();
            listPresences.Items.AddRange(XML.GetNames());
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            chkBoxChangingPresences.Checked = Default.ChangingPresences;
            txtClientId.Text = Default.ClientID;
            refreshList();
            DiscordRPC_Controller.PresenceChanged += DiscordRPC_Controller_PresenceChanged;
            DiscordRPC_Controller.ActiveChanged += DiscordRPC_Controller_ActiveChanged;
            DiscordRPC_Controller.Start();
            
        }

        private void DiscordRPC_Controller_ActiveChanged(object sender, EventArgs e)
        {
            if (DiscordRPC_Controller.Active)
            {
                btnStartStop.Text = "Stop";
                // Warning: high RAM usage
                MenuIcoItemStartStop.Image.Dispose();
                MenuIcoItemStartStop.Image = Properties.Resources.active;
            }
            else
            {
                btnStartStop.Text = "Start";
                // Warning: high RAM usage
                MenuIcoItemStartStop.Image.Dispose();
                MenuIcoItemStartStop.Image = Properties.Resources.deactive;
            }
        }

        private void DiscordRPC_Controller_PresenceChanged(object sender, string e)
        {
            for (int i = 0; i < listPresences.Items.Count; i++)
            {
                if (listPresences.Items[i].ToString() == e)
                {
                    listPresences.SelectedIndex = i;
                    break;
                }
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Tag != (object)"Exit:True")
            {
                e.Cancel = true;
                this.Hide();
                menuIco.Visible = true;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            startStop();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Tag = "Exit:True";
            menuIco.Visible = false;
            this.Close();
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            menuIco.Visible = false;
            this.Show();
            this.Activate();
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.com/developers/applications");
        }


        private void menuIcoContext_Opening(object sender, CancelEventArgs e)
        {
            if (DiscordRPC_Controller.Active) MenuIcoItemStartStop.Image = Properties.Resources.active;
            else MenuIcoItemStartStop.Image = Properties.Resources.deactive;
        }

        private void txtClientId_TextChanged(object sender, EventArgs e)
        {
            if (txtClientId.Text.Length > 17)
            {
                Default.ClientID = txtClientId.Text;
                Default.Save();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            listPresences.Enabled = !chkBoxChangingPresences.Checked;
            Default.ChangingPresences = chkBoxChangingPresences.Checked;
            Default.Save();
        }

        private void listPresences_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listPresences.Enabled && listPresences.SelectedItem != null)
            {
                XML.SetChechked(listPresences.SelectedItem.ToString());
            }
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            startStop();
        }


        private void startStop()
        {
            if (DiscordRPC_Controller.Active)
            {
                DiscordRPC_Controller.Stop();
            }
            else
            {
                DiscordRPC_Controller.Start();
            }
        }

        private void infoLabel1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.com/developers/applications");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!DiscordRPC_Controller.IsID(Default.ClientID))
                MessageBox.Show("First you need to enter a Client ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                new FrmAddAndEdit().ShowDialog();
            refreshList();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (listPresences.SelectedIndex >= 0)
            {
                new FrmAddAndEdit(listPresences.SelectedItem.ToString()).ShowDialog();
                refreshList();
            }
            else MessageBox.Show("Select a \"Presence\"", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listPresences.SelectedIndex >= 0)
            {
                XML.Remove(listPresences.SelectedItem.ToString());
                refreshList();
            }
            else MessageBox.Show("Select a \"Presence\"", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmMain_Paint(object sender, PaintEventArgs e)
        {
            if (!firstShow)
            {
                this.Hide();
                this.Close();
                firstShow = true;
            }
        }
    }
}
