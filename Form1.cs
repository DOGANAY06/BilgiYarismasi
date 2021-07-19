using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false; //butona dokunma özelliği kapalı 
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            label5.Text = BtnB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                Pic2.Visible = true;
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false; //butona dokunma özelliği kapalı 
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            label5.Text = BtnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                Pic2.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false; //butona dokunma özelliği kapalı 
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            label5.Text = BtnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true;

            }
            else
            {
                yanlis++;
                LblYanlis.Text = yanlis.ToString();
                Pic2.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnA.Enabled = false; //butona dokunma özelliği kapalı 
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;
            label5.Text = BtnA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++; //dogru artsın
                LblDogru.Text = dogru.ToString();
                pictureBox1.Visible = true; //yesil yansınn
            }
            else
            {
                yanlis++; //yanlis artsın
                LblYanlis.Text = yanlis.ToString();
                Pic2.Visible = true; //kırmızı yansınn
            }
        }

        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;
            pictureBox1.Visible = false;
            Pic2.Visible = false;
            soruno++;
            LblSoruNo.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir ?";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                label4.Text = "1923"; //doğru cevabı tutar
                
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "İstiklal Marşı Yazarı ?";
                BtnA.Text = "Neşet Ertaş";
                BtnB.Text = "Ali Ertaş";
                BtnC.Text = "Mehmet Akif Ersoy";
                BtnD.Text = "M.K. Atatürk";
                label4.Text = "Mehmet Akif Ersoy"; //doğru cevabı tutar

            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Osmanlı Başkenti Neresiydi ?";
                BtnA.Text = "Ankara";
                BtnB.Text = "Adıyaman";
                BtnC.Text = "Sivas";
                BtnD.Text = "İstanbul";
                label4.Text = "İstanbul"; //doğru cevabı tutar
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Türkiye'nin Başkenti Neresi  ?";
                BtnA.Text = "Ankara";
                BtnB.Text = "Adıyaman";
                BtnC.Text = "Sivas";
                BtnD.Text = "İstanbul";
                label4.Text = "Ankara"; //doğru cevabı tutar
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Türkiye Cumhuriyet'i Cumhurbaşkanı kimdir ?";
                BtnA.Text = "Kemal Kılıçdaroğlu";
                BtnB.Text = "Recep Tayyip Erdoğan";
                BtnC.Text = "Devlet Bahceli";
                BtnD.Text = "Meral Akşener";
                label4.Text = "Recep Tayyip Erdoğan"; //doğru cevabı tutar
                BtnSonraki.Text = "Sonuçlar";
            }

            if (soruno==6)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;
                MessageBox.Show("Doğru: " + dogru + "\n " + "Yanlış: " + yanlis);
            }
        }
    }
}
