
namespace Arshf
{
    partial class Main
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.pn_Container = new System.Windows.Forms.Panel();
            this.btn_home = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.btn_dep = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.btn_users = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.btn_archive = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.btn_settings = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.btn_help = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.SuspendLayout();
            // 
            // tileBar1
            // 
            this.tileBar1.AllowSelectedItem = true;
            this.tileBar1.AppearanceItem.Selected.BackColor = System.Drawing.Color.Red;
            this.tileBar1.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.Red;
            this.tileBar1.AppearanceItem.Selected.Options.UseBackColor = true;
            this.tileBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tileBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar1.Groups.Add(this.tileBarGroup2);
            this.tileBar1.Location = new System.Drawing.Point(0, 0);
            this.tileBar1.MaxId = 6;
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar1.Size = new System.Drawing.Size(1078, 114);
            this.tileBar1.TabIndex = 0;
            this.tileBar1.Text = "tileBar1";
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.btn_home);
            this.tileBarGroup2.Items.Add(this.btn_dep);
            this.tileBarGroup2.Items.Add(this.btn_users);
            this.tileBarGroup2.Items.Add(this.btn_archive);
            this.tileBarGroup2.Items.Add(this.btn_settings);
            this.tileBarGroup2.Items.Add(this.btn_help);
            this.tileBarGroup2.Name = "tileBarGroup2";
            this.tileBarGroup2.Text = "الرئيسية";
            // 
            // pn_Container
            // 
            this.pn_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Container.Location = new System.Drawing.Point(0, 114);
            this.pn_Container.Name = "pn_Container";
            this.pn_Container.Size = new System.Drawing.Size(1078, 566);
            this.pn_Container.TabIndex = 1;
            // 
            // btn_home
            // 
            this.btn_home.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.AppearanceItem.Normal.Options.UseFont = true;
            this.btn_home.AppearanceItem.Selected.BackColor = System.Drawing.Color.Red;
            this.btn_home.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.Red;
            this.btn_home.AppearanceItem.Selected.Options.UseBackColor = true;
            this.btn_home.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.ImageOptions.Image = global::Arshf.Properties.Resources.home_32x32;
            tileItemElement1.Text = "الرئيسية";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.btn_home.Elements.Add(tileItemElement1);
            this.btn_home.Id = 0;
            this.btn_home.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btn_home.Name = "btn_home";
            this.btn_home.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBarItem1_ItemClick);
            // 
            // btn_dep
            // 
            this.btn_dep.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dep.AppearanceItem.Normal.Options.UseFont = true;
            this.btn_dep.AppearanceItem.Selected.BackColor = System.Drawing.Color.Red;
            this.btn_dep.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.Red;
            this.btn_dep.AppearanceItem.Selected.Options.UseBackColor = true;
            this.btn_dep.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.ImageOptions.Image = global::Arshf.Properties.Resources.publicfix_32x32;
            tileItemElement2.Text = "الاقسام";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.btn_dep.Elements.Add(tileItemElement2);
            this.btn_dep.Id = 1;
            this.btn_dep.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btn_dep.Name = "btn_dep";
            this.btn_dep.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_dep_ItemClick);
            this.btn_dep.ItemDoubleClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_dep_ItemDoubleClick);
            // 
            // btn_users
            // 
            this.btn_users.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_users.AppearanceItem.Normal.Options.UseFont = true;
            this.btn_users.AppearanceItem.Selected.BackColor = System.Drawing.Color.Red;
            this.btn_users.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.Red;
            this.btn_users.AppearanceItem.Selected.Options.UseBackColor = true;
            this.btn_users.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.ImageOptions.Image = global::Arshf.Properties.Resources.usergroup_32x321;
            tileItemElement3.Text = "مستخدمين";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.btn_users.Elements.Add(tileItemElement3);
            this.btn_users.Id = 2;
            this.btn_users.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btn_users.Name = "btn_users";
            this.btn_users.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileBarItem3_ItemClick);
            // 
            // btn_archive
            // 
            this.btn_archive.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_archive.AppearanceItem.Normal.Options.UseFont = true;
            this.btn_archive.AppearanceItem.Selected.BackColor = System.Drawing.Color.Red;
            this.btn_archive.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.Red;
            this.btn_archive.AppearanceItem.Selected.Options.UseBackColor = true;
            this.btn_archive.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.ImageOptions.Image = global::Arshf.Properties.Resources.projectfile_32x32;
            tileItemElement4.Text = "ارشيف";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.btn_archive.Elements.Add(tileItemElement4);
            this.btn_archive.Id = 3;
            this.btn_archive.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btn_archive.Name = "btn_archive";
            this.btn_archive.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_archive_ItemClick);
            // 
            // btn_settings
            // 
            this.btn_settings.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.AppearanceItem.Normal.Options.UseFont = true;
            this.btn_settings.AppearanceItem.Selected.BackColor = System.Drawing.Color.Red;
            this.btn_settings.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.Red;
            this.btn_settings.AppearanceItem.Selected.Options.UseBackColor = true;
            this.btn_settings.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.ImageOptions.Image = global::Arshf.Properties.Resources.properties_32x32;
            tileItemElement5.Text = "الاعدادات";
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.btn_settings.Elements.Add(tileItemElement5);
            this.btn_settings.Id = 4;
            this.btn_settings.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_settings_ItemClick);
            // 
            // btn_help
            // 
            this.btn_help.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_help.AppearanceItem.Normal.Options.UseFont = true;
            this.btn_help.AppearanceItem.Selected.BackColor = System.Drawing.Color.Red;
            this.btn_help.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.Red;
            this.btn_help.AppearanceItem.Selected.Options.UseBackColor = true;
            this.btn_help.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement6.ImageOptions.Image = global::Arshf.Properties.Resources.changeview_32x32;
            tileItemElement6.Text = "تسجيل الخروج";
            tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.btn_help.Elements.Add(tileItemElement6);
            this.btn_help.Id = 5;
            this.btn_help.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.btn_help.Name = "btn_help";
            this.btn_help.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.btn_help_ItemClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 680);
            this.Controls.Add(this.pn_Container);
            this.Controls.Add(this.tileBar1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "ارشيف";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem btn_home;
        private System.Windows.Forms.Panel pn_Container;
        private DevExpress.XtraBars.Navigation.TileBarItem btn_archive;
        private DevExpress.XtraBars.Navigation.TileBarItem btn_settings;
        private DevExpress.XtraBars.Navigation.TileBarItem btn_help;
        public DevExpress.XtraBars.Navigation.TileBarItem btn_dep;
        public DevExpress.XtraBars.Navigation.TileBarItem btn_users;
    }
}

