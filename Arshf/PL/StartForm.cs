using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Arshf.PL
{
    public partial class StartForm : SplashScreen
    {
        DBAREntities db;
        TBUSER tbadd;
        int state;
        public StartForm()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        
        }
        private void CheckState()
        {
            try
            {
                db = new DBAREntities();
                var userid = db.TBUSERS.Select(x => x.ID).FirstOrDefault();
                // Login in
                if (userid > 0)
                {
                    state = 1;
                }
                else
                {
                    state = 2;
                }

            }
            catch
            {
                state = 3;
            }
        }
        private async void StartForm_Load(object sender, EventArgs e)
        {
            await Task.Run(() => CheckState());
            if (state == 1)
            {
                Addpage.LoginForm loginFrom = new Addpage.LoginForm();
                loginFrom.Show();
                Hide();
            }
            if (state == 2)
            {
                // Add Dep and User
                Addpage.AddDep DepPage = new Addpage.AddDep();
               // DepPage.start = 1;
                MessageBox.Show("مرحبا بك , الصفحة القادمة تتيح لك اضافة قسم ");
                DepPage.Show();
                Hide();
            }
            if (state == 3)
            {
                // Set Server Con form Settings
                var rs = MessageBox.Show("اختر نعم لاعادة الاتصال, لا لضبط الاتصال, الغاء الامر لغلق البرنامج", "خطأ اتصال", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                {
                    Application.Restart();
                }
                else if (rs == DialogResult.No)
                {
                    PL.SettingForm setting = new SettingForm();
                    //setting.Start = 1;
                    setting.Show();
                    Hide();

                }
                else if (rs == DialogResult.Cancel)
                {
                    Application.Exit();
                }

            }
        }
    }
}