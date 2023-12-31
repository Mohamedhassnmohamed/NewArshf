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

namespace Arshf.pages
{
    public partial class UsersPage : DevExpress.XtraEditors.XtraUserControl
    {
        // database and tables
        private DBAREntities db;
        TBUSER tbadd;
        //other varable
        int id;
        private bool state;

        public UsersPage()
        {
            InitializeComponent();
            LoadData();
            
        }
        // load data
        public void LoadData()
        {
            // This line of code is generated by Data Source Configuration Wizard
            this.entityInstantFeedbackSource2.GetQueryable += entityInstantFeedbackSource2_GetQueryable;
            // This line of code is generated by Data Source Configuration Wizard
            this.entityInstantFeedbackSource2.DismissQueryable += entityInstantFeedbackSource2_DismissQueryable;
            this.entityInstantFeedbackSource2.Refresh();
        }

        
        //Add
        private void btn_add_Click(object sender, EventArgs e)
        {
            Addpage.AddUser add= new Addpage.AddUser();
            add.btn_add.Text = "اضافة";
            add.id= 0;
            add.page = this;
            add.Show();
        }
        //edit
        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                if (id > 0)
                {
                    // edit
                    Addpage.AddUser add = new Addpage.AddUser();
                    add.btn_add.Text = "تعديل";
                    add.id = id;
                    add.depid = Convert.ToInt32(gridView1.GetFocusedRowCellValue("IDDep"));
                    add.edt_name.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("FullName"));
                    add.edt_username.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("UserName"));
                    add.edt_password.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Password"));
                    add.edt_role.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("UserRole"));
                    add.edt_Dep.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("DepName"));
                    add.page = this;
                    add.Show();

                }
                else
                {
                    MessageBox.Show("لا يوجد بيانات لتعديلها");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("خطأ في العملية ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }
        // delete
        private async void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                if (id > 0)
                {
                   var result= MessageBox.Show("اجراء حذف ", "هل انت متأكد من هذا الحذف ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(result==DialogResult.Yes)
                    {
                        // delete
                        //load
                        loading.Visible = true;
                        tbadd = new TBUSER
                        {
                            ID = id,
                        };
                        var rs = await Task.Run(() => Delete(tbadd));
                        if (rs == true)
                        {
                            LoadData();
                            toastNotificationsManager1.ShowNotification("c8aa9857-a8ac-4d9f-9a9b-19df6074d546");

                        }
                        else
                        {
                            MessageBox.Show("خطأ في الاتصال ", "تأكد من الاتصال بالسيرفر ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        //end
                        loading.Visible = false;
                    }
                    

                }
                else
                {
                    MessageBox.Show("لا يوجد بيانات لحذفها");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في العملية ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Delete Method
        private bool Delete(TBUSER Data)
        {
            try
            {
                db = new DBAREntities();
                db.Entry(Data).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                state = true;
            }
            catch
            {
                state = false;
            }
            return state;
        }
        // print
        private void btn_Print_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        // This event is generated by Data Source Configuration Wizard
        void entityInstantFeedbackSource2_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            // Instantiate a new DataContext
            Arshf.DBAREntities dataContext = new Arshf.DBAREntities();
            // Assign a queryable source to the EntityInstantFeedbackSource
            e.QueryableSource = dataContext.TBUSERS;
            // Assign the DataContext to the Tag property,
            // to dispose of it in the DismissQueryable event handler
            e.Tag = dataContext;
        }

        // This event is generated by Data Source Configuration Wizard
        void entityInstantFeedbackSource2_DismissQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            // Dispose of the DataContext
            ((Arshf.DBAREntities)e.Tag).Dispose();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserID = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));

            //add.depid = Convert.ToInt32(gridView1.GetFocusedRowCellValue("IDDep"));
            Properties.Settings.Default.FullName = Convert.ToString(gridView1.GetFocusedRowCellValue("FullName"));
            Properties.Settings.Default.UserName = Convert.ToString(gridView1.GetFocusedRowCellValue("UserName"));
            //Properties.Settings.Default.UserID = Convert.ToString(gridView1.GetFocusedRowCellValue("Password"));
            Properties.Settings.Default.UserRole = Convert.ToString(gridView1.GetFocusedRowCellValue("UserRole"));
            Properties.Settings.Default.UserDep = Convert.ToString(gridView1.GetFocusedRowCellValue("DepName"));
            Properties.Settings.Default.Save();
        }
    }
}
