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

namespace Arshf.PL
{
    public partial class ArchiveFileForm : DevExpress.XtraEditors.XtraForm
    {
        //Database
        TBArchiveFile tbadd;
        DBAREntities db;
        // other var
        public int ArciveID;
        private int id;
        private bool state;
        
        //public 
        public ArchiveFileForm()
        {
            InitializeComponent();
            ArciveID = Convert.ToInt32(lb_id.Text);

            LoadData();


        }
        public void LoadData()
        {
            // This line of code is generated by Data Source Configuration Wizard
            this.entityInstantFeedbackSource1.GetQueryable += entityInstantFeedbackSource1_GetQueryable;
            // This line of code is generated by Data Source Configuration Wizard
            this.entityInstantFeedbackSource1.DismissQueryable += entityInstantFeedbackSource1_DismissQueryable;
            this.entityInstantFeedbackSource1.Refresh();
        }

        // This event is generated by Data Source Configuration Wizard
        void entityInstantFeedbackSource1_GetQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            // Instantiate a new DataContext
            Arshf.DBAREntities dataContext = new Arshf.DBAREntities();
            // Assign a queryable source to the EntityInstantFeedbackSource
            e.QueryableSource = dataContext.TBArchiveFiles.Where(x=>x.IDArchive==ArciveID)
                .Select(x=>new {x.ID,x.IDArchive,x.AddDate,x.ArchDate,
                    x.ArchDep,x.ArchDetails,x.ArchNumber,
                    x.ArchReciver,x.ArchSender,x.ArchTitle });
            
            e.Tag = dataContext;
        }

        // This event is generated by Data Source Configuration Wizard
        void entityInstantFeedbackSource1_DismissQueryable(object sender, DevExpress.Data.Linq.GetQueryableEventArgs e)
        {
            // Dispose of the DataContext
            ((Arshf.DBAREntities)e.Tag).Dispose();
        }

        private void lb_archdep_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Addpage.AddFile add = new Addpage.AddFile();
            add.btn_add.Text = "اضافة";
            add.id = 0;
            add.IDArch = Convert.ToInt32(lb_id.Text);
            add.ArchDep = lb_archdep.Text;
            add.page = this;
            add.Show();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                if (id > 0)
                {
                    // edit
                    Addpage.AddFile add = new Addpage.AddFile();
                    add.btn_add.Text = "تعديل";
                    add.id = id;
                    add.IDArch = Convert.ToInt32(lb_id.Text);
                    add.ArchDep = lb_archdep.Text;
                    add.edt_number.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("ArchNumber"));
                    add.edt_reciver.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("ArchReciver"));
                    add.edt_sender.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("ArchSender"));
                    add.edt_title.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("ArchTitle"));
                   //add.edt = Convert.ToString(gridView1.GetFocusedRowCellValue("ArchNumber"));
                   // add.edt_date.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("ArchDate"));
                    add.page = this;
                    add.Show();

                }
                else
                {
                    MessageBox.Show("لا يوجد بيانات لتعديلها");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في العملية ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                if (id > 0)
                {
                    var result = MessageBox.Show("اجراء حذف ", "هل انت متأكد من هذا الحذف ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // delete
                        //load
                        loading.Visible = true;
                        tbadd = new TBArchiveFile
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
        private bool Delete(TBArchiveFile Data)
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

        private void btn_Print_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void btn_showfiles_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));
                if (id > 0)
                {


                    PL.ShowFiles files = new ShowFiles();
                    files.id = id;
                    files.Show();


                }
                else
                {
                    MessageBox.Show("لا يوجد بيانات ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ في العملية ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}