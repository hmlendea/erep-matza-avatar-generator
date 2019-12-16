namespace MatzaAvatarGenerator
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.customLabel1 = new MatzaAvatarGenerator.CustomLabel();
            this.lblVersion = new MatzaAvatarGenerator.CustomLabel();
            this.btnUpdate = new MatzaAvatarGenerator.CustomButton();
            this.grpAvatar = new MatzaAvatarGenerator.CustomGroupBox();
            this.cmbFootstep = new MatzaAvatarGenerator.CustomComboBox();
            this.lblFootstep = new MatzaAvatarGenerator.CustomLabel();
            this.cmbBorder = new MatzaAvatarGenerator.CustomComboBox();
            this.lblBorder = new MatzaAvatarGenerator.CustomLabel();
            this.lblFlag = new MatzaAvatarGenerator.CustomLabel();
            this.cmbFlag = new MatzaAvatarGenerator.CustomComboBox();
            this.lblPosition = new MatzaAvatarGenerator.CustomLabel();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.btnSave = new MatzaAvatarGenerator.CustomButton();
            this.btnGenerate = new MatzaAvatarGenerator.CustomButton();
            this.pbAvatar = new System.Windows.Forms.PictureBox();
            this.grpPhoto = new MatzaAvatarGenerator.CustomGroupBox();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.btnLoad = new MatzaAvatarGenerator.CustomButton();
            this.grpAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).BeginInit();
            this.grpPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.BackColor = System.Drawing.Color.Transparent;
            this.customLabel1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.customLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(4)))), ((int)(((byte)(50)))));
            this.customLabel1.Location = new System.Drawing.Point(398, 358);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.ShadowColor = System.Drawing.Color.Black;
            this.customLabel1.Size = new System.Drawing.Size(206, 22);
            this.customLabel1.TabIndex = 9;
            this.customLabel1.Text = "Made by Mlendea Horatiu";
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(4)))), ((int)(((byte)(50)))));
            this.lblVersion.Location = new System.Drawing.Point(194, 358);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.ShadowColor = System.Drawing.Color.Black;
            this.lblVersion.Size = new System.Drawing.Size(19, 22);
            this.lblVersion.TabIndex = 7;
            this.lblVersion.Text = "v";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.btnUpdate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(4)))), ((int)(((byte)(50)))));
            this.btnUpdate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(4)))), ((int)(((byte)(50)))));
            this.btnUpdate.Location = new System.Drawing.Point(12, 353);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ShadowColor = System.Drawing.Color.Black;
            this.btnUpdate.Size = new System.Drawing.Size(176, 32);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grpAvatar
            // 
            this.grpAvatar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpAvatar.BackColor = System.Drawing.Color.Transparent;
            this.grpAvatar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(4)))), ((int)(((byte)(50)))));
            this.grpAvatar.Controls.Add(this.cmbFootstep);
            this.grpAvatar.Controls.Add(this.lblFootstep);
            this.grpAvatar.Controls.Add(this.cmbBorder);
            this.grpAvatar.Controls.Add(this.lblBorder);
            this.grpAvatar.Controls.Add(this.lblFlag);
            this.grpAvatar.Controls.Add(this.cmbFlag);
            this.grpAvatar.Controls.Add(this.lblPosition);
            this.grpAvatar.Controls.Add(this.txtPosition);
            this.grpAvatar.Controls.Add(this.btnSave);
            this.grpAvatar.Controls.Add(this.btnGenerate);
            this.grpAvatar.Controls.Add(this.pbAvatar);
            this.grpAvatar.Enabled = false;
            this.grpAvatar.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpAvatar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.grpAvatar.Location = new System.Drawing.Point(207, 42);
            this.grpAvatar.Name = "grpAvatar";
            this.grpAvatar.ShadowColor = System.Drawing.Color.Black;
            this.grpAvatar.Size = new System.Drawing.Size(397, 297);
            this.grpAvatar.TabIndex = 1;
            this.grpAvatar.TabStop = false;
            this.grpAvatar.Text = "Avatar";
            this.grpAvatar.TextPosition = MatzaAvatarGenerator.CustomGroupBoxTextPosition.Center;
            // 
            // cmbFootstep
            // 
            this.cmbFootstep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.cmbFootstep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFootstep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFootstep.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbFootstep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(4)))), ((int)(((byte)(50)))));
            this.cmbFootstep.FormattingEnabled = true;
            this.cmbFootstep.Items.AddRange(new object[] {
            "Roz",
            "Albastra",
            "<Deloc>"});
            this.cmbFootstep.Location = new System.Drawing.Point(6, 213);
            this.cmbFootstep.Name = "cmbFootstep";
            this.cmbFootstep.ShadowColor = System.Drawing.Color.Black;
            this.cmbFootstep.Size = new System.Drawing.Size(191, 26);
            this.cmbFootstep.TabIndex = 12;
            // 
            // lblFootstep
            // 
            this.lblFootstep.BackColor = System.Drawing.Color.Transparent;
            this.lblFootstep.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFootstep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(4)))), ((int)(((byte)(50)))));
            this.lblFootstep.Location = new System.Drawing.Point(6, 189);
            this.lblFootstep.Name = "lblFootstep";
            this.lblFootstep.ShadowColor = System.Drawing.Color.Black;
            this.lblFootstep.Size = new System.Drawing.Size(191, 21);
            this.lblFootstep.TabIndex = 11;
            this.lblFootstep.Text = "Labuța";
            this.lblFootstep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBorder
            // 
            this.cmbBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.cmbBorder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBorder.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbBorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(4)))), ((int)(((byte)(50)))));
            this.cmbBorder.FormattingEnabled = true;
            this.cmbBorder.Items.AddRange(new object[] {
            "Albastru",
            "Roz",
            "<Deloc>"});
            this.cmbBorder.Location = new System.Drawing.Point(6, 160);
            this.cmbBorder.Name = "cmbBorder";
            this.cmbBorder.ShadowColor = System.Drawing.Color.Black;
            this.cmbBorder.Size = new System.Drawing.Size(191, 26);
            this.cmbBorder.TabIndex = 10;
            // 
            // lblBorder
            // 
            this.lblBorder.BackColor = System.Drawing.Color.Transparent;
            this.lblBorder.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblBorder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(4)))), ((int)(((byte)(50)))));
            this.lblBorder.Location = new System.Drawing.Point(6, 136);
            this.lblBorder.Name = "lblBorder";
            this.lblBorder.ShadowColor = System.Drawing.Color.Black;
            this.lblBorder.Size = new System.Drawing.Size(191, 21);
            this.lblBorder.TabIndex = 9;
            this.lblBorder.Text = "Chenar";
            this.lblBorder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFlag
            // 
            this.lblFlag.BackColor = System.Drawing.Color.Transparent;
            this.lblFlag.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFlag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(4)))), ((int)(((byte)(50)))));
            this.lblFlag.Location = new System.Drawing.Point(6, 83);
            this.lblFlag.Name = "lblFlag";
            this.lblFlag.ShadowColor = System.Drawing.Color.Black;
            this.lblFlag.Size = new System.Drawing.Size(191, 21);
            this.lblFlag.TabIndex = 8;
            this.lblFlag.Text = "Steag";
            this.lblFlag.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbFlag
            // 
            this.cmbFlag.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.cmbFlag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFlag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFlag.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold);
            this.cmbFlag.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(4)))), ((int)(((byte)(50)))));
            this.cmbFlag.FormattingEnabled = true;
            this.cmbFlag.Items.AddRange(new object[] {
            "Stanga",
            "Dreapta",
            "<Deloc>"});
            this.cmbFlag.Location = new System.Drawing.Point(6, 107);
            this.cmbFlag.Name = "cmbFlag";
            this.cmbFlag.ShadowColor = System.Drawing.Color.Black;
            this.cmbFlag.Size = new System.Drawing.Size(191, 26);
            this.cmbFlag.TabIndex = 7;
            // 
            // lblPosition
            // 
            this.lblPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblPosition.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(4)))), ((int)(((byte)(50)))));
            this.lblPosition.Location = new System.Drawing.Point(6, 27);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.ShadowColor = System.Drawing.Color.Black;
            this.lblPosition.Size = new System.Drawing.Size(191, 21);
            this.lblPosition.TabIndex = 6;
            this.lblPosition.Text = "Funcția";
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPosition
            // 
            this.txtPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.txtPosition.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(4)))), ((int)(((byte)(50)))));
            this.txtPosition.Location = new System.Drawing.Point(6, 51);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(191, 29);
            this.txtPosition.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(4)))), ((int)(((byte)(50)))));
            this.btnSave.Enabled = false;
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(4)))), ((int)(((byte)(50)))));
            this.btnSave.Location = new System.Drawing.Point(203, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowColor = System.Drawing.Color.Black;
            this.btnSave.Size = new System.Drawing.Size(188, 32);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Salvează";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.btnGenerate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(4)))), ((int)(((byte)(50)))));
            this.btnGenerate.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(4)))), ((int)(((byte)(50)))));
            this.btnGenerate.Location = new System.Drawing.Point(6, 256);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.ShadowColor = System.Drawing.Color.Black;
            this.btnGenerate.Size = new System.Drawing.Size(191, 32);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generează";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // pbAvatar
            // 
            this.pbAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAvatar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbAvatar.Location = new System.Drawing.Point(203, 51);
            this.pbAvatar.Name = "pbAvatar";
            this.pbAvatar.Size = new System.Drawing.Size(188, 188);
            this.pbAvatar.TabIndex = 2;
            this.pbAvatar.TabStop = false;
            // 
            // grpPhoto
            // 
            this.grpPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpPhoto.BackColor = System.Drawing.Color.Transparent;
            this.grpPhoto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(4)))), ((int)(((byte)(50)))));
            this.grpPhoto.Controls.Add(this.pbPhoto);
            this.grpPhoto.Controls.Add(this.btnLoad);
            this.grpPhoto.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.grpPhoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.grpPhoto.Location = new System.Drawing.Point(12, 42);
            this.grpPhoto.Name = "grpPhoto";
            this.grpPhoto.ShadowColor = System.Drawing.Color.Black;
            this.grpPhoto.Size = new System.Drawing.Size(189, 297);
            this.grpPhoto.TabIndex = 0;
            this.grpPhoto.TabStop = false;
            this.grpPhoto.Text = "Poza";
            this.grpPhoto.TextPosition = MatzaAvatarGenerator.CustomGroupBoxTextPosition.Center;
            // 
            // pbPhoto
            // 
            this.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPhoto.Location = new System.Drawing.Point(6, 115);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(176, 176);
            this.pbPhoto.TabIndex = 1;
            this.pbPhoto.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.btnLoad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(4)))), ((int)(((byte)(50)))));
            this.btnLoad.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(4)))), ((int)(((byte)(50)))));
            this.btnLoad.Location = new System.Drawing.Point(6, 51);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.ShadowColor = System.Drawing.Color.Black;
            this.btnLoad.Size = new System.Drawing.Size(176, 32);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Încarcă";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.Border = true;
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(4)))), ((int)(((byte)(50)))));
            this.BorderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(616, 397);
            this.Controls.Add(this.customLabel1);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grpAvatar);
            this.Controls.Add(this.grpPhoto);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(4)))), ((int)(((byte)(50)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = true;
            this.Name = "frmMain";
            this.Text = "Matza Avatar Generator by Mlendea Horatiu          ";
            this.Controls.SetChildIndex(this.grpPhoto, 0);
            this.Controls.SetChildIndex(this.grpAvatar, 0);
            this.Controls.SetChildIndex(this.btnUpdate, 0);
            this.Controls.SetChildIndex(this.lblVersion, 0);
            this.Controls.SetChildIndex(this.customLabel1, 0);
            this.grpAvatar.ResumeLayout(false);
            this.grpAvatar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvatar)).EndInit();
            this.grpPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomGroupBox grpPhoto;
        private CustomGroupBox grpAvatar;
        private CustomButton btnLoad;
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.PictureBox pbAvatar;
        private CustomButton btnGenerate;
        private CustomButton btnSave;
        private CustomLabel lblPosition;
        private System.Windows.Forms.TextBox txtPosition;
        private CustomButton btnUpdate;
        private CustomLabel lblVersion;
        private CustomLabel lblFlag;
        private CustomComboBox cmbFlag;
        private CustomComboBox cmbFootstep;
        private CustomLabel lblFootstep;
        private CustomComboBox cmbBorder;
        private CustomLabel lblBorder;
        private CustomLabel customLabel1;
    }
}