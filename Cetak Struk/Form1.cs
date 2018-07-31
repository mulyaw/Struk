using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Net;
using System.IO;
using System.Web;
using System.Text.RegularExpressions;
using System.Threading;
using HtmlAgilityPack;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillListbox();
        }

        void FillListbox()
        {
            foreach (var p in PrinterSettings.InstalledPrinters)
            {
                listBox1.Items.Add(p);
            }
        }

        public static class printer
        {
            [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
            public static extern bool SetDefaultPrinter(string printer);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtdatetime.Text = DateTime.Now.ToString("HH:mm:ss dddd/MM/yyy");        
        }

        private void Cetak_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tb1.Text, "[^0-9\r\n]+", RegexOptions.IgnoreCase | RegexOptions.Multiline))
            {
                MessageBox.Show("Only Number Allowed.");
                tb1.Text = tb1.Text.Remove(tb1.Text.Length - 1);
            }
            
            ToolTip tt = new ToolTip();
            tt.IsBalloon = true;
            tt.Show(string.Empty, tb1, 0);
            int v = 1500;
            tt.Show("Untuk cetak beberapa IDPEL, Silahkan pisah dengan ENTER", tb1, v);

            /*TextBox tb = (TextBox)sender;
            int VisibleTime = 1000;
            ToolTip t = new ToolTip();
            t.Show("HANYA ANGKA!", tb, 60, -25, VisibleTime);
            //tb,X,Y, VisibleTime);*/
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string pname = listBox1.SelectedItem.ToString();
            printer.SetDefaultPrinter(pname);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (tb1.Text == "")
                MessageBox.Show("SILAHKAN MASUKAN IDPEL");
            else if (cb1.Text == "")
                MessageBox.Show("SILAHKAN PILIH TIPE PEMBAYARAN");


            if (cb1.Text == "PLN TAGIHAN")            
                cb1.Text = "1";
            
            else if (cb1.Text == "PLN TOKEN")
                cb1.Text = "2";

            else if (cb1.Text == "PLN NON TAGIHAN")
                cb1.Text = "3";

            else if (cb1.Text == "TELKOM GROUP")
                cb1.Text = "4";

            else if (cb1.Text == "MULTIFINANCE")
                cb1.Text = "5";

            else if (cb1.Text == "PDAM")
                cb1.Text = "6";

            else if (cb1.Text == "TV TAGIHAN")
                cb1.Text = "7";

            else if (cb1.Text == "TAGIHAN SELULER")
                cb1.Text = "8";

            else if (cb1.Text == "BPJS KESEHATAN")
                cb1.Text = "9";


            //string idpel = tb1.Text;
            string tanggal = dtm1.Text;
            string tipe = cb1.Text;
            string[] allLines = tb1.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            int count = 0; //hitung jumlah data
            foreach (string idpel in allLines)
            {
                string uri = "http://117.74.120.110/cetak/struk.php";
                string parameter = "idpel=" + idpel;
                parameter += "&tanggal=" + tanggal;
                parameter += "&tipe=" + tipe;

                using (WebClient wc = new WebClient())
                {
                    try
                    {
                        wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                        string HtmlResult = wc.UploadString(uri, parameter);
                        //parsing html
                        HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
                        doc.LoadHtml(HtmlResult);
                        foreach (HtmlNode struk in doc.DocumentNode.SelectNodes("//*[@id='cetakstruk']/pre"))
                        rtb1.AppendText(Environment.NewLine + (struk.InnerHtml));
                        {

                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("DATA TIDAK DITEMUKAN");   //"pesan error" + err);  (err.ToString());
                    }
                }
                //hasil hitung jumlah data
                count++;
                txtjumlah.Text = ("Jumlah Data: " + count+"");
                //MessageBox.Show ("Total Data :" + count+ "");
            }
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (listBox2.Text == "Regular Paper(F4,A4,etc)")
                e.Graphics.DrawString(rtb1.Text, new Font("Consolas", 8, FontStyle.Regular), Brushes.Black, new PointF(5, 3));
            else if (listBox2.Text == "Continuous Paper(kertas struk)")
                e.Graphics.DrawString(rtb1.Text, new Font("Consolas", 9, FontStyle.Regular), Brushes.Black, new PointF(5, 3));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox2.Text == "")
                MessageBox.Show("SILAHKAN PILIH JENIS KERTAS");

            if (listBox2.Text == "Regular Paper(F4,A4,etc)")
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("custom", 925, 1155);
                printPreviewDialog1.ShowDialog();
            }
            else if (cb2.Text == "1")
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("custom", 925, 240);
                printPreviewDialog1.ShowDialog();
            }
            else if (cb2.Text == "2")
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("custom", 925, 460);
                printPreviewDialog1.ShowDialog();
            }
            else if (cb2.Text == "3")
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("custom", 925, 680);
                printPreviewDialog1.ShowDialog();
            }
            else if (cb2.Text == "4")
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("custom", 925, 900);
                printPreviewDialog1.ShowDialog();
            }
            else if (cb2.Text == "5")
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("custom", 925, 1120);
                printPreviewDialog1.ShowDialog();
            }
            else if (cb2.Text == "<=10")
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("custom", 925, 2400);
                printPreviewDialog1.ShowDialog();
            }
            else if (cb2.Text == "<=15")
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("custom", 925, 3600);
                printPreviewDialog1.ShowDialog();
            }
            else if (cb2.Text == "<=20")
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("custom", 925, 4800);
                printPreviewDialog1.ShowDialog();
            }
            else if (cb2.Text == "<=25")
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("custom", 925, 6000);
                printPreviewDialog1.ShowDialog();
            }
            else if (cb2.Text == "<=30")
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("custom", 925, 7200);
                printPreviewDialog1.ShowDialog();
            }
            else if (cb2.Text == "<=35")
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("custom", 925, 8400);
                printPreviewDialog1.ShowDialog();
            }
            else if (cb2.Text == "<=40")
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("custom", 925, 9600);
                printPreviewDialog1.ShowDialog();
            }
            else if (cb2.Text == "<=45")
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("custom", 925, 10800);
                printPreviewDialog1.ShowDialog();
            }
            else if (cb2.Text == "<=50")
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("custom", 925, 12000);
                printPreviewDialog1.ShowDialog();
            }
            /*else if (listBox2.Text == "Continuous Paper(kertas struk)")
            {
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("custom", 925, 240);
                printPreviewDialog1.ShowDialog();
            }*/


            //if (printPreviewDialog1.ShowDialog() == DialogResult.OK) ;
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            rtb1.Clear();
            txtjumlah.Text = "";
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox2.Text == "Continuous Paper(kertas struk)")
                MessageBox.Show("Silahkan pilih jumlah data/struk yang akan dicetak");

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (listBox3.Text == "2")
               // printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("custom", 925, 300);
        }
    }
    }

