
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
            this.mydbDataSet = new mfl.mydbDataSet();
            this.filmBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.filmTableAdapter = new mfl.mydbDataSetTableAdapters.filmTableAdapter();
            this.serbestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serbestTableAdapter = new mfl.mydbDataSetTableAdapters.serbestTableAdapter();
            this.filmisim = new System.Windows.Forms.TextBox();
            this.filmtur = new System.Windows.Forms.TextBox();
            this.filmpuan = new System.Windows.Forms.TextBox();
            this.filmkonu = new System.Windows.Forms.TextBox();
            this.filmkaydetbtn = new System.Windows.Forms.Button();
            this.NOTUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KONU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TARIH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.FILM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TUR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YORUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serbestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // notbox
            // 
            this.notbox.BackColor = System.Drawing.SystemColors.InfoText;
            this.notbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notbox.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.notbox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.notbox.Location = new System.Drawing.Point(370, 28);
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
            this.infolabel.Font = new System.Drawing.Font("Minion Pro", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.infolabel.Location = new System.Drawing.Point(533, 362);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(0, 18);
            this.infolabel.TabIndex = 2;
            this.infolabel.Click += new System.EventHandler(this.infolabel_Click);
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
            this.filtrebox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.label1.Location = new System.Drawing.Point(553, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "A0.1 x64 solution - special edition";
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
            // mydbDataSet
            // 
            this.mydbDataSet.DataSetName = "mydbDataSet";
            this.mydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmBindingSource1
            // 
            this.filmBindingSource1.DataMember = "film";
            this.filmBindingSource1.DataSource = this.mydbDataSet;
            // 
            // filmTableAdapter
            // 
            this.filmTableAdapter.ClearBeforeFill = true;
            // 
            // serbestBindingSource
            // 
            this.serbestBindingSource.DataMember = "serbest";
            this.serbestBindingSource.DataSource = this.mydbDataSet;
            // 
            // serbestTableAdapter
            // 
            this.serbestTableAdapter.ClearBeforeFill = true;
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
            this.dataGridView2.Location = new System.Drawing.Point(13, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 50;
            this.dataGridView2.Size = new System.Drawing.Size(352, 366);
            this.dataGridView2.TabIndex = 23;
            this.dataGridView2.Visible = false;
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
            // 
            // PUAN
            // 
            this.PUAN.DataPropertyName = "PUAN";
            this.PUAN.HeaderText = "PUAN";
            this.PUAN.Name = "PUAN";
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
            // serbest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mfl.Properties.Resources._307_3075958_film_noir_color;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serbestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTUN;
        private System.Windows.Forms.DataGridViewTextBoxColumn KONU;
        private System.Windows.Forms.DataGridViewTextBoxColumn TARIH;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FILM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TUR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn YORUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}