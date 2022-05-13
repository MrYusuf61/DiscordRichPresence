using DiscordRPC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRP
{
    public partial class FrmSelectTime : Form
    {
        public FrmSelectTime()
        {
            InitializeComponent();
        }
        private void FrmSelectTime_Load(object sender, EventArgs e)
        {
            var tempTime = DateTime.Now;
            numStartHours.Value = tempTime.Hour;
            numStartMin.Value = tempTime.Minute;
            numStartSec.Value = tempTime.Second;
            tempTime = tempTime.AddHours(1).AddMinutes(1).AddSeconds(1);
            numEndHours.Value = tempTime.Hour;
            numEndMin.Value = tempTime.Minute;
            numEndSec.Value = tempTime.Second;


            chkStart.Checked = XML.settings.StartTime.HasValue;
            chkEnd.Checked = XML.settings.EndTime.HasValue;
            chkAuto.Checked = XML.settings.AutoTime;
            if (XML.settings.StartTime.HasValue)
            {
                var tempTimeSpan = new TimeSpan(XML.settings.StartTime.Value);
                numStartHours.Value = tempTimeSpan.Hours;
                numStartMin.Value = tempTimeSpan.Minutes;
                numStartSec.Value = tempTimeSpan.Seconds;
            }
            if (XML.settings.EndTime.HasValue)
            {
                var tempTimeSpan = new TimeSpan(XML.settings.EndTime.Value);
                numEndHours.Value = tempTimeSpan.Hours;
                numEndMin.Value = tempTimeSpan.Minutes;
                numEndSec.Value = tempTimeSpan.Seconds;
            }
        }

        public static new Timestamps Show()
        {
            return new FrmSelectTime().ShowDialog();
        }

        public new Timestamps ShowDialog()
        {
            base.ShowDialog();
            if (this.Tag != (object)"ok") return null;
            else if (chkAuto.Checked) return new Timestamps()
            {
                Start = DateTime.MinValue
            };
            else return new Timestamps()
            {
                End = (chkEnd.Checked ? DateTime.Today.Add(new TimeSpan((int)numEndHours.Value, (int)numEndMin.Value, (int)numEndSec.Value)).ToUniversalTime() : (DateTime?)null),
                Start = (chkStart.Checked ? DateTime.Today.Add(new TimeSpan((int)numStartHours.Value, (int)numStartMin.Value, (int)numStartSec.Value)).ToUniversalTime() : (DateTime?)null)
            };
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Tag = "ok";
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmSelectTime_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Tag != (object)"ok") this.Tag = "cancel";
        }

        private void chkStart_CheckedChanged(object sender, EventArgs e)
        {
            numStartHours.Enabled = numStartMin.Enabled = numStartSec.Enabled = chkStart.Checked;
        }

        private void chkEnd_CheckedChanged(object sender, EventArgs e)
        {
            numEndHours.Enabled = numEndMin.Enabled = numEndSec.Enabled = chkEnd.Checked;
        }

        private void chkAuto_CheckedChanged(object sender, EventArgs e)
        {
            chkEnd.Checked = chkStart.Checked = !chkAuto.Checked;
        }
    }
}
