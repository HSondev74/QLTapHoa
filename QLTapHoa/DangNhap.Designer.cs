﻿namespace QLTapHoa
{
    partial class fr_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_DangNhap));
            this.txt_User = new System.Windows.Forms.TextBox();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.chb_remember = new System.Windows.Forms.CheckBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_Quyen = new System.Windows.Forms.ComboBox();
            this.qLTapHoaDataSet = new QLTapHoa.QLTapHoaDataSet();
            this.quyenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quyenTableAdapter = new QLTapHoa.QLTapHoaDataSetTableAdapters.QuyenTableAdapter();
            this.btn_openPass = new System.Windows.Forms.Panel();
            this.btn_ClosePass = new System.Windows.Forms.Panel();
            this.kryptonLinkLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.qLTapHoaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quyenBindingSource)).BeginInit();
            this.btn_ClosePass.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(336, 91);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(190, 22);
            this.txt_User.TabIndex = 0;
            this.txt_User.TextChanged += new System.EventHandler(this.txt_User_TextChanged);
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.Location = new System.Drawing.Point(320, 230);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(190, 37);
            this.btn_DangNhap.TabIndex = 1;
            this.btn_DangNhap.Text = "Dang Nhap";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // chb_remember
            // 
            this.chb_remember.AutoSize = true;
            this.chb_remember.Location = new System.Drawing.Point(320, 186);
            this.chb_remember.Name = "chb_remember";
            this.chb_remember.Size = new System.Drawing.Size(72, 20);
            this.chb_remember.TabIndex = 2;
            this.chb_remember.Text = "ghi nho";
            this.chb_remember.UseVisualStyleBackColor = true;
            this.chb_remember.CheckedChanged += new System.EventHandler(this.chb_remember_CheckedChanged);
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(336, 138);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(190, 22);
            this.txt_pass.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ten Dang Nhap";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mat Khau";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nguoi Dung";
            // 
            // cmb_Quyen
            // 
            this.cmb_Quyen.FormattingEnabled = true;
            this.cmb_Quyen.Location = new System.Drawing.Point(336, 52);
            this.cmb_Quyen.Name = "cmb_Quyen";
            this.cmb_Quyen.Size = new System.Drawing.Size(190, 24);
            this.cmb_Quyen.TabIndex = 6;
            // 
            // qLTapHoaDataSet
            // 
            this.qLTapHoaDataSet.DataSetName = "QLTapHoaDataSet";
            this.qLTapHoaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quyenBindingSource
            // 
            this.quyenBindingSource.DataMember = "Quyen";
            this.quyenBindingSource.DataSource = this.qLTapHoaDataSet;
            // 
            // quyenTableAdapter
            // 
            this.quyenTableAdapter.ClearBeforeFill = true;
            // 
            // btn_openPass
            // 
            this.btn_openPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_openPass.BackgroundImage")));
            this.btn_openPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_openPass.Location = new System.Drawing.Point(0, 0);
            this.btn_openPass.Name = "btn_openPass";
            this.btn_openPass.Size = new System.Drawing.Size(26, 22);
            this.btn_openPass.TabIndex = 7;
            this.btn_openPass.Click += new System.EventHandler(this.btn_openPass_Click);
            this.btn_openPass.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_openPass_Paint);
            // 
            // btn_ClosePass
            // 
            this.btn_ClosePass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ClosePass.BackgroundImage")));
            this.btn_ClosePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ClosePass.Controls.Add(this.btn_openPass);
            this.btn_ClosePass.Location = new System.Drawing.Point(532, 138);
            this.btn_ClosePass.Name = "btn_ClosePass";
            this.btn_ClosePass.Size = new System.Drawing.Size(26, 22);
            this.btn_ClosePass.TabIndex = 8;
            this.btn_ClosePass.Click += new System.EventHandler(this.btn_ClosePass_Click);
            this.btn_ClosePass.Paint += new System.Windows.Forms.PaintEventHandler(this.btn_ClosePass_Paint);
            // 
            // kryptonLinkLabel1
            // 
            this.kryptonLinkLabel1.Location = new System.Drawing.Point(408, 182);
            this.kryptonLinkLabel1.Name = "kryptonLinkLabel1";
            this.kryptonLinkLabel1.Size = new System.Drawing.Size(118, 24);
            this.kryptonLinkLabel1.TabIndex = 9;
            this.kryptonLinkLabel1.Values.Text = "Quen Mat Khau";
            this.kryptonLinkLabel1.LinkClicked += new System.EventHandler(this.kryptonLinkLabel1_LinkClicked);
            // 
            // fr_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(734, 440);
            this.Controls.Add(this.kryptonLinkLabel1);
            this.Controls.Add(this.cmb_Quyen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ClosePass);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chb_remember);
            this.Name = "fr_DangNhap";
            this.Text = "Dang Nhap";
            this.Load += new System.EventHandler(this.fr_DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLTapHoaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quyenBindingSource)).EndInit();
            this.btn_ClosePass.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.CheckBox chb_remember;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_Quyen;
        private QLTapHoaDataSet qLTapHoaDataSet;
        private System.Windows.Forms.BindingSource quyenBindingSource;
        private QLTapHoaDataSetTableAdapters.QuyenTableAdapter quyenTableAdapter;
        private System.Windows.Forms.Panel btn_openPass;
        private System.Windows.Forms.Panel btn_ClosePass;
        private ComponentFactory.Krypton.Toolkit.KryptonLinkLabel kryptonLinkLabel1;
    }
}