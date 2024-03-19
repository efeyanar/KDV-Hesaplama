using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buton_Click(object sender, EventArgs e)
        {
            buton_Click(sender, e, esyalabel);
        }

        private void buton_Click(object sender, EventArgs e, Label esyalabel)
        {
            
            try
            {
            double tutar = Convert.ToDouble(textBox1.Text);
            if (tutar <= 0)
            {
                MessageBox.Show("Alışveriş Tutarı Alt Limiti 1 TL'dir.");
            }
            else
            {
                if (gidakontrol.Checked)
                {
                    double gidakdv = (tutar * 1) / 100;
                    double gidatutar = tutar + gidakdv;
                    gidalabel.Text = "KDV'Lİ FİYATI : " + gidatutar;
                    gidalabel.Font = new Font("Times New Roman", 12, FontStyle.Regular);

                    }
                

                if (tekstilkontrol.Checked)
                {
                    double tekstilkdv = (tutar * 10) / 100;
                    double tekstiltutar = tutar + tekstilkdv;
                    tekstillabel.Text = "KDV'Lİ FİYATI : " + tekstiltutar;
                    tekstillabel.Font = new Font("Times New Roman", 12, FontStyle.Bold);
                    }
                if (esyakontrol.Checked)
                {
                    double esyakdv = (tutar * 20) / 100;
                    double esyatutar = tutar + esyakdv;
                    esyalabel.Text = "KDV'Lİ FİYATI : " + esyatutar;
                    esyalabel.Font = new Font("Times New Roman", 12, FontStyle.Italic);
                }
                    buton.Enabled = false;
                    tekstilkontrol.Enabled = false;
                    gidakontrol.Enabled = false;
                    esyakontrol.Enabled = false;
                    if (tekstilkontrol.Checked == false && gidakontrol.Checked == false && esyakontrol.Checked == false)
                    {
                        MessageBox.Show("Lütfen En Az Bir Kutucuğu Doldurunuz.");
                        
                        gidakontrol.Checked = false;
                        esyakontrol.Checked = false;
                        tekstilkontrol.Checked = false;
                        gidalabel.Text = "KDV'Lİ FİYATI : ___";
                        esyalabel.Text = "KDV'Lİ FİYATI : ___";
                        tekstillabel.Text = "KDV'Lİ FİYATI : ___";
                        buton.Enabled = true;
                        tekstilkontrol.Enabled = true;
                        gidakontrol.Enabled = true;
                        esyakontrol.Enabled = true;
                        tekstillabel.Font = new Font("Times New Roman", 12, FontStyle.Regular);
                        esyalabel.Font = new Font("Times New Roman", 12, FontStyle.Regular);

                    }
                    
                
            }
        }
            catch (Exception)
            {

                MessageBox.Show("Bilgileri Doğru Girdiğinizden Emin Olunuz.");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            gidakontrol.Checked = false;
            esyakontrol.Checked = false;
            tekstilkontrol.Checked = false;
            gidalabel.Text = "KDV'Lİ FİYATI : ___";
            esyalabel.Text = "KDV'Lİ FİYATI : ___";
            tekstillabel.Text = "KDV'Lİ FİYATI : ___";
            buton.Enabled = true;
            tekstilkontrol.Enabled = true;
            gidakontrol.Enabled = true;
            esyakontrol.Enabled = true;
            tekstillabel.Font = new Font("Times New Roman", 12, FontStyle.Regular);
            esyalabel.Font = new Font("Times New Roman", 12, FontStyle.Regular);

        }
    }
}
