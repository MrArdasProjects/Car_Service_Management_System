using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArunaCarServices
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Kayıt_Click(object sender, EventArgs e)
        {
            string musteriIsmi = txt_musteriismi.Text;
            string musteriSoyisim = txt_musterisoyisim.Text;
            string musteriTelefon = txt_telefon.Text;
            string musteriMail = txt_musterimail.Text;
            string musteriAdres = txt_adress.Text;
            string plaka = txt_plaka.Text;
            string aracModeli = txt_aracmodel.Text;
            string uretimYili = txt_uretimyili.Text;
            string renk = txt_renk.Text;
            string kilometre = textBox10_km.Text;
        }
    }
}
