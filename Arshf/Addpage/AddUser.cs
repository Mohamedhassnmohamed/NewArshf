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
    public partial class AddUser : DevExpress.XtraEditors.XtraForm
    {
        //Database and tables
        DBAREntities db;
        private List<string> DepNameList;
        TBUSER tbadd;
        //other variable
        public int id;
        public int depid;

        public pages.UsersPage page;
        bool state;
        public AddUser()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void AddDep_Load(object sender, EventArgs e)
        {
            loading.Visible = true;
           var rs=  await Task.Run(() => LoadDepName());
            if(rs== true)
            {
                edt_Dep.DataSource = DepNameList;
            }
            else
            {
                MessageBox.Show("خطأ في الاتصال ", "تأكد من الاتصال بالسيرفر ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loading.Visible = false;
        }

        private async void btn_add_Click(object sender, EventArgs e)
        {
            if(edt_name.Text== "" || edt_username.Text== "" ||edt_password.Text== "" || edt_Dep.SelectedItem==null || edt_role.SelectedItem == null || depid==null)
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

                    tbadd = new TBUSER
                    {
                        IDDep= depid,
                        FullName = edt_name.Text,
                        UserName = edt_username.Text,
                        Password = edt_password.Text,
                        UserRole = edt_role.Text,
                        DepName = edt_Dep.Text,

                    };
                }
                //edit
                else
                {
                    tbadd = new TBUSER
                    {
                        ID=id,
                        IDDep = depid,
                        FullName = edt_name.Text,
                        UserName = edt_username.Text,
                        Password = edt_password.Text,
                        UserRole = edt_role.Text,
                        DepName = edt_Dep.Text,

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
        private bool AddorEdit(TBUSER Data)
        {
            try
            {
                db = new DBAREntities();
                db.Set<TBUSER>().AddOrUpdate(Data);
                db.SaveChanges();
                state = true;
            }
            catch
            {
                state = false;
            }
            return state;
        }
        private bool LoadDepName()
        {
            try
            {
                db = new DBAREntities();
                 DepNameList = db.TBDeps.Select(x => x.DepName).ToList();
                state = true;
            }
            catch
            {
                state = false;
            }
            return state;
        }

        private async void edt_Dep_SelectedIndexChanged(object sender, EventArgs e)
        {

            loading.Visible = true;
            var depName = edt_Dep.Text;
            var rs = await Task.Run(() => LoadDepId(depName));
            if (rs == false)
            {
                MessageBox.Show("خطأ في الاتصال ", "تأكد من الاتصال بالسيرفر ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
                
            
            loading.Visible = false;



        }
        
        private bool LoadDepId(string DepName)
        {
            try
            {
                db = new DBAREntities();
                depid = db.TBDeps.Where(x => x.DepName == DepName).Select(x => x.ID).First();
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