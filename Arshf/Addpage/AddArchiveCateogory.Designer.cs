
namespace Arshf.Addpage
{
    partial class AddArchiveCateogory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddArchiveCateogory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.edt_name = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.edt_detailes = new System.Windows.Forms.RichTextBox();
            this.toastNotificationsManager1 = new DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(this.components);
            this.loading = new DevExpress.XtraWaitForm.ProgressPanel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edt_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 391);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 82);
            this.panel1.TabIndex = 0;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_add.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = global::Arshf.Properties.Resources.add_32x32;
            this.btn_add.Location = new System.Drawing.Point(645, 11);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(170, 59);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "اضافة";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "عنوان الارشيف";
            // 
            // edt_name
            // 
            this.edt_name.Location = new System.Drawing.Point(220, 48);
            this.edt_name.Name = "edt_name";
            this.edt_name.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_name.Properties.Appearance.Options.UseFont = true;
            this.edt_name.Size = new System.Drawing.Size(388, 42);
            this.edt_name.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "تفاصيل";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // edt_detailes
            // 
            this.edt_detailes.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_detailes.Location = new System.Drawing.Point(220, 195);
            this.edt_detailes.Name = "edt_detailes";
            this.edt_detailes.Size = new System.Drawing.Size(398, 160);
            this.edt_detailes.TabIndex = 3;
            this.edt_detailes.Text = "";
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
            this.loading.Location = new System.Drawing.Point(43, 96);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(246, 66);
            this.loading.TabIndex = 4;
            this.loading.Text = "progressPanel1";
            this.loading.Visible = false;
            // 
            // AddArchiveCateogory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 473);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.edt_detailes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edt_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.IconOptions.ShowIcon = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddArchiveCateogory";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة قسم";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddDep_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.edt_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toastNotificationsManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public DevExpress.XtraEditors.SimpleButton btn_add;
        public DevExpress.XtraEditors.TextEdit edt_name;
        public System.Windows.Forms.RichTextBox edt_detailes;
        private DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager toastNotificationsManager1;
        private DevExpress.XtraWaitForm.ProgressPanel loading;
    }
}