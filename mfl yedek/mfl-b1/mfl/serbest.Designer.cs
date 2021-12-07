
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
            this.serbestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mydbDataSet = new mfl.mydbDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NOTUN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KONU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TARIH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filtrebox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.silbtn = new System.Windows.Forms.Button();
            this.notbtn = new System.Windows.Forms.Button();
            this.kaydetbtn = new System.Windows.Forms.Button();
            this.notaralabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serbestTableAdapter = new mfl.mydbDataSetTableAdapters.serbestTableAdapter();
            this.notlistbox = new System.Windows.Forms.ComboBox();
            this.kimlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nOTUNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kONUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tARIHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.serbestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // serbestBindingSource
            // 
            this.serbestBindingSource.DataMember = "serbest";
            this.serbestBindingSource.DataSource = this.mydbDataSet;
            // 
            // mydbDataSet
            // 
            this.mydbDataSet.DataSetName = "mydbDataSet";
            this.mydbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NOTUN,
            this.KONU,
            this.TARIH,
            this.kimlikDataGridViewTextBoxColumn,
            this.nOTUNDataGridViewTextBoxColumn,
            this.kONUDataGridViewTextBoxColumn,
            this.tARIHDataGridViewTextBoxColumn});
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
            // NOTUN
            // 
            this.NOTUN.DataPropertyName = "NOTUN";
            this.NOTUN.HeaderText = "NOTUN";
            this.NOTUN.Name = "NOTUN";
            this.NOTUN.Width = 120;
            // 
            // KONU
            // 
            this.KONU.DataPropertyName = "KONU";
            this.KONU.HeaderText = "KONU";
            this.KONU.Name = "KONU";
            this.KONU.ReadOnly = true;
            this.KONU.Width = 80;
            // 
            // TARIH
            // 
            this.TARIH.DataPropertyName = "TARIH";
            this.TARIH.HeaderText = "TARIH";
            this.TARIH.Name = "TARIH";
            this.TARIH.ReadOnly = true;
            this.TARIH.Width = 90;
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
            this.checkBox1.Location = new System.Drawing.Point(578, 327);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(52, 17);
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
            this.label1.Font = new System.Drawing.Font("Minion Pro", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(683, 415);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "x64 solution";
            // 
            // serbestTableAdapter
            // 
            this.serbestTableAdapter.ClearBeforeFill = true;
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
            // kimlikDataGridViewTextBoxColumn
            // 
            this.kimlikDataGridViewTextBoxColumn.DataPropertyName = "Kimlik";
            this.kimlikDataGridViewTextBoxColumn.HeaderText = "Kimlik";
            this.kimlikDataGridViewTextBoxColumn.Name = "kimlikDataGridViewTextBoxColumn";
            // 
            // nOTUNDataGridViewTextBoxColumn
            // 
            this.nOTUNDataGridViewTextBoxColumn.DataPropertyName = "NOTUN";
            this.nOTUNDataGridViewTextBoxColumn.HeaderText = "NOTUN";
            this.nOTUNDataGridViewTextBoxColumn.Name = "nOTUNDataGridViewTextBoxColumn";
            // 
            // kONUDataGridViewTextBoxColumn
            // 
            this.kONUDataGridViewTextBoxColumn.DataPropertyName = "KONU";
            this.kONUDataGridViewTextBoxColumn.HeaderText = "KONU";
            this.kONUDataGridViewTextBoxColumn.Name = "kONUDataGridViewTextBoxColumn";
            // 
            // tARIHDataGridViewTextBoxColumn
            // 
            this.tARIHDataGridViewTextBoxColumn.DataPropertyName = "TARIH";
            this.tARIHDataGridViewTextBoxColumn.HeaderText = "TARIH";
            this.tARIHDataGridViewTextBoxColumn.Name = "tARIHDataGridViewTextBoxColumn";
            // 
            // serbest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::mfl.Properties.Resources._307_3075958_film_noir_color;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
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
            this.Text = "SERBEST";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.serbest_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.serbest_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.serbest_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.serbest_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.serbestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mydbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox notbox;
        private System.Windows.Forms.Label infolabel;
        private System.Windows.Forms.Button sendbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nOTUNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kONUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tARIHDataGridViewTextBoxColumn;
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
        private mydbDataSet mydbDataSet;
        private System.Windows.Forms.BindingSource serbestBindingSource;
        private mydbDataSetTableAdapters.serbestTableAdapter serbestTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox notlistbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOTUN;
        private System.Windows.Forms.DataGridViewTextBoxColumn KONU;
        private System.Windows.Forms.DataGridViewTextBoxColumn TARIH;
        private System.Windows.Forms.DataGridViewTextBoxColumn kimlikDataGridViewTextBoxColumn;
    }
}