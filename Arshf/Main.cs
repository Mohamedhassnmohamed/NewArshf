using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Arshf
{
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        public Main()
        {
            InitializeComponent();
            LoadHomePage();
        }
        // load home page
        private void tileBarItem1_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            LoadHomePage();
        }

        private void LoadHomePage()
        {
            pages.HomePage page = new pages.HomePage();
            LoadPage(page);
        }
        // load page Method
        private void LoadPage(DevExpress.XtraEditors.XtraUserControl page)
        {
            try
            {
                var oldpage = pn_Container.Controls.OfType<XtraUserControl>().FirstOrDefault();
                if(oldpage!=null)
                {
                    pn_Container.Controls.Remove(oldpage);
                    oldpage.Dispose();
                }
               // pn_Container.Controls.Clear();
                page.Dock = DockStyle.Fill;
                pn_Container.Controls.Add(page);

            }
            catch { }
        }
        
        

        private void tileBarItem3_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            pages.UsersPage page = new pages.UsersPage ();
            LoadPage(page);
        }

        private void btn_dep_ItemDoubleClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
           // item on double clilc
        }

        private void btn_dep_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            pages.DepPage page = new pages.DepPage();
            LoadPage(page);
        }

        private void btn_archive_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            pages.ArchiveCatPage page = new pages.ArchiveCatPage();
            LoadPage(page);
        }

        private void btn_settings_ItemClick(object sender, TileItemEventArgs e)
        {
            PL.SettingForm setting = new PL.SettingForm();
            setting.Show();
        }

        private void btn_help_ItemClick(object sender, TileItemEventArgs e)
        {
            Application.Exit();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
