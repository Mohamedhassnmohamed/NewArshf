
namespace Arshf.Addpage
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.edt_name = new DevExpress.XtraEditors.TextEdit();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.loading = new DevExpress.XtraWaitForm.ProgressPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.edt_role = new System.Windows.Forms.ComboBox();
            this.edt_Dep = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edt_password = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.edt_username = new DevExpress.XtraEditors.TextEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_username.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 643);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 82);
            this.panel1.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = global::Arshf.Properties.Resources.add_32x32;
            this.btn_add.Location = new System.Drawing.Point(754, 11);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(288, 59);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "اضافة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "الاسم الكامل";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edt_name
            // 
            this.edt_name.Location = new System.Drawing.Point(6, 77);
            this.edt_name.Name = "edt_name";
            this.edt_name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_name.Properties.Appearance.Options.UseFont = true;
            this.edt_name.Size = new System.Drawing.Size(307, 40);
            this.edt_name.TabIndex = 2;
            // 
            // toastNotificationsManager1
            // 
            this.toastNotificationsManager1.ApplicationId = "42dab000-bfbe-463b-855d-f2e34dcff68c";
            this.toastNotificationsManager1.Notifications.AddRange(new DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties[] {
            new DevExpress.XtraBars.ToastNotifications.ToastNotification("c8aa9857-a8ac-4d9f-9a9b-19df6074d546", ((System.Drawing.Image)(resources.GetObject("toastNotificationsManager1.Notifications"))), "تمت عملية  بنجاح", "تمت عملية  بنجاح", "تمت عملية  بنجاح", DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.ImageAndText01)});
            // 
            // loading
            // 
            this.loading.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.loading.Appearance.Options.UseBackColor = true;
            this.loading.Caption = "الرجاء الانتظار";
            this.loading.Description = "العملية تجري الان";
            this.loading.Location = new System.Drawing.Point(53, 338);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(246, 66);
            this.loading.TabIndex = 4;
            this.loading.Text = "progressPanel1";
            this.loading.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.edt_role);
            this.panel2.Controls.Add(this.edt_Dep);
            this.panel2.Controls.Add(this.loading);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.edt_password);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.edt_username);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.edt_name);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(513, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 643);
            this.panel2.TabIndex = 5;
            // 
            // edt_role
            // 
            this.edt_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edt_role.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_role.FormattingEnabled = true;
            this.edt_role.Items.AddRange(new object[] {
            "مدير",
            "مستخدم"});
            this.edt_role.Location = new System.Drawing.Point(6, 522);
            this.edt_role.Name = "edt_role";
            this.edt_role.Size = new System.Drawing.Size(327, 41);
            this.edt_role.TabIndex = 13;
            // 
            // edt_Dep
            // 
            this.edt_Dep.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edt_Dep.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_Dep.FormattingEnabled = true;
            this.edt_Dep.Location = new System.Drawing.Point(6, 410);
            this.edt_Dep.Name = "edt_Dep";
            this.edt_Dep.Size = new System.Drawing.Size(327, 41);
            this.edt_Dep.TabIndex = 12;
            this.edt_Dep.SelectedIndexChanged += new System.EventHandler(this.edt_Dep_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(413, 523);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 36);
            this.label6.TabIndex = 11;
            this.label6.Text = "الصلاحية";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(437, 393);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 36);
            this.label5.TabIndex = 9;
            this.label5.Text = "القسم";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(391, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "كلمة السر";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edt_password
            // 
            this.edt_password.Location = new System.Drawing.Point(6, 299);
            this.edt_password.Name = "edt_password";
            this.edt_password.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_password.Properties.Appearance.Options.UseFont = true;
            this.edt_password.Size = new System.Drawing.Size(307, 40);
            this.edt_password.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "اسم المستخدم";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // edt_username
            // 
            this.edt_username.Location = new System.Drawing.Point(6, 188);
            this.edt_username.Name = "edt_username";
            this.edt_username.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_username.Properties.Appearance.Options.UseFont = true;
            this.edt_username.Size = new System.Drawing.Size(307, 40);
            this.edt_username.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(513, 643);
            this.panel3.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(131, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Tahoma", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(94, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(329, 58);
            this.label2.TabIndex = 1;
            this.label2.Text = "اضافة مستخدم";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 725);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUser";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافه مستخدم";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddDep_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edt_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_username.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public DevExpress.XtraEditors.SimpleButton btn_add;
        public DevExpress.XtraEditors.TextEdit edt_name;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        private DevExpress.XtraWaitForm.ProgressPanel loading;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public DevExpress.XtraEditors.TextEdit edt_password;
        private System.Windows.Forms.Label label3;
        public DevExpress.XtraEditors.TextEdit edt_username;
        public System.Windows.Forms.ComboBox edt_role;
        public System.Windows.Forms.ComboBox edt_Dep;
    }
}