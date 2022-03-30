using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DRP.Properties.Settings;

namespace DRP
{
    public partial class FrmAddAndEdit : Form
    {
        private bool isNew = false;
        private SettingItem currentItem;

        private const string StaringError = "StartinngError";
        private const string ExitOk = "OK";
        public FrmAddAndEdit(string Name = null)
        {
            InitializeComponent();
            isNew = string.IsNullOrEmpty(Name);
            if (!isNew) currentItem = XML.GetItem(Name).settingItem;
            else currentItem = new SettingItem();

            if (currentItem == null)
            {
                MessageBox.Show("\"Rich Presence\" not found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Tag = StaringError;
            }
        }

        private void FrmAddAndEdit_Load(object sender, EventArgs e)
        {
            if (this.Tag == (object)StaringError) this.Close();
            else
            {
                txtName.Enabled = isNew;
                txtName.Text = currentItem.Name;
                txtDetails.Text = currentItem.Details;
                txtState.Text = currentItem.State;
                txtLargeImageKey.Text = currentItem.AssetLargeImageKey;
                txtLargeImageText.Text = currentItem.AssetLargeImageText;
                txtSmallImageKey.Text = currentItem.AssetSmallImageKey;
                txtSmallImageText.Text = currentItem.AssetSmallImageText;
                txtTimeout.Value = currentItem.Timeout / 1000;
                this.Tag = ExitOk;
            }
        }

        private void FrmAddAndEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Tag == (object)StaringError) e.Cancel = false;
            else if (this.Tag == (object)ExitOk) e.Cancel = false;
            else
            {
                var res = MessageBox.Show("Are you sure you want to exit without saving ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes) e.Cancel = false;
                else e.Cancel = true;
            }
        }

        private void infoLabel1_Click(object sender, EventArgs e)
        {
            GoToAssets();
        }


        private void GoToAssets()
        {
            Process.Start($"https://discord.com/developers/applications/{Default.ClientID}/rich-presence/assets");
        }

        private void infoLabel2_Click(object sender, EventArgs e)
        {
            GoToAssets();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isNew)
            {
                XML.Update(currentItem);
                this.Tag = ExitOk;
            }
            else
            {
                if (string.IsNullOrEmpty(txtName.Text))
                    MessageBox.Show("You have to specify a name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (!XML.Add(currentItem))
                    MessageBox.Show($"There is a \"Presence\" named \"{txtName.Text}\"", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else this.Tag = ExitOk;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                if (txt.Name == txtName.Name)
                {
                    currentItem.Name = txt.Text;
                }
                else if (txt.Name == txtDetails.Name)
                {
                    currentItem.Details = txt.Text;
                }
                else if (txt.Name == txtState.Name)
                {
                    currentItem.State = txt.Text;
                }
                else if (txt.Name == txtLargeImageKey.Name)
                {
                    currentItem.AssetLargeImageKey = txt.Text;
                }
                else if (txt.Name == txtLargeImageText.Name)
                {
                    currentItem.AssetLargeImageText = txt.Text;
                }
                else if (txt.Name == txtSmallImageKey.Name)
                {
                    currentItem.AssetSmallImageKey = txt.Text;
                }
                else if (txt.Name == txtSmallImageText.Name)
                {
                    currentItem.AssetSmallImageText = txt.Text;
                }
                this.Tag = null;
            }
        }

        private void txtTimeout_ValueChanged(object sender, EventArgs e)
        {
            if (txtTimeout.Value > 0 && txtTimeout.Value < 1001)
                currentItem.Timeout = (int)txtTimeout.Value * 1000;
            this.Tag = null;
        }
    }
}
