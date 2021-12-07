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
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            this.serbestTableAdapter.Fill(this.mydbDataSet.serbest);
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


        private void sendbtn_Click(object sender, EventArgs e)
        {
            if (notbox.Text != "" && notlistbox.SelectedIndex >= 0)
            {
                string konu = notlistbox.SelectedItem.ToString();
                _command.Connection = _connection;
                _command.CommandText = "insert into serbest(NOTUN, KONU, TARIH) values ('" + notbox.Text + "', '" + konu + "',Now())";
                _connection.Open();
                _command.ExecuteNonQuery();
                _command.Dispose();
                _connection.Close();
                serbestTableAdapter.Update(mydbDataSet);
                this.serbestTableAdapter.Fill(this.mydbDataSet.serbest);
                MessageBox.Show("başarılı");
            }
            else
                infolabel.Text = "not ve kategori girişi yapın";
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                notbox.ReadOnly = true;
                notaralabel.Visible = true;
                sendbtn.Visible = false;
                dataGridView1.Visible = true;
                //bindingNavigator1.Visible = true;
                filtrebox.Visible = true;
                silbtn.Visible = true;
                kaydetbtn.Visible = true;
                notbtn.Visible = true;
            }
            else
            {
                notbox.ReadOnly = false;
                notaralabel.Visible = false;
                sendbtn.Visible = true;
                dataGridView1.Visible = false;
                //bindingNavigator1.Visible = false;
                filtrebox.Visible = false;
                silbtn.Visible = false;
                kaydetbtn.Visible = false;
                notbtn.Visible = false;
            }
        }



        private void infolabel_Click(object sender, EventArgs e)
        {

        }

        private void notbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.RemoveAt(row.Index);
            }
            serbestTableAdapter.Update(mydbDataSet);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
            {
                notbox.Text = dataGridView1.CurrentCell.Value.ToString();
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            serbestTableAdapter.Update(mydbDataSet);

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
            string selectedlkn = notlistbox.SelectedItem.ToString();
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridView1.DataSource;
            dataGridView1.DataSource = bs;
            bs.Filter = "[NOTUN] like '%" + filtrebox.Text + "%'" +
                "AND[KONU]like '%" + selectedlkn + "%'";
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
    }
}
