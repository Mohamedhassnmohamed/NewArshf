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
    public partial class AddDep : DevExpress.XtraEditors.XtraForm
    {
        //Database and tables
        DBAREntities db;
        TBDep tbadd;
        //other variable
        public int id;
        public pages.DepPage page;
        bool state;
        public AddDep()
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
                    
                    tbadd = new TBDep
                    {
                        DepName = edt_name.Text,
                        DepDetailes=edt_detailes.Text,

                    };
                }
                //edit
                else
                {
                    tbadd = new TBDep
                    {
                        ID = id,
                        DepName = edt_name.Text,
                        DepDetailes = edt_detailes.Text,

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
        private bool AddorEdit(TBDep Data)
        {
            try
            {
                db = new DBAREntities();
                db.Set<TBDep>().AddOrUpdate(Data);
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