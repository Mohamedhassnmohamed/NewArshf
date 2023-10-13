
namespace Arshf.PL
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pic_logo = new DevExpress.XtraEditors.PictureEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.edt_companydes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edt_companyname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_savegen = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.edt_password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.edt_username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edt_port = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edt_database = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edt_servername = new System.Windows.Forms.TextBox();
            this.btn_saveconstring = new DevExpress.XtraEditors.SimpleButton();
            this.btn_backup = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new System.Windows.Forms.Label();
            this.loading = new DevExpress.XtraWaitForm.ProgressPanel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pic_logo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.edt_companydes);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.edt_companyname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_savegen);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(423, 585);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اعدادات عامة";
            // 
            // pic_logo
            // 
            this.pic_logo.EditValue = ((object)(resources.GetObject("pic_logo.EditValue")));
            this.pic_logo.Location = new System.Drawing.Point(3, 392);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_logo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pic_logo.Size = new System.Drawing.Size(249, 110);
            this.pic_logo.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(352, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "الشعار";
            // 
            // edt_companydes
            // 
            this.edt_companydes.Location = new System.Drawing.Point(3, 185);
            this.edt_companydes.Multiline = true;
            this.edt_companydes.Name = "edt_companydes";
            this.edt_companydes.Size = new System.Drawing.Size(414, 186);
            this.edt_companydes.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "وصف المؤسسة";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // edt_companyname
            // 
            this.edt_companyname.Location = new System.Drawing.Point(3, 91);
            this.edt_companyname.Multiline = true;
            this.edt_companyname.Name = "edt_companyname";
            this.edt_companyname.Size = new System.Drawing.Size(414, 44);
            this.edt_companyname.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "اسم المؤسسة";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_savegen
            // 
            this.btn_savegen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_savegen.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_savegen.Appearance.Options.UseFont = true;
            this.btn_savegen.ImageOptions.Image = global::Arshf.Properties.Resources.export_32x32;
            this.btn_savegen.Location = new System.Drawing.Point(247, 520);
            this.btn_savegen.Name = "btn_savegen";
            this.btn_savegen.Size = new System.Drawing.Size(170, 59);
            this.btn_savegen.TabIndex = 6;
            this.btn_savegen.Text = "حفظ";
            this.btn_savegen.Click += new System.EventHandler(this.btn_savegen_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btn_saveconstring);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(521, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(616, 468);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الاتصال الشبكي";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(462, 194);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(89, 28);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.Text = "شبكي";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(469, 100);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 28);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "محلي";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.loading);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.edt_password);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.edt_username);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.edt_port);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.edt_database);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.edt_servername);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(21, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(392, 340);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "كلمة السر";
            // 
            // edt_password
            // 
            this.edt_password.Enabled = false;
            this.edt_password.Location = new System.Drawing.Point(6, 290);
            this.edt_password.Multiline = true;
            this.edt_password.Name = "edt_password";
            this.edt_password.PasswordChar = '*';
            this.edt_password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edt_password.Size = new System.Drawing.Size(246, 44);
            this.edt_password.TabIndex = 16;
            this.edt_password.Text = "12345";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "اسم المستخدم";
            // 
            // edt_username
            // 
            this.edt_username.Enabled = false;
            this.edt_username.Location = new System.Drawing.Point(6, 225);
            this.edt_username.Multiline = true;
            this.edt_username.Name = "edt_username";
            this.edt_username.PasswordChar = '*';
            this.edt_username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edt_username.Size = new System.Drawing.Size(246, 44);
            this.edt_username.TabIndex = 14;
            this.edt_username.Text = "MS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(284, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "قاعدة البيانات";
            // 
            // edt_port
            // 
            this.edt_port.Enabled = false;
            this.edt_port.Location = new System.Drawing.Point(6, 160);
            this.edt_port.Multiline = true;
            this.edt_port.Name = "edt_port";
            this.edt_port.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edt_port.Size = new System.Drawing.Size(246, 44);
            this.edt_port.TabIndex = 12;
            this.edt_port.Text = "1433";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "رقم المنفذ";
            // 
            // edt_database
            // 
            this.edt_database.Enabled = false;
            this.edt_database.Location = new System.Drawing.Point(6, 94);
            this.edt_database.Multiline = true;
            this.edt_database.Name = "edt_database";
            this.edt_database.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edt_database.Size = new System.Drawing.Size(246, 44);
            this.edt_database.TabIndex = 10;
            this.edt_database.Text = "DBAR";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(284, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 21);
            this.label6.TabIndex = 7;
            this.label6.Text = "اسم السيرفر";
            // 
            // edt_servername
            // 
            this.edt_servername.Location = new System.Drawing.Point(6, 27);
            this.edt_servername.Multiline = true;
            this.edt_servername.Name = "edt_servername";
            this.edt_servername.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edt_servername.Size = new System.Drawing.Size(246, 44);
            this.edt_servername.TabIndex = 8;
            this.edt_servername.Text = ".\\SQLEXPRESS";
            // 
            // btn_saveconstring
            // 
            this.btn_saveconstring.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_saveconstring.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveconstring.Appearance.Options.UseFont = true;
            this.btn_saveconstring.ImageOptions.Image = global::Arshf.Properties.Resources.export_32x32;
            this.btn_saveconstring.Location = new System.Drawing.Point(423, 372);
            this.btn_saveconstring.Name = "btn_saveconstring";
            this.btn_saveconstring.Size = new System.Drawing.Size(170, 59);
            this.btn_saveconstring.TabIndex = 6;
            this.btn_saveconstring.Text = "حفظ";
            this.btn_saveconstring.Click += new System.EventHandler(this.btn_saveconstring_Click);
            // 
            // btn_backup
            // 
            this.btn_backup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_backup.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backup.Appearance.Options.UseFont = true;
            this.btn_backup.ImageOptions.Image = global::Arshf.Properties.Resources.export_32x32;
            this.btn_backup.Location = new System.Drawing.Point(548, 538);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(572, 59);
            this.btn_backup.TabIndex = 6;
            this.btn_backup.Text = "اخذ نسخه احتياطية";
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(631, 497);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(489, 28);
            this.label9.TabIndex = 16;
            this.label9.Text = "يجب تشغيل البرنامج كمسئول حتي تتمكن من النسخ الاحتياطي";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // loading
            // 
            this.loading.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.loading.Appearance.Options.UseBackColor = true;
            this.loading.Caption = "الرجاء الانتظار";
            this.loading.Description = "جاري عملية النسخ الاحتياطي يرجي الانتظار";
            this.loading.Location = new System.Drawing.Point(-75, 275);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(280, 66);
            this.loading.TabIndex = 17;
            this.loading.Text = "progressPanel1";
            this.loading.Visible = false;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 670);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_backup);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اعدادات البرنامج";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public DevExpress.XtraEditors.SimpleButton btn_savegen;
        private System.Windows.Forms.TextBox edt_companydes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edt_companyname;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PictureEdit pic_logo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox edt_password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox edt_username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edt_port;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edt_database;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edt_servername;
        public DevExpress.XtraEditors.SimpleButton btn_saveconstring;
        public DevExpress.XtraEditors.SimpleButton btn_backup;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraWaitForm.ProgressPanel loading;
    }
}