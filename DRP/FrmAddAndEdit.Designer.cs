
namespace DRP
{
    partial class FrmAddAndEdit
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
            this.lblDetails = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtLargeImageKey = new System.Windows.Forms.TextBox();
            this.lblLargeImageKey = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.infoLabel1 = new DRP.InfoLabel();
            this.txtLargeImageText = new System.Windows.Forms.TextBox();
            this.lblLargeImageText = new System.Windows.Forms.Label();
            this.infoLabel2 = new DRP.InfoLabel();
            this.txtSmallImageKey = new System.Windows.Forms.TextBox();
            this.lblSmallImageKey = new System.Windows.Forms.Label();
            this.txtSmallImageText = new System.Windows.Forms.TextBox();
            this.lblSmallImageText = new System.Windows.Forms.Label();
            this.lblTimeout = new System.Windows.Forms.Label();
            this.txtTimeout = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDetails
            // 
            this.lblDetails.Location = new System.Drawing.Point(13, 40);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(122, 14);
            this.lblDetails.TabIndex = 0;
            this.lblDetails.Text = "Details :";
            this.lblDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(137, 38);
            this.txtDetails.MaxLength = 127;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(208, 20);
            this.txtDetails.TabIndex = 1;
            this.txtDetails.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(137, 64);
            this.txtState.MaxLength = 127;
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(208, 20);
            this.txtState.TabIndex = 3;
            this.txtState.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblState
            // 
            this.lblState.Location = new System.Drawing.Point(13, 66);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(122, 14);
            this.lblState.TabIndex = 2;
            this.lblState.Text = "State :";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLargeImageKey
            // 
            this.txtLargeImageKey.Location = new System.Drawing.Point(137, 125);
            this.txtLargeImageKey.MaxLength = 32;
            this.txtLargeImageKey.Name = "txtLargeImageKey";
            this.txtLargeImageKey.Size = new System.Drawing.Size(208, 20);
            this.txtLargeImageKey.TabIndex = 5;
            this.txtLargeImageKey.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblLargeImageKey
            // 
            this.lblLargeImageKey.Location = new System.Drawing.Point(38, 127);
            this.lblLargeImageKey.Name = "lblLargeImageKey";
            this.lblLargeImageKey.Size = new System.Drawing.Size(97, 14);
            this.lblLargeImageKey.TabIndex = 4;
            this.lblLargeImageKey.Text = "Large Image Key :";
            this.lblLargeImageKey.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(103, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Assets";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(137, 12);
            this.txtName.MaxLength = 300;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 20);
            this.txtName.TabIndex = 8;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(13, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(122, 14);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name :";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // infoLabel1
            // 
            this.infoLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoLabel1.Location = new System.Drawing.Point(12, 125);
            this.infoLabel1.Name = "infoLabel1";
            this.infoLabel1.Size = new System.Drawing.Size(20, 20);
            this.infoLabel1.TabIndex = 9;
            this.infoLabel1.Text = "infoLabel1";
            this.infoLabel1.Click += new System.EventHandler(this.infoLabel1_Click);
            // 
            // txtLargeImageText
            // 
            this.txtLargeImageText.Location = new System.Drawing.Point(137, 151);
            this.txtLargeImageText.MaxLength = 127;
            this.txtLargeImageText.Name = "txtLargeImageText";
            this.txtLargeImageText.Size = new System.Drawing.Size(208, 20);
            this.txtLargeImageText.TabIndex = 11;
            this.txtLargeImageText.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblLargeImageText
            // 
            this.lblLargeImageText.Location = new System.Drawing.Point(38, 153);
            this.lblLargeImageText.Name = "lblLargeImageText";
            this.lblLargeImageText.Size = new System.Drawing.Size(97, 14);
            this.lblLargeImageText.TabIndex = 10;
            this.lblLargeImageText.Text = "Large Image Text :";
            this.lblLargeImageText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // infoLabel2
            // 
            this.infoLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoLabel2.Location = new System.Drawing.Point(12, 177);
            this.infoLabel2.Name = "infoLabel2";
            this.infoLabel2.Size = new System.Drawing.Size(20, 20);
            this.infoLabel2.TabIndex = 14;
            this.infoLabel2.Text = "infoLabel2";
            this.infoLabel2.Click += new System.EventHandler(this.infoLabel2_Click);
            // 
            // txtSmallImageKey
            // 
            this.txtSmallImageKey.Location = new System.Drawing.Point(137, 177);
            this.txtSmallImageKey.MaxLength = 32;
            this.txtSmallImageKey.Name = "txtSmallImageKey";
            this.txtSmallImageKey.Size = new System.Drawing.Size(208, 20);
            this.txtSmallImageKey.TabIndex = 13;
            this.txtSmallImageKey.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblSmallImageKey
            // 
            this.lblSmallImageKey.Location = new System.Drawing.Point(38, 179);
            this.lblSmallImageKey.Name = "lblSmallImageKey";
            this.lblSmallImageKey.Size = new System.Drawing.Size(97, 14);
            this.lblSmallImageKey.TabIndex = 12;
            this.lblSmallImageKey.Text = "Small Image Key :";
            this.lblSmallImageKey.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSmallImageText
            // 
            this.txtSmallImageText.Location = new System.Drawing.Point(137, 203);
            this.txtSmallImageText.MaxLength = 127;
            this.txtSmallImageText.Name = "txtSmallImageText";
            this.txtSmallImageText.Size = new System.Drawing.Size(208, 20);
            this.txtSmallImageText.TabIndex = 16;
            this.txtSmallImageText.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblSmallImageText
            // 
            this.lblSmallImageText.Location = new System.Drawing.Point(38, 205);
            this.lblSmallImageText.Name = "lblSmallImageText";
            this.lblSmallImageText.Size = new System.Drawing.Size(97, 14);
            this.lblSmallImageText.TabIndex = 15;
            this.lblSmallImageText.Text = "Small Image Text :";
            this.lblSmallImageText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTimeout
            // 
            this.lblTimeout.Location = new System.Drawing.Point(13, 255);
            this.lblTimeout.Name = "lblTimeout";
            this.lblTimeout.Size = new System.Drawing.Size(122, 14);
            this.lblTimeout.TabIndex = 17;
            this.lblTimeout.Text = "(Seconds) Timeout :";
            this.lblTimeout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTimeout
            // 
            this.txtTimeout.Location = new System.Drawing.Point(137, 254);
            this.txtTimeout.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.txtTimeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.Size = new System.Drawing.Size(208, 20);
            this.txtTimeout.TabIndex = 19;
            this.txtTimeout.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTimeout.ValueChanged += new System.EventHandler(this.txtTimeout_ValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(259, 311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 28);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(167, 311);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 28);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmAddAndEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 351);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTimeout);
            this.Controls.Add(this.lblTimeout);
            this.Controls.Add(this.txtSmallImageText);
            this.Controls.Add(this.lblSmallImageText);
            this.Controls.Add(this.infoLabel2);
            this.Controls.Add(this.txtSmallImageKey);
            this.Controls.Add(this.lblSmallImageKey);
            this.Controls.Add(this.txtLargeImageText);
            this.Controls.Add(this.lblLargeImageText);
            this.Controls.Add(this.infoLabel1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLargeImageKey);
            this.Controls.Add(this.lblLargeImageKey);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.lblDetails);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(370, 390);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(370, 390);
            this.Name = "FrmAddAndEdit";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAddAndEdit_FormClosing);
            this.Load += new System.EventHandler(this.FrmAddAndEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTimeout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtLargeImageKey;
        private System.Windows.Forms.Label lblLargeImageKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private InfoLabel infoLabel1;
        private System.Windows.Forms.TextBox txtLargeImageText;
        private System.Windows.Forms.Label lblLargeImageText;
        private InfoLabel infoLabel2;
        private System.Windows.Forms.TextBox txtSmallImageKey;
        private System.Windows.Forms.Label lblSmallImageKey;
        private System.Windows.Forms.TextBox txtSmallImageText;
        private System.Windows.Forms.Label lblSmallImageText;
        private System.Windows.Forms.Label lblTimeout;
        private System.Windows.Forms.NumericUpDown txtTimeout;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}