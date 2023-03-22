using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STAJ_PROJECT
{

    public partial class start_page : Form
    {
        int i;
        int counter = 1;


        public start_page()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            try
            {
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Dosyam\STAJ PROJESI\STAJ_PROJECT\STAJ_PROJECT\Properties\click.wav");
                sound.Play();
            }
            catch { };
            this.Close();
        }



        private void btn_start_Click(object sender, EventArgs e)
        {
            Form2 table_selector = new Form2(); try { 
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Dosyam\STAJ PROJESI\STAJ_PROJECT\STAJ_PROJECT\Properties\click.wav");
            sound.Play();
            }
            catch { };


            try
            {
                for (i = 200; i <= 5000; i += 100)// all bet probability
                {
                    for (int fast = 0; fast < 2; fast++) //all fast probability
                    {
                        for (int one_to_one = 0; one_to_one < 2; one_to_one++)//all one_to_one probability
                        {
                            for (int revenge = 0; revenge < 2; revenge++)//all reveng probability
                            {
                                Table t = new Table(counter, i,
                                    (table_attribute)
                                    (fast << 0 | one_to_one << 1 | revenge << 2));

                                table_selector.tables.Add(t);


                                counter++;//we used it for table no
                            }
                        }
                    }

                }
            }
            catch { MessageBox.Show("girmiş olunduğu değer yanlış"); };// will never use it because we used track bar and check box but if we changed user interface we need to do it meybe
            table_selector.ShowDialog();
            Menu.Hide();
        }


        private void btn_start_MouseHover(object sender, EventArgs e)
        {
            try 
            {
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Dosyam\STAJ PROJESI\STAJ_PROJECT\STAJ_PROJECT\Properties\hover.wav");
                sound.Play();
            }
            catch { };
        }

        private void btn_exit_MouseHover(object sender, EventArgs e)
        {
            try { 
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"D:\Dosyam\STAJ PROJESI\STAJ_PROJECT\STAJ_PROJECT\Properties\hover.wav");
            sound.Play();
            }
            catch { };
        }
    }
}
