
namespace DRP
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuIco = new System.Windows.Forms.NotifyIcon(this.components);
            this.menuIcoContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuIcoItemStartStop = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuIcoItemShow = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuIcoItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblClientId = new System.Windows.Forms.Label();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.listPresences = new System.Windows.Forms.ListBox();
            this.groupBoxPresences = new System.Windows.Forms.GroupBox();
            this.chkBoxChangingPresences = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.infoLabel1 = new DRP.InfoLabel();
            this.menuIcoContext.SuspendLayout();
            this.groupBoxPresences.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuIco
            // 
            this.menuIco.BalloonTipText = "Custom DRP";
            this.menuIco.ContextMenuStrip = this.menuIcoContext;
            this.menuIco.Icon = ((System.Drawing.Icon)(resources.GetObject("menuIco.Icon")));
            this.menuIco.Text = "Custom DRP";
            // 
            // menuIcoContext
            // 
            this.menuIcoContext.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.menuIcoContext.BackColor = System.Drawing.SystemColors.Control;
            this.menuIcoContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuIcoItemStartStop,
            this.MenuIcoItemShow,
            this.MenuIcoItemExit});
            this.menuIcoContext.Name = "menuIcoContext";
            this.menuIcoContext.Size = new System.Drawing.Size(142, 70);
            this.menuIcoContext.Opening += new System.ComponentModel.CancelEventHandler(this.menuIcoContext_Opening);
            // 
            // MenuIcoItemStartStop
            // 
            this.MenuIcoItemStartStop.ForeColor = System.Drawing.Color.Black;
            this.MenuIcoItemStartStop.Image = ((System.Drawing.Image)(resources.GetObject("MenuIcoItemStartStop.Image")));
            this.MenuIcoItemStartStop.Name = "MenuIcoItemStartStop";
            this.MenuIcoItemStartStop.Size = new System.Drawing.Size(141, 22);
            this.MenuIcoItemStartStop.Text = "Custom DRP";
            this.MenuIcoItemStartStop.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // MenuIcoItemShow
            // 
            this.MenuIcoItemShow.ForeColor = System.Drawing.Color.Black;
            this.MenuIcoItemShow.Name = "MenuIcoItemShow";
            this.MenuIcoItemShow.Size = new System.Drawing.Size(141, 22);
            this.MenuIcoItemShow.Text = "Show";
            this.MenuIcoItemShow.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // MenuIcoItemExit
            // 
            this.MenuIcoItemExit.ForeColor = System.Drawing.Color.Black;
            this.MenuIcoItemExit.Name = "MenuIcoItemExit";
            this.MenuIcoItemExit.Size = new System.Drawing.Size(141, 22);
            this.MenuIcoItemExit.Text = "E&xit";
            this.MenuIcoItemExit.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Location = new System.Drawing.Point(30, 26);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(53, 13);
            this.lblClientId.TabIndex = 1;
            this.lblClientId.Text = "Client ID :";
            // 
            // txtClientId
            // 
            this.txtClientId.Location = new System.Drawing.Point(89, 23);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(162, 20);
            this.txtClientId.TabIndex = 3;
            this.txtClientId.TextChanged += new System.EventHandler(this.txtClientId_TextChanged);
            // 
            // listPresences
            // 
            this.listPresences.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listPresences.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listPresences.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listPresences.FormattingEnabled = true;
            this.listPresences.Location = new System.Drawing.Point(6, 20);
            this.listPresences.Name = "listPresences";
            this.listPresences.Size = new System.Drawing.Size(227, 210);
            this.listPresences.TabIndex = 4;
            this.listPresences.SelectedIndexChanged += new System.EventHandler(this.listPresences_SelectedIndexChanged);
            // 
            // groupBoxPresences
            // 
            this.groupBoxPresences.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBoxPresences.Controls.Add(this.listPresences);
            this.groupBoxPresences.Location = new System.Drawing.Point(12, 69);
            this.groupBoxPresences.Name = "groupBoxPresences";
            this.groupBoxPresences.Size = new System.Drawing.Size(239, 245);
            this.groupBoxPresences.TabIndex = 5;
            this.groupBoxPresences.TabStop = false;
            this.groupBoxPresences.Text = "Presences";
            // 
            // chkBoxChangingPresences
            // 
            this.chkBoxChangingPresences.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkBoxChangingPresences.AutoSize = true;
            this.chkBoxChangingPresences.Location = new System.Drawing.Point(18, 322);
            this.chkBoxChangingPresences.Name = "chkBoxChangingPresences";
            this.chkBoxChangingPresences.Size = new System.Drawing.Size(124, 17);
            this.chkBoxChangingPresences.TabIndex = 6;
            this.chkBoxChangingPresences.Text = "Changing Presences";
            this.chkBoxChangingPresences.UseVisualStyleBackColor = true;
            this.chkBoxChangingPresences.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Location = new System.Drawing.Point(258, 219);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemove.Location = new System.Drawing.Point(258, 248);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEdit.Location = new System.Drawing.Point(258, 277);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(258, 22);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(75, 23);
            this.btnStartStop.TabIndex = 10;
            this.btnStartStop.Tag = "";
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // infoLabel1
            // 
            this.infoLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoLabel1.Location = new System.Drawing.Point(7, 23);
            this.infoLabel1.Name = "infoLabel1";
            this.infoLabel1.Size = new System.Drawing.Size(20, 20);
            this.infoLabel1.TabIndex = 11;
            this.infoLabel1.Click += new System.EventHandler(this.infoLabel1_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 351);
            this.Controls.Add(this.infoLabel1);
            this.Controls.Add(this.btnStartStop);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chkBoxChangingPresences);
            this.Controls.Add(this.groupBoxPresences);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.lblClientId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(360, 700);
            this.MinimumSize = new System.Drawing.Size(360, 390);
            this.Name = "FrmMain";
            this.Text = "Custom Discord Rich Presence";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FrmMain_Paint);
            this.menuIcoContext.ResumeLayout(false);
            this.groupBoxPresences.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon menuIco;
        private System.Windows.Forms.ContextMenuStrip menuIcoContext;
        private System.Windows.Forms.ToolStripMenuItem MenuIcoItemExit;
        private System.Windows.Forms.ToolStripMenuItem MenuIcoItemStartStop;
        private System.Windows.Forms.ToolStripMenuItem MenuIcoItemShow;
        private System.Windows.Forms.Label lblClientId;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.ListBox listPresences;
        private System.Windows.Forms.GroupBox groupBoxPresences;
        private System.Windows.Forms.CheckBox chkBoxChangingPresences;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnStartStop;
        private InfoLabel infoLabel1;
    }
}