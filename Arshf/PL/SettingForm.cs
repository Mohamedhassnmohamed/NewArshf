﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace Arshf.PL
{
    public partial class SettingForm : DevExpress.XtraEditors.XtraForm
    {
        private DBAREntities db;
        private string msg;

        //  public object ConfigurationManager { get; private set; }

        public SettingForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_savegen_Click(object sender, EventArgs e)
        {
            savesettings();
        }
        private void savesettings()
        {
            try
            {
                Properties.Settings.Default.CompanyName = edt_companyname.Text;
                Properties.Settings.Default.CompanyDes =edt_companydes.Text;
                // set Logo

                var ma = new MemoryStream();
                pic_logo.Image.Save(ma,System.Drawing.Imaging.ImageFormat.Png);
                Properties.Settings.Default.CompanyLogo = Convert.ToBase64String(ma.ToArray());
                Properties.Settings.Default.Save();
                MessageBox.Show("تم حفظ الاعدادات");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SettingForm_Load(object sender, EventArgs e)
        {
            GetSettings();
        }
        private void GetSettings()
        {
            try
            {
                edt_companyname.Text= Properties.Settings.Default.CompanyName;
                edt_companydes.Text= Properties.Settings.Default.CompanyDes;
                // set Logo
                var Bytimage = Convert.FromBase64String(Properties.Settings.Default.CompanyLogo);
                if(Bytimage !=null)
                {
                    var ma = new MemoryStream(Bytimage);
                    pic_logo.Image = Image.FromStream(ma);
                   // Convert.ToBase64String(ma.ToArray());
                }
                
                //Properties.Settings.Default.Save();
            }
            catch 
            {
               // MessageBox.Show(ex.Message);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            SetconType();
        }
        private void SetconType()
        {
            if(radioButton1.Checked==true)
            {
               //edt_database.Enabled = false;
                edt_port.Enabled = false;
                edt_username.Enabled = false;
                edt_password.Enabled = false; 

            }
            else
            {
                //edt_database.Enabled = true;
                edt_port.Enabled = true;
                edt_username.Enabled = true;
                edt_password.Enabled = true;
            }
        }

        private void btn_saveconstring_Click(object sender, EventArgs e)
        {
            //method to save
            SaveConString();
            //method to encribt
            Encrypteconstring();
        }
        private void SaveConString()
        {
            //get input
            var server = edt_servername.Text;
            var dbname = edt_database.Text;
            var port = "," + edt_port.Text;
            var user = edt_username.Text;
            var password = edt_password.Text;
            if(radioButton1.Checked==true)
            {
                // local conection
                var ConString = @"metadata = res://*/DBAR.csdl|res://*/DBAR.ssdl|res://*/DBAR.msl;provider=System.Data.SqlClient;provider connection string=';data source=" + server + ";initial catalog=" + dbname + ";integrated security=True;MultipleActiveResultSets=True;App=EntityFramework';";

                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                connectionStringsSection.ConnectionStrings["DBAREntities"].ConnectionString = ConString;
                config.Save();

                ConfigurationManager.RefreshSection("connectionStrings");

                MessageBox.Show("تم تحديث الاتصال بنجاح , سيتم اعادة تشغيل البرنامج لتطبيق الاعدادات ");
                Application.Restart();





            }
            else
            {
                // local conection
                var ConString = @"metadata=res://*/DBAR.csdl|res://*/DBAR.ssdl|res://*/DBAR.msl;provider=System.Data.SqlClient;provider connection string=';data source=" + server + port + ";initial catalog=" + dbname + ";user id=" + user + ";password=" + password + ";connect Timeout=60;MultipleActiveResultSets=True;App=EntityFramework';";
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
                connectionStringsSection.ConnectionStrings["DBAREntities"].ConnectionString = ConString;
                config.Save();

                ConfigurationManager.RefreshSection("connectionStrings");

                MessageBox.Show("تم تحديث الاتصال بنجاح , سيتم اعادة تشغيل البرنامج لتطبيق الاعدادات ");
                Application.Restart();

            }

        }
        private void Encrypteconstring()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            ExeConfigurationFileMap configFileMap = new ExeConfigurationFileMap();
            configFileMap.ExeConfigFilename = config.FilePath;
            System.Configuration.Configuration myConfig = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);

            ConnectionStringsSection section = myConfig.GetSection("connectionStrings") as ConnectionStringsSection;

            if (section.SectionInformation.IsProtected)
            {
                // Remove encryption.
                section.SectionInformation.UnprotectSection();
            }
            else
            {
                // Encrypt the section.
                section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
            }

            myConfig.Save();
        }

        private async void btn_backup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            var rs = fbd.ShowDialog();
            if (rs == DialogResult.OK)
            {
                loading.Visible = true;
                var state = await Task.Run(() => BackUp(fbd));

                if (state == true)
                {
                    MessageBox.Show("تمت عملية النسخ الاحتياطي بنجاح");
                }
                else
                {
                    MessageBox.Show(msg);
                }

                loading.Visible = false;
            }
        }
        private bool BackUp(FolderBrowserDialog folder)
        {
            try
            {
                db = new DBAREntities();

                string dbname = db.Database.Connection.Database;
                string dbBackUp = "ARDB" + DateTime.Now.ToString("yyyyMMddHHmm");
                var fullpath = folder.SelectedPath.ToString() + dbBackUp + ".bak";
                string sqlCommand = @"BACKUP DATABASE [{0}] TO  DISK = '" + fullpath + "' WITH NOFORMAT, NOINIT,  NAME = N'DBAR', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
                int path = db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlCommand, dbname, dbBackUp));
                return true;
            }
            catch (Exception ex)
            {
                msg = ex.Message;
                return false;

            }
        } 
    }
}