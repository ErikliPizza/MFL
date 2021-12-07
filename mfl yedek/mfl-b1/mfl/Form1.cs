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
    public partial class Form1 : Form
    {
        public static bool opendorcontroller = true;
        private int lastKey;

        public Form1()
        {
           
            InitializeComponent();
        }

        GlobalKeyboardHook gHook;

        private void Form1_Load(object sender, EventArgs e)
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
            if (opendorcontroller)
            {
                if (lastKey == 160 && e.KeyValue == 70) // shift + f basılırsa
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
                    if (!isfilmopen)
                    {
                        film isfilm = new film();
                        isfilm.Show();
                        isfilm.BringToFront();
                        opendorcontroller = false;
                    }
                }
                if (lastKey == 160 && e.KeyValue == 68) // shift + D basılırsa
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
                    if (!isdiziopen)
                    {
                        dizi isdizi = new dizi();
                        isdizi.Show();
                        isdizi.BringToFront();
                        opendorcontroller = false;
                    }
                }
                if (lastKey == 160 && e.KeyValue == 83) // sol shift ve S basılırsa
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

                    if (!isserbestopen) //serbest bulunmadı ise
                    {
                        serbest isserbest = new serbest();
                        isserbest.Show(); //serbesti aç
                        isserbest.BringToFront(); //serbesti öne getir
                        opendorcontroller = false;
                    }
                }
            }
            if (lastKey == 160 && e.KeyValue == 84) // sol shift ve T basıldığında
            {
                this.Close(); // terminate
            }
            lastKey = e.KeyValue;


        }
    }
}
