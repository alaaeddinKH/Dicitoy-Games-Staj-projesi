using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace STAJ_PROJECT
{
    public partial class Form2 : Form
    {
        public List<Table> tables = new List<Table>();
        public Form2()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Dosyam\STAJ PROJESI\STAJ_PROJECT\STAJ_PROJECT\Properties\click.wav");
            sound.Play();
            int a = int.Parse(trackBar1.Value.ToString());
            int fast = (checkBox1.Checked) ? 1 : 0;
            int one = (checkBox2.Checked) ? 1 : 0;
            int revenge = (checkBox3.Checked) ? 1 : 0;
            Table temp = new Table(0, a, (table_attribute)(fast << 0 | one << 1 | revenge << 2));// temp object we use this only for do comparison and search
            //List<Table> _result = new List<Table>();// if i want return more true table i can add all true table to list and in the end return it
            bool flag = false;
            foreach (var item in tables)
            {
                
                if(item.Bet_Amount==temp.Bet_Amount && item.Table_Type==temp.Table_Type)
                {
                    flag = true;
                    MessageBox.Show(item.ToString(),"uygun Masa bilgileri");
                }
                
            }
            if(flag==false)
            {
                MessageBox.Show("uygun ve müsait bir masa yok şimdilik lütfen bekleyiniz", "uygun Masa bilgileri");
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            trackBar1.Value = trackBar1.Value - (trackBar1.Value % 100);//trackBar can  take undefined values so we do it
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Dosyam\STAJ PROJESI\STAJ_PROJECT\STAJ_PROJECT\Properties\track_bar_click.wav");
            sound.Play();
        }

        private void trackBar1_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Dosyam\STAJ PROJESI\STAJ_PROJECT\STAJ_PROJECT\Properties\track_bar_click.wav");
            sound.Play();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Dosyam\STAJ PROJESI\STAJ_PROJECT\STAJ_PROJECT\Properties\track_bar_click.wav");
            sound.Play();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Dosyam\STAJ PROJESI\STAJ_PROJECT\STAJ_PROJECT\Properties\track_bar_click.wav");
            sound.Play();
        }
    }
}
