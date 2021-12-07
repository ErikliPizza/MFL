using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Runtime.InteropServices;

namespace mfl
{
    public partial class serbest : Form
    {
        #region dll for rounded form
        private bool mouseDown;
        private Point lastLocation;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        #endregion
        OleDbConnection _connection = 
           new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = C:\\mydb.accdb");
        OleDbCommand _command = new OleDbCommand();

        private int lastkey;
        public serbest()
        {
            InitializeComponent();

        }
        GlobalKeyboardHook gHook;


        private void serbest_Load(object sender, EventArgs e)
        {
            serbestrad.Checked = true;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            this.filmTableAdapter.Fill(this.mydbDataSet.film);
            gHook = new GlobalKeyboardHook(); // Create a new GlobalKeyboardHook
                                              // Declare a KeyDown Event
            gHook.KeyDown += new KeyEventHandler(gHook_KeyDown);
            // Add the keys you want to hook to the HookedKeys list
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
                gHook.HookedKeys.Add(key);
            gHook.hook();
        }
        public void gHook_KeyDown(object sender, KeyEventArgs e)
        {
            if (lastkey == 162 && e.KeyValue == 83) // ctrl ve S basıldığında
            {
                bool isserbestopen = false;
                FormCollection fc = Application.OpenForms; // açık formları topla

                foreach (Form frm in fc) // açık formları kontrol et
                {
                    //iterate through
                    if (frm.Name == "serbest")//açık formlarında içinde serbest bulduysan
                    {
                        isserbestopen = true; // true yap
                        break; //döngüden direkt çık
                    }
                    else
                        isserbestopen = false; //serbest bulunmadıysa false yap
                }
                if (isserbestopen)
                {
                    Form1.opendorcontroller = true;
                    this.Close(); //terminate
                }
            }
            lastkey = e.KeyValue;
        }


