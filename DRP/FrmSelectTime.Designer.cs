namespace DRP
{
    partial class FrmSelectTime
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelectTime));
            this.numStartHours = new System.Windows.Forms.NumericUpDown();
            this.numStartMin = new System.Windows.Forms.NumericUpDown();
            this.numStartSec = new System.Windows.Forms.NumericUpDown();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.numEndSec = new System.Windows.Forms.NumericUpDown();
            this.numEndMin = new System.Windows.Forms.NumericUpDown();
            this.numEndHours = new System.Windows.Forms.NumericUpDown();
            this.chkStart = new System.Windows.Forms.CheckBox();
            this.chkEnd = new System.Windows.Forms.CheckBox();
            this.chkAuto = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numStartHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndSec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndHours)).BeginInit();
            this.SuspendLayout();
            // 
            // numStartHours
            // 
            this.numStartHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numStartHours.Location = new System.Drawing.Point(14, 35);
            this.numStartHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numStartHours.Name = "numStartHours";
            this.numStartHours.Size = new System.Drawing.Size(52, 38);
            this.numStartHours.TabIndex = 0;
            this.numStartHours.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numStartMin
            // 
            this.numStartMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numStartMin.Location = new System.Drawing.Point(72, 35);
            this.numStartMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numStartMin.Name = "numStartMin";
            this.numStartMin.Size = new System.Drawing.Size(52, 38);
            this.numStartMin.TabIndex = 1;
            this.numStartMin.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numStartSec
            // 
            this.numStartSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numStartSec.Location = new System.Drawing.Point(130, 35);
            this.numStartSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numStartSec.Name = "numStartSec";
            this.numStartSec.Size = new System.Drawing.Size(52, 38);
            this.numStartSec.TabIndex = 2;
            this.numStartSec.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(107, 199);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(26, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // numEndSec
            // 
            this.numEndSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numEndSec.Location = new System.Drawing.Point(130, 122);
            this.numEndSec.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numEndSec.Name = "numEndSec";
            this.numEndSec.Size = new System.Drawing.Size(52, 38);
            this.numEndSec.TabIndex = 7;
            this.numEndSec.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numEndMin
            // 
            this.numEndMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numEndMin.Location = new System.Drawing.Point(72, 122);
            this.numEndMin.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numEndMin.Name = "numEndMin";
            this.numEndMin.Size = new System.Drawing.Size(52, 38);
            this.numEndMin.TabIndex = 6;
            this.numEndMin.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numEndHours
            // 
            this.numEndHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numEndHours.Location = new System.Drawing.Point(14, 122);
            this.numEndHours.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numEndHours.Name = "numEndHours";
            this.numEndHours.Size = new System.Drawing.Size(52, 38);
            this.numEndHours.TabIndex = 5;
            this.numEndHours.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // chkStart
            // 
            this.chkStart.AutoSize = true;
            this.chkStart.Checked = true;
            this.chkStart.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkStart.Location = new System.Drawing.Point(14, 12);
            this.chkStart.Name = "chkStart";
            this.chkStart.Size = new System.Drawing.Size(74, 17);
            this.chkStart.TabIndex = 8;
            this.chkStart.Text = "Start Time";
            this.chkStart.UseVisualStyleBackColor = true;
            this.chkStart.CheckedChanged += new System.EventHandler(this.chkStart_CheckedChanged);
            // 
            // chkEnd
            // 
            this.chkEnd.AutoSize = true;
            this.chkEnd.Checked = true;
            this.chkEnd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnd.Location = new System.Drawing.Point(14, 99);
            this.chkEnd.Name = "chkEnd";
            this.chkEnd.Size = new System.Drawing.Size(71, 17);
            this.chkEnd.TabIndex = 9;
            this.chkEnd.Text = "End Time";
            this.chkEnd.UseVisualStyleBackColor = true;
            this.chkEnd.CheckedChanged += new System.EventHandler(this.chkEnd_CheckedChanged);
            // 
            // chkAuto
            // 
            this.chkAuto.AutoSize = true;
            this.chkAuto.Location = new System.Drawing.Point(134, 176);
            this.chkAuto.Name = "chkAuto";
            this.chkAuto.Size = new System.Drawing.Size(48, 17);
            this.chkAuto.TabIndex = 10;
            this.chkAuto.Text = "Auto";
            this.chkAuto.UseVisualStyleBackColor = true;
            this.chkAuto.CheckedChanged += new System.EventHandler(this.chkAuto_CheckedChanged);
            // 
            // FrmSelectTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 231);
            this.Controls.Add(this.chkAuto);
            this.Controls.Add(this.chkEnd);
            this.Controls.Add(this.chkStart);
            this.Controls.Add(this.numEndSec);
            this.Controls.Add(this.numEndMin);
            this.Controls.Add(this.numEndHours);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.numStartSec);
            this.Controls.Add(this.numStartMin);
            this.Controls.Add(this.numStartHours);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSelectTime";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Time";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSelectTime_FormClosing);
            this.Load += new System.EventHandler(this.FrmSelectTime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numStartHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStartSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndSec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEndHours)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numStartHours;
        private System.Windows.Forms.NumericUpDown numStartMin;
        private System.Windows.Forms.NumericUpDown numStartSec;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.NumericUpDown numEndSec;
        private System.Windows.Forms.NumericUpDown numEndMin;
        private System.Windows.Forms.NumericUpDown numEndHours;
        private System.Windows.Forms.CheckBox chkStart;
        private System.Windows.Forms.CheckBox chkEnd;
        private System.Windows.Forms.CheckBox chkAuto;
    }
}