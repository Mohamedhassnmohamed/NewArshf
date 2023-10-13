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
using System.IO;
namespace Arshf.Addpage
{
    public partial class AddFile : DevExpress.XtraEditors.XtraForm
    {
        //Database and tables
        DBAREntities db;
        TBArchiveFile tbadd;
        //other variable
        public int id;
        public int IDArch;
        public string ArchDep;
        public PL.ArchiveFileForm page;
        bool state;
        private string[] FileNames;

        public AddFile()
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
            if(edt_title.Text== "" || FileNames==null)
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

                    tbadd = new TBArchiveFile();
                    tbadd.ArchDate = edt_date.Value;
                    tbadd.ArchDep = ArchDep;
                    tbadd.ArchDetails = edt_detailes.Text;
                    tbadd.ArchNumber = edt_number.Text;
                    tbadd.ArchReciver = edt_reciver.Text;
                    tbadd.ArchSender = edt_sender.Text;
                    tbadd.ArchTitle = edt_title.Text;
                    tbadd.IDArchive = IDArch;
                    if(FileNames.Length==1)
                    {
                        tbadd.FileName1 = Path.GetFileNameWithoutExtension(FileNames[0]);
                        tbadd.FileExt1 = Path.GetExtension(FileNames[0]);
                        tbadd.FileSize1 = (double)File.ReadAllBytes(FileNames[0]).Length;
                        tbadd.FileFile1 = File.ReadAllBytes(FileNames[0]);

                    }
                    if (FileNames.Length == 2)
                    {
                        tbadd.FileName1 = Path.GetFileNameWithoutExtension(FileNames[0]);
                        tbadd.FileExt1 = Path.GetExtension(FileNames[0]);
                        tbadd.FileSize1 = (double)File.ReadAllBytes(FileNames[0]).Length;
                        tbadd.FileFile1 = File.ReadAllBytes(FileNames[0]);
                        
                        
                         tbadd.FileName2 = Path.GetFileNameWithoutExtension(FileNames[1]);
                          tbadd.FileExt2 = Path.GetExtension(FileNames[1]);
                          tbadd.FileSize2 = (double)File.ReadAllBytes(FileNames[1]).Length;
                          tbadd.FileFile2 = File.ReadAllBytes(FileNames[1]);

                        

                    }
                    if (FileNames.Length == 3)
                    {
                        tbadd.FileName1 = Path.GetFileNameWithoutExtension(FileNames[0]);
                        tbadd.FileExt1 = Path.GetExtension(FileNames[0]);
                        tbadd.FileSize1 = (double)File.ReadAllBytes(FileNames[0]).Length;
                        tbadd.FileFile1 = File.ReadAllBytes(FileNames[0]);


                        tbadd.FileName2 = Path.GetFileNameWithoutExtension(FileNames[1]);
                        tbadd.FileExt2 = Path.GetExtension(FileNames[1]);
                        tbadd.FileSize2 = (double)File.ReadAllBytes(FileNames[1]).Length;
                        tbadd.FileFile2 = File.ReadAllBytes(FileNames[1]);


                        tbadd.FileName3 = Path.GetFileNameWithoutExtension(FileNames[2]);
                        tbadd.FileExt3 = Path.GetExtension(FileNames[2]);
                        tbadd.FileSize3 = (double)File.ReadAllBytes(FileNames[2]).Length;
                        tbadd.FileFile3 = File.ReadAllBytes(FileNames[2]);



                    }
                    if (FileNames.Length == 4)
                    {
                        tbadd.FileName1 = Path.GetFileNameWithoutExtension(FileNames[0]);
                        tbadd.FileExt1 = Path.GetExtension(FileNames[0]);
                        tbadd.FileSize1 = (double)File.ReadAllBytes(FileNames[0]).Length;
                        tbadd.FileFile1 = File.ReadAllBytes(FileNames[0]);


                        tbadd.FileName2 = Path.GetFileNameWithoutExtension(FileNames[1]);
                        tbadd.FileExt2 = Path.GetExtension(FileNames[1]);
                        tbadd.FileSize2 = (double)File.ReadAllBytes(FileNames[1]).Length;
                        tbadd.FileFile2 = File.ReadAllBytes(FileNames[1]);


                        tbadd.FileName3 = Path.GetFileNameWithoutExtension(FileNames[2]);
                        tbadd.FileExt3 = Path.GetExtension(FileNames[2]);
                        tbadd.FileSize3 = (double)File.ReadAllBytes(FileNames[2]).Length;
                        tbadd.FileFile3 = File.ReadAllBytes(FileNames[2]);


                        tbadd.FileName4 = Path.GetFileNameWithoutExtension(FileNames[3]);
                        tbadd.FileExt4 = Path.GetExtension(FileNames[3]);
                        tbadd.FileSize4 = (double)File.ReadAllBytes(FileNames[3]).Length;
                        tbadd.FileFile4 = File.ReadAllBytes(FileNames[3]);



                    }
                    if (FileNames.Length == 5)
                    {
                        tbadd.FileName1 = Path.GetFileNameWithoutExtension(FileNames[0]);
                        tbadd.FileExt1 = Path.GetExtension(FileNames[0]);
                        tbadd.FileSize1 = (double)File.ReadAllBytes(FileNames[0]).Length;
                        tbadd.FileFile1 = File.ReadAllBytes(FileNames[0]);


                        tbadd.FileName2 = Path.GetFileNameWithoutExtension(FileNames[1]);
                        tbadd.FileExt2 = Path.GetExtension(FileNames[1]);
                        tbadd.FileSize2 = (double)File.ReadAllBytes(FileNames[1]).Length;
                        tbadd.FileFile2 = File.ReadAllBytes(FileNames[1]);


                        tbadd.FileName3 = Path.GetFileNameWithoutExtension(FileNames[2]);
                        tbadd.FileExt3 = Path.GetExtension(FileNames[2]);
                        tbadd.FileSize3 = (double)File.ReadAllBytes(FileNames[2]).Length;
                        tbadd.FileFile3 = File.ReadAllBytes(FileNames[2]);

                        tbadd.FileName4 = Path.GetFileNameWithoutExtension(FileNames[3]);
                        tbadd.FileExt4 = Path.GetExtension(FileNames[3]);
                        tbadd.FileSize4 = (double)File.ReadAllBytes(FileNames[3]).Length;
                        tbadd.FileFile4 = File.ReadAllBytes(FileNames[3]);

                        tbadd.FileName5 = Path.GetFileNameWithoutExtension(FileNames[4]);
                        tbadd.FileExt5 = Path.GetExtension(FileNames[4]);
                        tbadd.FileSize5 = (double)File.ReadAllBytes(FileNames[4]).Length;
                        tbadd.FileFile5 = File.ReadAllBytes(FileNames[4]);


                    }
                }
                //edit
                else
                {
                    tbadd = new TBArchiveFile();
                    tbadd.ArchDate = edt_date.Value;
                    tbadd.ArchDep = ArchDep;
                    tbadd.ArchDetails = edt_detailes.Text;
                    tbadd.ArchNumber = edt_number.Text;
                    tbadd.ArchReciver = edt_reciver.Text;
                    tbadd.ArchSender = edt_sender.Text;
                    tbadd.ArchTitle = edt_title.Text;
                    tbadd.IDArchive = IDArch;
                    tbadd.ID = id;
                    if (FileNames.Length == 1)
                    {
                        tbadd.FileName1 = Path.GetFileNameWithoutExtension(FileNames[0]);
                        tbadd.FileExt1 = Path.GetExtension(FileNames[0]);
                        tbadd.FileSize1 = (double)File.ReadAllBytes(FileNames[0]).Length;
                        tbadd.FileFile1 = File.ReadAllBytes(FileNames[0]);

                    }
                    if (FileNames.Length == 2)
                    {
                        tbadd.FileName1 = Path.GetFileNameWithoutExtension(FileNames[0]);
                        tbadd.FileExt1 = Path.GetExtension(FileNames[0]);
                        tbadd.FileSize1 = (double)File.ReadAllBytes(FileNames[0]).Length;
                        tbadd.FileFile1 = File.ReadAllBytes(FileNames[0]);


                        tbadd.FileName2 = Path.GetFileNameWithoutExtension(FileNames[1]);
                        tbadd.FileExt2 = Path.GetExtension(FileNames[1]);
                        tbadd.FileSize2 = (double)File.ReadAllBytes(FileNames[1]).Length;
                        tbadd.FileFile2 = File.ReadAllBytes(FileNames[1]);



                    }
                    if (FileNames.Length == 3)
                    {
                        tbadd.FileName1 = Path.GetFileNameWithoutExtension(FileNames[0]);
                        tbadd.FileExt1 = Path.GetExtension(FileNames[0]);
                        tbadd.FileSize1 = (double)File.ReadAllBytes(FileNames[0]).Length;
                        tbadd.FileFile1 = File.ReadAllBytes(FileNames[0]);


                        tbadd.FileName2 = Path.GetFileNameWithoutExtension(FileNames[1]);
                        tbadd.FileExt2 = Path.GetExtension(FileNames[1]);
                        tbadd.FileSize2 = (double)File.ReadAllBytes(FileNames[1]).Length;
                        tbadd.FileFile2 = File.ReadAllBytes(FileNames[1]);


                        tbadd.FileName3 = Path.GetFileNameWithoutExtension(FileNames[2]);
                        tbadd.FileExt3 = Path.GetExtension(FileNames[2]);
                        tbadd.FileSize3 = (double)File.ReadAllBytes(FileNames[2]).Length;
                        tbadd.FileFile3 = File.ReadAllBytes(FileNames[2]);



                    }
                    if (FileNames.Length == 4)
                    {
                        tbadd.FileName1 = Path.GetFileNameWithoutExtension(FileNames[0]);
                        tbadd.FileExt1 = Path.GetExtension(FileNames[0]);
                        tbadd.FileSize1 = (double)File.ReadAllBytes(FileNames[0]).Length;
                        tbadd.FileFile1 = File.ReadAllBytes(FileNames[0]);


                        tbadd.FileName2 = Path.GetFileNameWithoutExtension(FileNames[1]);
                        tbadd.FileExt2 = Path.GetExtension(FileNames[1]);
                        tbadd.FileSize2 = (double)File.ReadAllBytes(FileNames[1]).Length;
                        tbadd.FileFile2 = File.ReadAllBytes(FileNames[1]);


                        tbadd.FileName3 = Path.GetFileNameWithoutExtension(FileNames[2]);
                        tbadd.FileExt3 = Path.GetExtension(FileNames[2]);
                        tbadd.FileSize3 = (double)File.ReadAllBytes(FileNames[2]).Length;
                        tbadd.FileFile3 = File.ReadAllBytes(FileNames[2]);


                        tbadd.FileName4 = Path.GetFileNameWithoutExtension(FileNames[3]);
                        tbadd.FileExt4 = Path.GetExtension(FileNames[3]);
                        tbadd.FileSize4 = (double)File.ReadAllBytes(FileNames[3]).Length;
                        tbadd.FileFile4 = File.ReadAllBytes(FileNames[3]);



                    }
                    if (FileNames.Length == 5)
                    {
                        tbadd.FileName1 = Path.GetFileNameWithoutExtension(FileNames[0]);
                        tbadd.FileExt1 = Path.GetExtension(FileNames[0]);
                        tbadd.FileSize1 = (double)File.ReadAllBytes(FileNames[0]).Length;
                        tbadd.FileFile1 = File.ReadAllBytes(FileNames[0]);


                        tbadd.FileName2 = Path.GetFileNameWithoutExtension(FileNames[1]);
                        tbadd.FileExt2 = Path.GetExtension(FileNames[1]);
                        tbadd.FileSize2 = (double)File.ReadAllBytes(FileNames[1]).Length;
                        tbadd.FileFile2 = File.ReadAllBytes(FileNames[1]);


                        tbadd.FileName3 = Path.GetFileNameWithoutExtension(FileNames[2]);
                        tbadd.FileExt3 = Path.GetExtension(FileNames[2]);
                        tbadd.FileSize3 = (double)File.ReadAllBytes(FileNames[2]).Length;
                        tbadd.FileFile3 = File.ReadAllBytes(FileNames[2]);

                        tbadd.FileName4 = Path.GetFileNameWithoutExtension(FileNames[3]);
                        tbadd.FileExt4 = Path.GetExtension(FileNames[3]);
                        tbadd.FileSize4 = (double)File.ReadAllBytes(FileNames[3]).Length;
                        tbadd.FileFile4 = File.ReadAllBytes(FileNames[3]);

                        tbadd.FileName5 = Path.GetFileNameWithoutExtension(FileNames[4]);
                        tbadd.FileExt5 = Path.GetExtension(FileNames[4]);
                        tbadd.FileSize5 = (double)File.ReadAllBytes(FileNames[4]).Length;
                        tbadd.FileFile5 = File.ReadAllBytes(FileNames[4]);


                    }
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
        private bool AddorEdit(TBArchiveFile Data)
        {
            try
            {
                db = new DBAREntities();
                db.Set<TBArchiveFile>().AddOrUpdate(Data);
                db.SaveChanges();
                state = true;
            }
            catch
            {
                state = false;
            }
            return state;
        }

        private void btn_selectfiles_Click(object sender, EventArgs e)
        {
            try
            {
                var ofd = new OpenFileDialog();
                ofd.Multiselect = true;
                ofd.Title = "اختر خمسة ملفات لحد اقصي مع خمسة ميجا حجم لكل ملف";
                var rs = ofd.ShowDialog();
                if(rs==DialogResult.OK)
                {
                    FileNames = ofd.FileNames;
                    btn_selectfiles.Text = "تم اختيار الملفات ,انقر لتغيرها";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}