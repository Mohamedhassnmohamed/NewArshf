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
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
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
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private async void btn_add_Click(object sender, EventArgs e)
        {
            if (edt_username.Text == "" || edt_password.Text == "")
            {
                MessageBox.Show("خطأ ادخال", "اكمل الحقول لطفا", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Set Data



                // loading
                loading.Visible = true;
                // Add or Edit
                var username = edt_username.Text;
                var pasword = edt_password.Text;
                var result = await Task.Run(() => LoginCheck(username, pasword));
                if (result == true)
                {
                    // Sign in 
                    Main main = new Main();
                    // Set User Data
                    Properties.Settings.Default.UserID = tbadd.ID;
                    Properties.Settings.Default.FullName = tbadd.FullName;
                    Properties.Settings.Default.UserName = tbadd.UserName;
                    Properties.Settings.Default.UserRole = tbadd.UserRole;
                    Properties.Settings.Default.UserDep = tbadd.DepName;
                    Properties.Settings.Default.Save();
                    // Role 
                    if (tbadd.UserRole == "مستخدم")
                    {
                        main.btn_dep.Visible = false;
                        main.btn_users.Visible = false;
                    }
                    main.Show();

                    Hide();
                }
                else
                {
                    MessageBox.Show("خطأ في تسجل الدخول", "خطأ في معلومات تسجيل الدخول", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                loading.Visible = false;


            }
        }
        //add or edit
        private bool LoginCheck(string UserName, string Password)
        {
            try
            {
                db = new DBAREntities();
                tbadd = db.TBUSERS.Where(X => X.UserName == UserName && X.Password == Password).FirstOrDefault();
                if (tbadd != null)
                {
                    state = true;

                }
                else
                {
                    state = false;

                }

            }

            catch { state = false; }
            return state;
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}