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
    public partial class dizi : Form
    {
        private int lastkey;
        GlobalKeyboardHook gHook;

        public dizi()
        {
            InitializeComponent();
        }

        private void dizi_Load(object sender, EventArgs e)
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
            if (lastkey == 162 && e.KeyValue == 68) // ctrl ve S basıldığında
            {
                bool isdiziopen = false;
                FormCollection fc = Application.OpenForms; // açık formları topla

                foreach (Form frm in fc) // açık formları kontrol et
                {
                    //iterate through
                    if (frm.Name == "dizi")//açık formlarında içinde dizi bulduysan
                    {
                        isdiziopen = true; // true yap
                        break; //döngüden direkt çık
                    }
                    else
                        isdiziopen = false; //dizi bulunmadıysa false yap
                }
                if (isdiziopen)
                {
                    this.Close(); //terminate
                    Form1.opendorcontroller = true;
                }
            }
            lastkey = e.KeyValue;
        }
    }
}
