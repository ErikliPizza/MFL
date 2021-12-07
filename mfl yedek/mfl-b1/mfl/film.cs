using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mfl
{
    public partial class film : Form
    {
        private int lastkey;
        GlobalKeyboardHook gHook;
        public film()
        {
            InitializeComponent();
        }

        private void film_Load(object sender, EventArgs e)
        {
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
            if (lastkey == 162 && e.KeyValue == 70) // ctrl ve F basıldığında
            {
                bool isfilmopen = false;
                FormCollection fc = Application.OpenForms; // açık formları topla

                foreach (Form frm in fc) // açık formları kontrol et
                {
                    //iterate through
                    if (frm.Name == "film")//açık formlarında içinde dizi bulduysan
                    {
                        isfilmopen = true; // true yap
                        break; //döngüden direkt çık
                    }
                    else
                        isfilmopen = false; //dizi bulunmadıysa false yap
                }
                if (isfilmopen)
                {
                    Form1.opendorcontroller = true;
                    this.Close(); //terminate
                }
            }
            lastkey = e.KeyValue;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                isim.Visible = false;
                puan.Visible = false;
                tür.Visible = false;
                not.Visible = false;
                notbox.Visible = false;
                türbox.Visible = false;
                puanbox.Visible = false;
                isimbox.Visible = false;

                lisim.Visible = true;
                lisimbox.Visible = true;
                ltur.Visible = true;
                ltürbox.Visible = true;
            }
            else 
            {
                isim.Visible = true;
                puan.Visible = true;
                tür.Visible = true;
                not.Visible = true;
                notbox.Visible = true;
                türbox.Visible = true;
                puanbox.Visible = true;
                isimbox.Visible = true;
                
                lisim.Visible = false;
                lisimbox.Visible = false;
                ltur.Visible = false;
                ltürbox.Visible = false;
            }
        }
    }
}