        private void sendbtn_Click(object sender, EventArgs e)//serbest data ekle
        {
            if (notbox.Text != "" && notlistbox.SelectedIndex >= 0)
            {
                infolabel.Text = "";
                string konu = notlistbox.SelectedItem.ToString();
                _command.Connection = _connection;
                _command.CommandText = "insert into serbest(NOTUN, KONU, TARIH) values ('" + notbox.Text + "', '" + konu + "',Now())";
                _connection.Open();
                _command.ExecuteNonQuery();
                _command.Dispose();
                _connection.Close();
                serbestTableAdapter.Update(mydbDataSet);
                this.serbestTableAdapter.Fill(this.mydbDataSet.serbest);
                notbox.Text = "";
                MessageBox.Show("başarılı");
            }
            else
                infolabel.Text = "not ve kategori girişi yapın";
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(serbestrad.Checked)
            {
            if (notlistbox.SelectedIndex >= 0)
            {
                string selectedlkn = notlistbox.SelectedItem.ToString();
                BindingSource bs = new BindingSource();
                bs.DataSource = dataGridView1.DataSource;
                dataGridView1.DataSource = bs;
                bs.Filter = "[NOTUN] like '%" + filtrebox.Text + "%'" +
                    "AND[KONU]like '%" + selectedlkn + "%'";
            }
            else
            {
                BindingSource bs = new BindingSource();
                bs.DataSource = dataGridView1.DataSource;
                dataGridView1.DataSource = bs;
                bs.Filter = "[NOTUN] like '%" + filtrebox.Text + "%'";
            }
            }
            
            if(filmrad.Checked)
            {
                BindingSource bsf = new BindingSource();
                bsf.DataSource = dataGridView2.DataSource;
                dataGridView2.DataSource = bsf;
                bsf.Filter = "[FILM] like '%" + filtrebox.Text + "%'" +
                    "OR[TUR] like '%" + filtrebox.Text + "%'" +
                        "OR[PUAN] like '%" + filtrebox.Text + "%'" +
                        "OR[YORUM] like '%" + filtrebox.Text + "%'";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                notaralabel.Visible = true;
                notbtn.Visible = true;
                silbtn.Visible = true;
                kaydetbtn.Visible = true;
                filtrebox.Visible = true;
            }
            else 
            {
                notaralabel.Visible = false;
                notbtn.Visible = false;
                silbtn.Visible = false;
                kaydetbtn.Visible = false;
                filtrebox.Visible = false;
            }
            if (serbestrad.Checked)
                serbestaktif();
            else if (filmrad.Checked)
                filmaktif();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (serbestrad.Checked)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(row.Index);
                }
                serbestTableAdapter.Update(mydbDataSet);
            }
            else if (filmrad.Checked)
            {
                foreach (DataGridViewRow row in dataGridView2.SelectedRows)
                {
                    dataGridView2.Rows.RemoveAt(row.Index);
                }
                filmTableAdapter.Update(mydbDataSet);
            }
        }//sil

        private void button2_Click(object sender, EventArgs e) // notu oku
        {
            if (serbestrad.Checked)
            {
                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    notbox.Text = dataGridView1.CurrentCell.Value.ToString();
                }
            }
            if(filmrad.Checked)
            {
                foreach (DataGridViewCell cell in dataGridView2.SelectedCells)
                {
                    filmshownot.Text = dataGridView2.CurrentCell.Value.ToString();
                }
            }
        }


        private void button3_Click(object sender, EventArgs e) //değişiklikleri kaydet
        {
            serbestTableAdapter.Update(mydbDataSet);
            filmTableAdapter.Update(mydbDataSet);
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            serbestTableAdapter.Update(mydbDataSet);
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            serbestTableAdapter.Update(mydbDataSet);
        }

        private void filtrebox_Enter(object sender, EventArgs e)
        {
            filtrebox.Text = "";
        }

        private void notbox_Enter(object sender, EventArgs e)
        {
            if (notbox.ReadOnly == false)
                notbox.Text = "";
        }

        private void notlistbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serbestrad.Checked)
            {
                string selectedlkn = notlistbox.SelectedItem.ToString();
                BindingSource bs = new BindingSource();
                bs.DataSource = dataGridView1.DataSource;
                dataGridView1.DataSource = bs;
                bs.Filter = "[NOTUN] like '%" + filtrebox.Text + "%'" +
                    "AND[KONU]like '%" + selectedlkn + "%'";
            }
        }

        private void serbest_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void serbest_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void serbest_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void serbestrad_CheckedChanged(object sender, EventArgs e)
        {
            if (serbestrad.Checked)
            {
                serbestaktif();
            }

        }

        private void filmrad_CheckedChanged(object sender, EventArgs e)
        {
            
            if (filmrad.Checked)
            {
                filmaktif();
            }



        }

        private void filmaktif() 
        {
            this.filmTableAdapter.Fill(this.mydbDataSet.film);
            filmisim.Text = "film adı";
            filmtur.Text = "tür";
            filmpuan.Text = "puan/10";
            filmkonu.Text = "yorum";

            //hepsini deaktif et
            #region serbest
            dataGridView1.Visible = false;
            notbox.Visible = false;
            notlistbox.Visible = false;
            sendbtn.Visible = false;
            #endregion
            if(checkBox1.Checked)
            {
                filmshownot.Visible = true;
                filmisim.Visible = false;
                filmtur.Visible = false;
                filmpuan.Visible = false;
                filmkonu.Visible = false;
                filmkaydetbtn.Visible = false;
                dataGridView2.Visible = true;
            }
            else 
            {
                filmshownot.Visible = false;
                dataGridView2.Visible = false;
                filmisim.Visible = true;
                filmtur.Visible = true;
                filmpuan.Visible = true;
                filmkonu.Visible = true;
                filmkaydetbtn.Visible = true;
            }
        }
        private void serbestaktif() 
        {
            this.serbestTableAdapter.Fill(this.mydbDataSet.serbest);
            //diğerlerini deaktif et
            #region film 
            filmshownot.Visible = false;
            dataGridView2.Visible = false;
            filmkaydetbtn.Visible = false;
            filmisim.Visible = false;
            filmtur.Visible = false;
            filmpuan.Visible = false;
            filmkonu.Visible = false;
            #endregion
            if (checkBox1.Checked)
            {
                sendbtn.Visible = false;
                notlistbox.Visible = true;
                notbox.ReadOnly = true;
                notbox.Visible = true;
                dataGridView1.Visible = true;
            }
            else
            {
                notbox.ReadOnly = false;
                notbox.Visible = true;
                notlistbox.Visible = true;
                dataGridView1.Visible = false;
                sendbtn.Visible = true;
            }
        }

        private void dataGridView2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            filmTableAdapter.Update(mydbDataSet);

        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            filmTableAdapter.Update(mydbDataSet);
        }

        private void filmkaydetbtn_Click(object sender, EventArgs e)
        {
            if (filmisim.Text!="")
            {
                if (filmtur.Text == "")
                    filmtur.Text = "tür bilinmiyor";
                if (filmpuan.Text == "")
                    filmpuan.Text = "puan bilinmiyor";
                if (filmkonu.Text == "")
                    filmkonu.Text = "yorum bilinmiyor";
                infolabel.Text = "";
                _command.Connection = _connection;
                _command.CommandText = "insert into film(FILM, TUR, PUAN, YORUM, TARIH) values ('" + filmisim.Text + "', '" + filmtur.Text + "','"+filmpuan.Text+"','"+filmkonu.Text+"', Now())";
                _connection.Open();
                _command.ExecuteNonQuery();
                _command.Dispose();
                _connection.Close();
                filmTableAdapter.Update(mydbDataSet);
                this.filmTableAdapter.Fill(this.mydbDataSet.film);
                filmisim.Text = "film adı";
                filmtur.Text = "tür";
                filmpuan.Text = "puan/10";
                filmkonu.Text = "yorum";
                MessageBox.Show("başarılı");
            }
            else
                infolabel.Text = "film ismi girin";
        }
    }
}
