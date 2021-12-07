
namespace mfl
{
    partial class serbest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serbest));
            this.notbox = new System.Windows.Forms.RichTextBox();
            this.infolabel = new System.Windows.Forms.Label();
            this.sendbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filtrebox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.silbtn = new System.Windows.Forms.Button();
            this.notbtn = new System.Windows.Forms.Button();
            this.kaydetbtn = new System.Windows.Forms.Button();
            this.notaralabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notlistbox = new System.Windows.Forms.ComboBox();
            this.filmrad = new System.Windows.Forms.RadioButton();
            this.dizirad = new System.Windows.Forms.RadioButton();
            this.serbestrad = new System.Windows.Forms.RadioButton();
            this.filmisim = new System.Windows.Forms.TextBox();
            this.filmtur = new System.Windows.Forms.TextBox();
            this.filmpuan = new System.Windows.Forms.TextBox();
            this.filmkonu = new System.Windows.Forms.TextBox();
            this.filmkaydetbtn = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.filmshownot = new System.Windows.Forms.RichTextBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.diziyorum = new System.Windows.Forms.TextBox();
            this.dizipuan = new System.Windows.Forms.TextBox();
            this.dizitür = new System.Windows.Forms.TextBox();
            this.diziisim = new System.Windows.Forms.TextBox();
            this.dizikaydetbtn = new System.Windows.Forms.Button();
            this.sezon = new System.Windows.Forms.ComboBox();
            this.bolum = new System.Windows.Forms.ComboBox();
            this.dizigöster = new System.Windows.Forms.RichTextBox();
            this.dIZIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bOLUMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kATEGORIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUANDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yORUMDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tARIHDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diziBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mydbDataSet1 = new mfl.mydbDataSet();
            this.filmBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mydbDataSet = new mfl.mydbDataSet();
            this.serbestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmTableAdapter = new mfl.mydbDataSetTableAdapters.filmTableAdapter();
            this.serbestTableAdapter = new mfl.mydbDataSetTableAdapters.serbestTableAdapter();
            this.diziTableAdapter = new mfl.mydbDataSetTableAdapters.diziTableAdapter();
            this.FILM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YORUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOTUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KONU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TARIH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diziBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serbestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // notbox
            // 
            this.notbox.BackColor = System.Drawing.SystemColors.InfoText;
            this.notbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notbox.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.notbox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.notbox.Location = new System.Drawing.Point(373, 31);
            this.notbox.Name = "notbox";
            this.notbox.Size = new System.Drawing.Size(415, 289);
            this.notbox.TabIndex = 0;
            this.notbox.TabStop = false;
            this.notbox.Text = "";
            this.notbox.Enter += new System.EventHandler(this.notbox_Enter);
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.BackColor = System.Drawing.Color.Transparent;
            this.infolabel.Font = new System.Drawing.Font("Minion Pro", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.infolabel.Location = new System.Drawing.Point(432, 413);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(0, 18);
            this.infolabel.TabIndex = 2;
            // 
            // sendbtn
            // 
            this.sendbtn.BackColor = System.Drawing.Color.Transparent;
            this.sendbtn.FlatAppearance.BorderSize = 0;
            this.sendbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendbtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendbtn.Location = new System.Drawing.Point(497, 323);
            this.sendbtn.Name = "sendbtn";
            this.sendbtn.Size = new System.Drawing.Size(75, 21);
            this.sendbtn.TabIndex = 3;
            this.sendbtn.Text = "KAYDET";
            this.sendbtn.UseVisualStyleBackColor = false;
            this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOTUN,
            this.KONU,
            this.TARIH});
            this.dataGridView1.DataSource = this.serbestBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 50;
            this.dataGridView1.Size = new System.Drawing.Size(352, 366);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // filtrebox
            // 
            this.filtrebox.BackColor = System.Drawing.SystemColors.MenuText;
            this.filtrebox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filtrebox.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filtrebox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.filtrebox.Location = new System.Drawing.Point(279, 415);
            this.filtrebox.Name = "filtrebox";
            this.filtrebox.Size = new System.Drawing.Size(147, 14);
            this.filtrebox.TabIndex = 8;
            this.filtrebox.Visible = false;
            this.filtrebox.TextChanged += new System.EventHandler(this.filtrebox_TextChanged);
            this.filtrebox.Enter += new System.EventHandler(this.filtrebox_Enter);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBox1.Location = new System.Drawing.Point(719, 326);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(69, 20);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "listele";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // silbtn
            // 
            this.silbtn.BackColor = System.Drawing.Color.Transparent;
            this.silbtn.FlatAppearance.BorderSize = 0;
            this.silbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.silbtn.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silbtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.silbtn.Location = new System.Drawing.Point(12, 411);
            this.silbtn.Name = "silbtn";
            this.silbtn.Size = new System.Drawing.Size(42, 23);
            this.silbtn.TabIndex = 10;
            this.silbtn.Text = "sil";
            this.silbtn.UseVisualStyleBackColor = false;
            this.silbtn.Visible = false;
            this.silbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // notbtn
            // 
            this.notbtn.BackColor = System.Drawing.Color.Transparent;
            this.notbtn.FlatAppearance.BorderSize = 0;
            this.notbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notbtn.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.notbtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.notbtn.Location = new System.Drawing.Point(208, 411);
            this.notbtn.Name = "notbtn";
            this.notbtn.Size = new System.Drawing.Size(65, 23);
            this.notbtn.TabIndex = 12;
            this.notbtn.Text = "notu aç";
            this.notbtn.UseVisualStyleBackColor = false;
            this.notbtn.Visible = false;
            this.notbtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // kaydetbtn
            // 
            this.kaydetbtn.BackColor = System.Drawing.Color.Transparent;
            this.kaydetbtn.FlatAppearance.BorderSize = 0;
            this.kaydetbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kaydetbtn.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydetbtn.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.kaydetbtn.Location = new System.Drawing.Point(61, 411);
            this.kaydetbtn.Name = "kaydetbtn";
            this.kaydetbtn.Size = new System.Drawing.Size(142, 23);
            this.kaydetbtn.TabIndex = 13;
            this.kaydetbtn.Text = "düzenlemeyi kaydet";
            this.kaydetbtn.UseVisualStyleBackColor = false;
            this.kaydetbtn.Visible = false;
            this.kaydetbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // notaralabel
            // 
            this.notaralabel.AutoSize = true;
            this.notaralabel.BackColor = System.Drawing.Color.Transparent;
            this.notaralabel.Font = new System.Drawing.Font("Minion Pro", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notaralabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.notaralabel.Location = new System.Drawing.Point(306, 431);
            this.notaralabel.Name = "notaralabel";
            this.notaralabel.Size = new System.Drawing.Size(96, 16);
            this.notaralabel.TabIndex = 14;
            this.notaralabel.Text = "notların içinde ara";
            this.notaralabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Minion Pro SmBd", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(665, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "A0.1 Vanilia x64";
            // 
            // notlistbox
            // 
            this.notlistbox.BackColor = System.Drawing.Color.Black;
            this.notlistbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notlistbox.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.notlistbox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.notlistbox.FormattingEnabled = true;
            this.notlistbox.Items.AddRange(new object[] {
            "SERBEST",
            "FIKIR",
            "SIFRE",
            "URL",
            "HATIRLATMA",
            "TODO LIST",
            ""});
            this.notlistbox.Location = new System.Drawing.Point(370, 323);
            this.notlistbox.Name = "notlistbox";
            this.notlistbox.Size = new System.Drawing.Size(121, 22);
            this.notlistbox.TabIndex = 16;
            this.notlistbox.SelectedIndexChanged += new System.EventHandler(this.notlistbox_SelectedIndexChanged);
            // 
            // filmrad
            // 
            this.filmrad.AutoSize = true;
            this.filmrad.BackColor = System.Drawing.Color.Transparent;
            this.filmrad.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filmrad.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.filmrad.Location = new System.Drawing.Point(735, 376);
            this.filmrad.Name = "filmrad";
            this.filmrad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.filmrad.Size = new System.Drawing.Size(53, 18);
            this.filmrad.TabIndex = 17;
            this.filmrad.TabStop = true;
            this.filmrad.Text = "film";
            this.filmrad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filmrad.UseVisualStyleBackColor = false;
            this.filmrad.CheckedChanged += new System.EventHandler(this.filmrad_CheckedChanged);
            // 
            // dizirad
            // 
            this.dizirad.AutoSize = true;
            this.dizirad.BackColor = System.Drawing.Color.Transparent;
            this.dizirad.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dizirad.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dizirad.Location = new System.Drawing.Point(735, 400);
            this.dizirad.Name = "dizirad";
            this.dizirad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dizirad.Size = new System.Drawing.Size(53, 18);
            this.dizirad.TabIndex = 17;
            this.dizirad.TabStop = true;
            this.dizirad.Text = "dizi";
            this.dizirad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dizirad.UseVisualStyleBackColor = false;
            this.dizirad.CheckedChanged += new System.EventHandler(this.dizirad_CheckedChanged);
            // 
            // serbestrad
            // 
            this.serbestrad.AutoSize = true;
            this.serbestrad.BackColor = System.Drawing.Color.Transparent;
            this.serbestrad.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.serbestrad.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.serbestrad.Location = new System.Drawing.Point(714, 352);
            this.serbestrad.Name = "serbestrad";
            this.serbestrad.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.serbestrad.Size = new System.Drawing.Size(74, 18);
            this.serbestrad.TabIndex = 17;
            this.serbestrad.TabStop = true;
            this.serbestrad.Text = "serbest";
            this.serbestrad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.serbestrad.UseVisualStyleBackColor = false;
            this.serbestrad.CheckedChanged += new System.EventHandler(this.serbestrad_CheckedChanged);
            // 
            // filmisim
            // 
            this.filmisim.BackColor = System.Drawing.SystemColors.MenuText;
            this.filmisim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filmisim.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filmisim.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.filmisim.Location = new System.Drawing.Point(371, 28);
            this.filmisim.Name = "filmisim";
            this.filmisim.Size = new System.Drawing.Size(147, 14);
            this.filmisim.TabIndex = 18;
            this.filmisim.Text = "isim";
            this.filmisim.Visible = false;
            // 
            // filmtur
            // 
            this.filmtur.BackColor = System.Drawing.SystemColors.MenuText;
            this.filmtur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filmtur.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filmtur.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.filmtur.Location = new System.Drawing.Point(524, 28);
            this.filmtur.Name = "filmtur";
            this.filmtur.Size = new System.Drawing.Size(147, 14);
            this.filmtur.TabIndex = 19;
            this.filmtur.Text = "tür";
            this.filmtur.Visible = false;
            // 
            // filmpuan
            // 
            this.filmpuan.BackColor = System.Drawing.SystemColors.MenuText;
            this.filmpuan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filmpuan.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filmpuan.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.filmpuan.Location = new System.Drawing.Point(370, 48);
            this.filmpuan.Name = "filmpuan";
            this.filmpuan.Size = new System.Drawing.Size(147, 14);
            this.filmpuan.TabIndex = 20;
            this.filmpuan.Text = "puan";
            this.filmpuan.Visible = false;
            // 
            // filmkonu
            // 
            this.filmkonu.BackColor = System.Drawing.SystemColors.MenuText;
            this.filmkonu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filmkonu.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filmkonu.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.filmkonu.Location = new System.Drawing.Point(524, 47);
            this.filmkonu.Name = "filmkonu";
            this.filmkonu.Size = new System.Drawing.Size(147, 14);
            this.filmkonu.TabIndex = 21;
            this.filmkonu.Text = "yorum";
            this.filmkonu.Visible = false;
            // 
            // filmkaydetbtn
            // 
            this.filmkaydetbtn.BackColor = System.Drawing.Color.Transparent;
            this.filmkaydetbtn.FlatAppearance.BorderSize = 0;
            this.filmkaydetbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filmkaydetbtn.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filmkaydetbtn.Location = new System.Drawing.Point(472, 67);
            this.filmkaydetbtn.Name = "filmkaydetbtn";
            this.filmkaydetbtn.Size = new System.Drawing.Size(91, 29);
            this.filmkaydetbtn.TabIndex = 22;
            this.filmkaydetbtn.Text = "KAYDET";
            this.filmkaydetbtn.UseVisualStyleBackColor = false;
            this.filmkaydetbtn.Visible = false;
            this.filmkaydetbtn.Click += new System.EventHandler(this.filmkaydetbtn_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FILM,
            this.TUR,
            this.PUAN,
            this.YORUM,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView2.DataSource = this.filmBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(12, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 50;
            this.dataGridView2.Size = new System.Drawing.Size(453, 366);
            this.dataGridView2.TabIndex = 23;
            this.dataGridView2.Visible = false;
            this.dataGridView2.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView2_CellBeginEdit);
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            // 
            // filmshownot
            // 
            this.filmshownot.BackColor = System.Drawing.SystemColors.InfoText;
            this.filmshownot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.filmshownot.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filmshownot.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.filmshownot.Location = new System.Drawing.Point(475, 31);
            this.filmshownot.Name = "filmshownot";
            this.filmshownot.Size = new System.Drawing.Size(313, 289);
            this.filmshownot.TabIndex = 24;
            this.filmshownot.TabStop = false;
            this.filmshownot.Text = "";
            this.filmshownot.Visible = false;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dIZIDataGridViewTextBoxColumn,
            this.bOLUMDataGridViewTextBoxColumn,
            this.kATEGORIDataGridViewTextBoxColumn,
            this.pUANDataGridViewTextBoxColumn1,
            this.yORUMDataGridViewTextBoxColumn1,
            this.tARIHDataGridViewTextBoxColumn2});
            this.dataGridView3.DataSource = this.diziBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 28);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(533, 222);
            this.dataGridView3.TabIndex = 25;
            this.dataGridView3.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView3_CellBeginEdit);
            this.dataGridView3.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellEndEdit);
            // 
            // diziyorum
            // 
            this.diziyorum.BackColor = System.Drawing.SystemColors.MenuText;
            this.diziyorum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.diziyorum.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.diziyorum.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.diziyorum.Location = new System.Drawing.Point(524, 47);
            this.diziyorum.Name = "diziyorum";
            this.diziyorum.Size = new System.Drawing.Size(147, 14);
            this.diziyorum.TabIndex = 29;
            this.diziyorum.Text = "yorum";
            this.diziyorum.Visible = false;
            this.diziyorum.Enter += new System.EventHandler(this.diziyorum_Enter);
            this.diziyorum.Leave += new System.EventHandler(this.diziyorum_Leave);
            // 
            // dizipuan
            // 
            this.dizipuan.BackColor = System.Drawing.SystemColors.MenuText;
            this.dizipuan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dizipuan.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dizipuan.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dizipuan.Location = new System.Drawing.Point(370, 48);
            this.dizipuan.Name = "dizipuan";
            this.dizipuan.Size = new System.Drawing.Size(147, 14);
            this.dizipuan.TabIndex = 28;
            this.dizipuan.Text = "puan";
            this.dizipuan.Visible = false;
            this.dizipuan.Enter += new System.EventHandler(this.dizipuan_Enter);
            this.dizipuan.Leave += new System.EventHandler(this.dizipuan_Leave);
            // 
            // dizitür
            // 
            this.dizitür.BackColor = System.Drawing.SystemColors.MenuText;
            this.dizitür.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dizitür.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dizitür.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dizitür.Location = new System.Drawing.Point(524, 28);
            this.dizitür.Name = "dizitür";
            this.dizitür.Size = new System.Drawing.Size(147, 14);
            this.dizitür.TabIndex = 27;
            this.dizitür.Text = "tür";
            this.dizitür.Visible = false;
            this.dizitür.Enter += new System.EventHandler(this.dizitür_Enter);
            this.dizitür.Leave += new System.EventHandler(this.dizitür_Leave);
            // 
            // diziisim
            // 
            this.diziisim.BackColor = System.Drawing.SystemColors.MenuText;
            this.diziisim.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.diziisim.Font = new System.Drawing.Font("Unispace", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.diziisim.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.diziisim.Location = new System.Drawing.Point(371, 28);
            this.diziisim.Name = "diziisim";
            this.diziisim.Size = new System.Drawing.Size(147, 14);
            this.diziisim.TabIndex = 26;
            this.diziisim.Text = "isim";
            this.diziisim.Visible = false;
            this.diziisim.Enter += new System.EventHandler(this.diziisim_Enter);
            this.diziisim.Leave += new System.EventHandler(this.diziisim_Leave);
            // 
            // dizikaydetbtn
            // 
            this.dizikaydetbtn.BackColor = System.Drawing.Color.Transparent;
            this.dizikaydetbtn.FlatAppearance.BorderSize = 0;
            this.dizikaydetbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dizikaydetbtn.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dizikaydetbtn.Location = new System.Drawing.Point(472, 95);
            this.dizikaydetbtn.Name = "dizikaydetbtn";
            this.dizikaydetbtn.Size = new System.Drawing.Size(96, 29);
            this.dizikaydetbtn.TabIndex = 30;
            this.dizikaydetbtn.Text = "KAYDET";
            this.dizikaydetbtn.UseVisualStyleBackColor = false;
            this.dizikaydetbtn.Visible = false;
            this.dizikaydetbtn.Click += new System.EventHandler(this.dizikaydetbtn_Click);
            // 
            // sezon
            // 
            this.sezon.BackColor = System.Drawing.SystemColors.MenuText;
            this.sezon.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sezon.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.sezon.FormattingEnabled = true;
            this.sezon.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.sezon.Location = new System.Drawing.Point(473, 68);
            this.sezon.Name = "sezon";
            this.sezon.Size = new System.Drawing.Size(44, 23);
            this.sezon.TabIndex = 31;
            // 
            // bolum
            // 
            this.bolum.BackColor = System.Drawing.SystemColors.MenuText;
            this.bolum.Font = new System.Drawing.Font("Unispace", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bolum.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.bolum.FormattingEnabled = true;
            this.bolum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.bolum.Location = new System.Drawing.Point(524, 68);
            this.bolum.Name = "bolum";
            this.bolum.Size = new System.Drawing.Size(44, 23);
            this.bolum.TabIndex = 32;
            // 
            // dizigöster
            // 
            this.dizigöster.BackColor = System.Drawing.SystemColors.InfoText;
            this.dizigöster.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dizigöster.Font = new System.Drawing.Font("Unispace", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dizigöster.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dizigöster.Location = new System.Drawing.Point(12, 256);
            this.dizigöster.Name = "dizigöster";
            this.dizigöster.Size = new System.Drawing.Size(544, 149);
            this.dizigöster.TabIndex = 33;
            this.dizigöster.TabStop = false;
            this.dizigöster.Text = "";
            this.dizigöster.Visible = false;
            // 
            // dIZIDataGridViewTextBoxColumn
            // 
            this.dIZIDataGridViewTextBoxColumn.DataPropertyName = "DIZI";
            this.dIZIDataGridViewTextBoxColumn.HeaderText = "DIZI";
            this.dIZIDataGridViewTextBoxColumn.Name = "dIZIDataGridViewTextBoxColumn";
            // 
            // bOLUMDataGridViewTextBoxColumn
            // 
            this.bOLUMDataGridViewTextBoxColumn.DataPropertyName = "BOLUM";
            this.bOLUMDataGridViewTextBoxColumn.HeaderText = "BOLUM";
            this.bOLUMDataGridViewTextBoxColumn.Name = "bOLUMDataGridViewTextBoxColumn";
            this.bOLUMDataGridViewTextBoxColumn.Width = 90;
            // 
            // kATEGORIDataGridViewTextBoxColumn
            // 
            this.kATEGORIDataGridViewTextBoxColumn.DataPropertyName = "KATEGORI";
            this.kATEGORIDataGridViewTextBoxColumn.HeaderText = "KATEGORI";
            this.kATEGORIDataGridViewTextBoxColumn.Name = "kATEGORIDataGridViewTextBoxColumn";
            this.kATEGORIDataGridViewTextBoxColumn.Width = 65;
            // 
            // pUANDataGridViewTextBoxColumn1
            // 
            this.pUANDataGridViewTextBoxColumn1.DataPropertyName = "PUAN";
            this.pUANDataGridViewTextBoxColumn1.HeaderText = "PUAN";
            this.pUANDataGridViewTextBoxColumn1.Name = "pUANDataGridViewTextBoxColumn1";
            this.pUANDataGridViewTextBoxColumn1.Width = 40;
            // 
            // yORUMDataGridViewTextBoxColumn1
            // 
            this.yORUMDataGridViewTextBoxColumn1.DataPropertyName = "YORUM";
            this.yORUMDataGridViewTextBoxColumn1.HeaderText = "YORUM";
            this.yORUMDataGridViewTextBoxColumn1.Name = "yORUMDataGridViewTextBoxColumn1";
            // 
            // tARIHDataGridViewTextBoxColumn2
            // 
            this.tARIHDataGridViewTextBoxColumn2.DataPropertyName = "TARIH";
            this.tARIHDataGridViewTextBoxColumn2.HeaderText = "TARIH";
            this.tARIHDataGridViewTextBoxColumn2.Name = "tARIHDataGridViewTextBoxColumn2";
            // 
            // diziBindingSource
            // 
            this.diziBindingSource.DataMember = "dizi";
            this.diziBindingSource.DataSource = this.mydbDataSet1;
            // 
            // mydbDataSet1
            // 
            this.mydbDataSet1.DataSetName = "mydbDataSet";
            this.mydbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmBindingSource1
            // 
            this.filmBindingSource1.DataMember = "film";
            this.filmBindingSource1.DataSource = this.mydbDataSet;
            // 
            // mydbDataSet
            // 
            this.mydbDataSet.DataSetName = "mydbDataSet";
            this.mydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serbestBindingSource
            // 
            this.serbestBindingSource.DataMember = "serbest";
            this.serbestBindingSource.DataSource = this.mydbDataSet;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // serbestTableAdapter
            // 
            this.serbestTableAdapter.ClearBeforeFill = true;
            // 
            // diziTableAdapter
            // 
            this.diziTableAdapter.ClearBeforeFill = true;
            // 
            // FILM
            // 
            this.FILM.DataPropertyName = "FILM";
            this.FILM.HeaderText = "FILM";
            this.FILM.Name = "FILM";
            // 
            // TUR
            // 
            this.TUR.DataPropertyName = "TUR";
            this.TUR.HeaderText = "TUR";
            this.TUR.Name = "TUR";
            this.TUR.Width = 70;
            // 
            // PUAN
            // 
            this.PUAN.DataPropertyName = "PUAN";
            this.PUAN.HeaderText = "PUAN";
            this.PUAN.Name = "PUAN";
            this.PUAN.Width = 40;
            // 
            // YORUM
            // 
            this.YORUM.DataPropertyName = "YORUM";
            this.YORUM.HeaderText = "YORUM";
            this.YORUM.Name = "YORUM";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "TARIH";
            this.dataGridViewTextBoxColumn4.HeaderText = "TARIH";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // NOTUN
            // 
            this.NOTUN.DataPropertyName = "NOTUN";
            this.NOTUN.HeaderText = "NOTUN";
            this.NOTUN.Name = "NOTUN";
            // 
            // KONU
            // 
            this.KONU.DataPropertyName = "KONU";
            this.KONU.HeaderText = "KONU";
            this.KONU.Name = "KONU";
            // 
            // TARIH
            // 
            this.TARIH.DataPropertyName = "TARIH";
            this.TARIH.HeaderText = "TARIH";
            this.TARIH.Name = "TARIH";
            // 
            // serbest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mfl.Properties.Resources._307_3075958_film_noir_color;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dizigöster);
            this.Controls.Add(this.bolum);
            this.Controls.Add(this.sezon);
            this.Controls.Add(this.dizikaydetbtn);
            this.Controls.Add(this.diziyorum);
            this.Controls.Add(this.dizipuan);
            this.Controls.Add(this.dizitür);
            this.Controls.Add(this.diziisim);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.filmshownot);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.filmkaydetbtn);
            this.Controls.Add(this.filmkonu);
            this.Controls.Add(this.filmpuan);
            this.Controls.Add(this.filmtur);
            this.Controls.Add(this.filmisim);
            this.Controls.Add(this.serbestrad);
            this.Controls.Add(this.dizirad);
            this.Controls.Add(this.filmrad);
            this.Controls.Add(this.notlistbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.notaralabel);
            this.Controls.Add(this.kaydetbtn);
            this.Controls.Add(this.notbtn);
            this.Controls.Add(this.silbtn);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.filtrebox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sendbtn);
            this.Controls.Add(this.infolabel);
            this.Controls.Add(this.notbox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "serbest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.serbest_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.serbest_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.serbest_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.serbest_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diziBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serbestBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox notbox;
        private System.Windows.Forms.Label infolabel;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox filtrebox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button silbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button notbtn;
        private System.Windows.Forms.Button kaydetbtn;
        private System.Windows.Forms.Label notaralabel;
        //private mydbDataSetTableAdapters.serbestTableAdapter serbestTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox notlistbox;
        private System.Windows.Forms.RadioButton filmrad;
        private System.Windows.Forms.RadioButton dizirad;
        private System.Windows.Forms.RadioButton serbestrad;
        private mydbDataSet mydbDataSet;
        private System.Windows.Forms.BindingSource filmBindingSource1;
        private mydbDataSetTableAdapters.filmTableAdapter filmTableAdapter;
        private System.Windows.Forms.BindingSource serbestBindingSource;
        private mydbDataSetTableAdapters.serbestTableAdapter serbestTableAdapter;
        private System.Windows.Forms.TextBox filmisim;
        private System.Windows.Forms.TextBox filmtur;
        private System.Windows.Forms.TextBox filmpuan;
        private System.Windows.Forms.TextBox filmkonu;
        private System.Windows.Forms.Button filmkaydetbtn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.RichTextBox filmshownot;
        private System.Windows.Forms.DataGridView dataGridView3;
        private mydbDataSet mydbDataSet1;
        private System.Windows.Forms.BindingSource diziBindingSource;
        private mydbDataSetTableAdapters.diziTableAdapter diziTableAdapter;
        private System.Windows.Forms.TextBox diziyorum;
        private System.Windows.Forms.TextBox dizipuan;
        private System.Windows.Forms.TextBox dizitür;
        private System.Windows.Forms.TextBox diziisim;
        private System.Windows.Forms.Button dizikaydetbtn;
        private System.Windows.Forms.ComboBox sezon;
        private System.Windows.Forms.ComboBox bolum;
        private System.Windows.Forms.RichTextBox dizigöster;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIZIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bOLUMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kATEGORIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUANDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yORUMDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tARIHDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTUN;
        private System.Windows.Forms.DataGridViewTextBoxColumn KONU;
        private System.Windows.Forms.DataGridViewTextBoxColumn TARIH;
        private System.Windows.Forms.DataGridViewTextBoxColumn FILM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn YORUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}