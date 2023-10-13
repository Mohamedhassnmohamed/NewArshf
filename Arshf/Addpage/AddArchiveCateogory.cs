using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arshf.Addpage
{
    public partial class AddArchiveCateogory : DevExpress.XtraEditors.XtraForm
    {
        //Database and tables
        DBAREntities db;
        TBArchiveCategory tbadd;
        //other variable
        public int id;
        public pages.ArchiveCatPage page;
        bool state;
        public AddArchiveCateogory()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddDep_Load(object sender, EventArgs e)
        {

        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            if(edt_name.Text== "")
            {
                MessageBox.Show("خطأ ادخال ", "من فضلك اكمل الفارغ ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                //set data
                // add or edt
                if(id==0)
                    //add 
                {

                    tbadd = new TBArchiveCategory
                    {
                        ArchiveTitle = edt_name.Text,
                        ArchiveDes=edt_detailes.Text,
                        UserName=Properties.Settings.Default.FullName,
                        UserDep=Properties.Settings.Default.UserDep,
                        IDUser= Properties.Settings.Default.UserID

                    };
                }
                //edit
                else
                {
                    tbadd = new TBArchiveCategory
                    {
                        ID = id,
                        ArchiveTitle = edt_name.Text,
                        ArchiveDes = edt_detailes.Text,
                        UserName = Properties.Settings.Default.FullName,
                        UserDep = Properties.Settings.Default.UserDep,
                        IDUser = Properties.Settings.Default.UserID

                    };
                }
                //loading
                loading.Visible=true;
               // Thread.Sleep(4000);
                
                // ADD or Edit
                 var result =await Task.Run(() => AddorEdit(tbadd));
                if(result==true)
                {
                    // Reload data
                    page.LoadData();
                    toastNotificationsManager1.ShowNotification("c8aa9857-a8ac-4d9f-9a9b-19df6074d546");
                    Close();
                    
                }
                else
                {
                    MessageBox.Show("خطأ في الاتصال ", "تأكد من الاتصال بالسيرفر ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                loading.Visible = false;

            }
            
        }
        //add or edit
        private bool AddorEdit(TBArchiveCategory Data)
        {
            try
            {
                db = new DBAREntities();
                db.Set<TBArchiveCategory>().AddOrUpdate(Data);
                db.SaveChanges();
                state = true;
            }
            catch
            {
                state = false;
            }
            return state;
        }
    }
}