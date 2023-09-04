using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
namespace EntrySystemReport
{
    public partial class Reports : Form
    {
        public readonly string ServerAdress = ConfigurationManager.AppSettings["ServerAdress"];
        public readonly string DatabaseName = ConfigurationManager.AppSettings["DatabaseName"];
        public readonly string UsrName = ConfigurationManager.AppSettings["UsrName"];
        public readonly string Pw = ConfigurationManager.AppSettings["Pw"];
        SqlConnection baglanti;
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlCommand komut;

        public Reports()
        {
            InitializeComponent();
        }
        public void griddoldur()
        {
            baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
            da = new SqlDataAdapter($"Select * From EntrySystem.DBO.EntryReport('{dtStDate.Value.ToString("MM/dd/yyyy 00:00:01")}','{dtEndDate.Value.ToString("MM/dd/yyyy 23:59:59")}')", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Personel");
            DGVReport.DataSource = ds.Tables["Personel"];
            baglanti.Close();
            //DGVReport.Columns[0].Visible = false;
            DGVReport.Columns[6].Visible = false;
            //DGVReport.Columns[3].HeaderText = "Name";
            //DGVReport.Columns[4].HeaderText = "Entry Time";
            //DGVReport.Columns[5].HeaderText = "Exit Time";
            DGVReport.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGVReport.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DGVReport.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGVReport.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DGVReport.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnGetToday_Click(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            dtStDate.Value = thisDay;
            dtEndDate.Value = thisDay;
            griddoldur();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            griddoldur();
        }


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = "Giriş Çıkışlar.xls";
                savefile.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (savefile.ShowDialog() == DialogResult.OK)
                    {
                        //using (StreamWriter sw = new StreamWriter(savefile.FileName))
                        //    sw.WriteLine("Hello World!");
                        StreamWriter wr = new StreamWriter(savefile.FileName, false, Encoding.UTF32);
                        for (int i = 0; i < ds.Tables[0].Columns.Count; i++)
                        {
                            wr.Write(ds.Tables[0].Columns[i].ToString().ToUpper() + "\t");
                        }

                        wr.WriteLine();

                        //write rows to excel file
                        for (int i = 0; i < (ds.Tables[0].Rows.Count); i++)
                        {
                            for (int j = 0; j < ds.Tables[0].Columns.Count; j++)
                            {
                                if (ds.Tables[0].Rows[i][j] != null)
                                {
                                    wr.Write(Convert.ToString(ds.Tables[0].Rows[i][j]) + "\t");
                                }
                                else
                                {
                                    wr.Write("\t");
                                }
                            }
                            //go to next line
                            wr.WriteLine();
                        }
                        //close file
                        wr.Close();
                        MetroMessageBox.Show(this, "Excell dosyanız kaydedilmiştir. Dosya adı :  " + savefile.FileName, "Başarıyla Kaydedildi !", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Aktarılacak bir kayıt bulunamadı...", "Aktarım Yapılamadı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            grpEdit.Visible = false;
        }

        private void btnAllValues_Click(object sender, EventArgs e)
        {
            dtStDate.Value = Convert.ToDateTime("01/01/2000 01:00:00");
            dtEndDate.Value = DateTime.Today;
            griddoldur();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (btnDuzenle.Text == "Düzenleme Yap")
            {
                btnDuzenle.Text = "Düzenlemeyi Bitir";
                bunifuCustomLabel1.Visible = false;
                bunifuCustomLabel2.Visible = false;
                dtStDate.Visible = false;
                dtEndDate.Visible = false;
                grpSearch.Text = "Düzenleme Modu";
                grpEdit.Visible = true;
            }
            else
            {
                btnDuzenle.Text = "Düzenleme Yap";
                grpEdit.Visible = false;
                bunifuCustomLabel1.Visible = true;
                bunifuCustomLabel2.Visible = true;
                dtStDate.Visible = true;
                dtEndDate.Visible = true;
                grpSearch.Text = "Arama";
            }
                
        }

        private void btnGetValues_Click(object sender, EventArgs e)
        {
            try
            {
                string query = SetChangedValueQuery();
                if (string.IsNullOrEmpty(query))
                {
                    MetroMessageBox.Show(this, "Lütfen kayıt değiştirdikten sonra veritabanına kaydetmeye çalışınız.", "Kayıt güncellenemedi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    baglanti = new SqlConnection("Server=" + ServerAdress + ";Database=" + DatabaseName + ";User Id=" + UsrName + ";Password=" + Pw + ";");
                    string cmdTxt = $"UPDATE dbo.EntryLog SET {query} Where ID={DGVReport.CurrentRow.Cells[6].Value}";
                    komut = new SqlCommand(cmdTxt, baglanti);
                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    griddoldur();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("This record cannot be deleted", "Delete Stopped", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string SetChangedValueQuery()
        {
            string query = "";

            if(DGVReport.CurrentRow.Cells[1].Value.ToString() != dtEditEntry.Value.ToString("dd-MM-yyyy")) // EntryDate not equal
                query = $"EntryDate=DATEADD(day,DATEDIFF(day, EntryDate, '{dtEditEntry.Value.ToString("yyyyMMdd")}'),EntryDate)";
            if (txtEntryTime.Text != DGVReport.CurrentRow.Cells[2].Value.ToString())
                query += $" EntryDate = convert(char(10), EntryDate, 126) + 'T{txtEntryTime.Text}'";
            if (DGVReport.CurrentRow.Cells[3].Value.ToString() != dtEditExit.Value.ToString("dd-MM-yyyy") && DGVReport.CurrentRow.Cells[3].Value.ToString() != "")
                query += $" OutDate=DATEADD(day,DATEDIFF(day, OutDate, '{dtEditExit.Value.ToString("yyyyMMdd")}'),OutDate)";
            if (txtExitTime.Text != DGVReport.CurrentRow.Cells[4].Value.ToString() && DGVReport.CurrentRow.Cells[4].Value.ToString() !="")
                query += $" OutDate = convert(char(10), OutDate, 126) + 'T{txtExitTime.Text}'";
            return query;
        }

        private void DGVReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(btnDuzenle.Text== "Düzenlemeyi Bitir")
            {
                lblPersonal.Text = DGVReport.CurrentRow.Cells[0].Value.ToString();
                dtEditEntry.Text = DGVReport.CurrentRow.Cells[1].Value.ToString();
                txtEntryTime.Text = DGVReport.CurrentRow.Cells[2].Value.ToString();
                dtEditExit.Text = DGVReport.CurrentRow.Cells[3].Value.ToString();
                txtExitTime.Text = DGVReport.CurrentRow.Cells[4].Value.ToString();
            }
        }
    }
}
