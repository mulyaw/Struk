namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Cetak = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttglbayar = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.txtidpel = new System.Windows.Forms.Label();
            this.dtm1 = new System.Windows.Forms.DateTimePicker();
            this.btnshow = new System.Windows.Forms.Button();
            this.txtproduk = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.btncetak = new System.Windows.Forms.Button();
            this.rtb1 = new System.Windows.Forms.RichTextBox();
            this.Setting = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtprintselect = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtpaperselect = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.txtdatetime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtjumlah = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Cetak.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Setting.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Cetak);
            this.tabControl1.Controls.Add(this.Setting);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(857, 367);
            this.tabControl1.TabIndex = 1;
            // 
            // Cetak
            // 
            this.Cetak.Controls.Add(this.groupBox2);
            this.Cetak.Controls.Add(this.btnreset);
            this.Cetak.Controls.Add(this.btncetak);
            this.Cetak.Controls.Add(this.rtb1);
            this.Cetak.Location = new System.Drawing.Point(4, 22);
            this.Cetak.Name = "Cetak";
            this.Cetak.Padding = new System.Windows.Forms.Padding(3);
            this.Cetak.Size = new System.Drawing.Size(849, 341);
            this.Cetak.TabIndex = 0;
            this.Cetak.Text = "Cetak";
            this.Cetak.UseVisualStyleBackColor = true;
            this.Cetak.Click += new System.EventHandler(this.Cetak_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txttglbayar);
            this.groupBox2.Controls.Add(this.tb1);
            this.groupBox2.Controls.Add(this.txtidpel);
            this.groupBox2.Controls.Add(this.dtm1);
            this.groupBox2.Controls.Add(this.btnshow);
            this.groupBox2.Controls.Add(this.txtproduk);
            this.groupBox2.Controls.Add(this.cb1);
            this.groupBox2.Location = new System.Drawing.Point(5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(840, 39);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // txttglbayar
            // 
            this.txttglbayar.AutoSize = true;
            this.txttglbayar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttglbayar.Location = new System.Drawing.Point(276, 16);
            this.txttglbayar.Name = "txttglbayar";
            this.txttglbayar.Size = new System.Drawing.Size(70, 13);
            this.txttglbayar.TabIndex = 2;
            this.txttglbayar.Text = "TGL BAYAR:";
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(53, 11);
            this.tb1.Multiline = true;
            this.tb1.Name = "tb1";
            this.tb1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb1.Size = new System.Drawing.Size(184, 23);
            this.tb1.TabIndex = 0;
            this.tb1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtidpel
            // 
            this.txtidpel.AutoSize = true;
            this.txtidpel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidpel.Location = new System.Drawing.Point(8, 15);
            this.txtidpel.Name = "txtidpel";
            this.txtidpel.Size = new System.Drawing.Size(41, 13);
            this.txtidpel.TabIndex = 1;
            this.txtidpel.Text = "IDPEL:";
            // 
            // dtm1
            // 
            this.dtm1.CustomFormat = "yyyy-MM-dd";
            this.dtm1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtm1.Location = new System.Drawing.Point(351, 12);
            this.dtm1.Name = "dtm1";
            this.dtm1.Size = new System.Drawing.Size(76, 20);
            this.dtm1.TabIndex = 3;
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(732, 10);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(90, 23);
            this.btnshow.TabIndex = 6;
            this.btnshow.Text = "Tampilkan";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btn1_Click);
            // 
            // txtproduk
            // 
            this.txtproduk.AutoSize = true;
            this.txtproduk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproduk.Location = new System.Drawing.Point(474, 16);
            this.txtproduk.Name = "txtproduk";
            this.txtproduk.Size = new System.Drawing.Size(56, 13);
            this.txtproduk.TabIndex = 4;
            this.txtproduk.Text = "PRODUK:";
            // 
            // cb1
            // 
            this.cb1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "PLN TAGIHAN",
            "PLN TOKEN",
            "PLN NON TAGIHAN",
            "TELKOM GROUP",
            "MULTIFINANCE",
            "PDAM",
            "TV TAGIHAN",
            "TAGIHAN SELULER",
            "BPJS KESEHATAN"});
            this.cb1.Location = new System.Drawing.Point(535, 12);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(164, 21);
            this.cb1.TabIndex = 5;
            this.cb1.SelectedIndexChanged += new System.EventHandler(this.cb1_SelectedIndexChanged);
            // 
            // btnreset
            // 
            this.btnreset.Location = new System.Drawing.Point(636, 308);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(90, 23);
            this.btnreset.TabIndex = 9;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btncetak
            // 
            this.btncetak.Location = new System.Drawing.Point(738, 308);
            this.btncetak.Name = "btncetak";
            this.btncetak.Size = new System.Drawing.Size(90, 23);
            this.btncetak.TabIndex = 8;
            this.btncetak.Text = "Cetak";
            this.btncetak.UseVisualStyleBackColor = true;
            this.btncetak.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtb1
            // 
            this.rtb1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtb1.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb1.Location = new System.Drawing.Point(3, 51);
            this.rtb1.Name = "rtb1";
            this.rtb1.ReadOnly = true;
            this.rtb1.Size = new System.Drawing.Size(843, 245);
            this.rtb1.TabIndex = 7;
            this.rtb1.Text = "";
            // 
            // Setting
            // 
            this.Setting.Controls.Add(this.groupBox1);
            this.Setting.Location = new System.Drawing.Point(4, 22);
            this.Setting.Name = "Setting";
            this.Setting.Padding = new System.Windows.Forms.Padding(3);
            this.Setting.Size = new System.Drawing.Size(849, 341);
            this.Setting.TabIndex = 1;
            this.Setting.Text = "Settng";
            this.Setting.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtprintselect);
            this.groupBox1.Controls.Add(this.listBox2);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.txtpaperselect);
            this.groupBox1.Location = new System.Drawing.Point(19, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 179);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // cb2
            // 
            this.cb2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cb2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb2.FormattingEnabled = true;
            this.cb2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "<=10",
            "<=15",
            "<=20",
            "<=25",
            "<=30",
            "<=35",
            "<=40",
            "<=45",
            "<=50"});
            this.cb2.Location = new System.Drawing.Point(365, 112);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(54, 21);
            this.cb2.TabIndex = 5;
            this.cb2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Jumlah Data/Struk :";
            // 
            // txtprintselect
            // 
            this.txtprintselect.AutoSize = true;
            this.txtprintselect.Location = new System.Drawing.Point(7, 29);
            this.txtprintselect.Name = "txtprintselect";
            this.txtprintselect.Size = new System.Drawing.Size(65, 13);
            this.txtprintselect.TabIndex = 0;
            this.txtprintselect.Text = "Pilih Printer :";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "Regular Paper(F4,A4,etc)",
            "Continuous Paper(kertas struk)"});
            this.listBox2.Location = new System.Drawing.Point(84, 100);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(164, 43);
            this.listBox2.TabIndex = 3;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(85, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(271, 43);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtpaperselect
            // 
            this.txtpaperselect.AutoSize = true;
            this.txtpaperselect.Location = new System.Drawing.Point(7, 100);
            this.txtpaperselect.Name = "txtpaperselect";
            this.txtpaperselect.Size = new System.Drawing.Size(70, 13);
            this.txtpaperselect.TabIndex = 2;
            this.txtpaperselect.Text = "Jenis Kertas :";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // txtdatetime
            // 
            this.txtdatetime.AutoSize = true;
            this.txtdatetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdatetime.Location = new System.Drawing.Point(690, 369);
            this.txtdatetime.Name = "txtdatetime";
            this.txtdatetime.Size = new System.Drawing.Size(55, 15);
            this.txtdatetime.TabIndex = 2;
            this.txtdatetime.Text = "datetime";
            this.txtdatetime.Click += new System.EventHandler(this.label3_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Form1_Load);
            // 
            // txtjumlah
            // 
            this.txtjumlah.AutoSize = true;
            this.txtjumlah.Location = new System.Drawing.Point(8, 371);
            this.txtjumlah.Name = "txtjumlah";
            this.txtjumlah.Size = new System.Drawing.Size(10, 13);
            this.txtjumlah.TabIndex = 11;
            this.txtjumlah.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(862, 387);
            this.Controls.Add(this.txtjumlah);
            this.Controls.Add(this.txtdatetime);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cetak Struk";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.Cetak.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Setting.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Cetak;
        private System.Windows.Forms.TabPage Setting;
        private System.Windows.Forms.Label txttglbayar;
        private System.Windows.Forms.Label txtidpel;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.DateTimePicker dtm1;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Label txtproduk;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label txtprintselect;
        private System.Windows.Forms.RichTextBox rtb1;
        private System.Windows.Forms.Button btncetak;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label txtpaperselect;
        private System.Windows.Forms.Label txtdatetime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label txtjumlah;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb2;
    }
}

