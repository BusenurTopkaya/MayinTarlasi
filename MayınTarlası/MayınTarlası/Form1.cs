using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MayınTarlası
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] mayinArray;
        int zaman;

        public void KareOlustur(int adet)
        {
            grpTarla.Controls.Clear();
            int left = 40;
            int top = 35;
            int nameId = 1;
            for (int i = 1; i <= adet; i++)
            {
                for (int j = 1; j <= adet; j++)
                {
                    var btn = new Button();
                    btn.Name = nameId.ToString();
                    btn.Width = 35;
                    btn.Height = 35;
                    btn.Top = j * top;
                    btn.Left = left;
                    btn.Click += Btn_Click;
 
                    grpTarla.Controls.Add(btn);
                    nameId++;
                }
                left += 35;
            }
        }

        public void MayinAta(int mayinAdet, int adet)
        {
            Random rnd = new Random();
            mayinArray = new int[mayinAdet];
            for (int i = 0; i < mayinAdet; i++)
            {
                int mayin = rnd.Next(0, adet);
                if (mayinArray.Contains(mayin))
                {
                    i--;
                    continue;
                }
                mayinArray[i] = mayin;
            }
        }

        public void ZamanAyarla(int prpZaman)
        {
            zaman = prpZaman;
            lblSn.Text = zaman.ToString();
            tmrTime.Start();
        }
        public void DisableButton(string clickName)
        {
            foreach (var item in grpTarla.Controls)
            {
                if (item is Button)
                {
                    var btn = (Button)item;

                    if (!string.IsNullOrEmpty(clickName) && btn.Name != clickName)
                    {
                        btn.Enabled = false;
                    }
                    else
                    {
                       btn.Enabled = false;
                    }
                
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            var clickButton = (Button)sender;

            clickButton.Text = clickButton.Name;

            if (mayinArray.Contains(Convert.ToInt32(clickButton.Name)))
            {
                clickButton.BackColor = Color.Red;

                DisableButton(clickButton.Name);

                tmrTime.Stop();

            }
            else
            {
                clickButton.Enabled = false;
                zaman += 5;
                lblSn.Text = zaman.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void kolayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KareOlustur(5);
            MayinAta(4, 25);
            ZamanAyarla(60);
        }

        private void ortaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KareOlustur(7);
            MayinAta(10, 49);
            ZamanAyarla(50);
        }

        private void zorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            KareOlustur(10);
            MayinAta(5, 100);
            ZamanAyarla(40);
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            zaman--;
            lblSn.Text = zaman.ToString();

            if (zaman <= 0)
            {
                DisableButton(string.Empty);
                tmrTime.Stop();
            }
        }
    }
}
