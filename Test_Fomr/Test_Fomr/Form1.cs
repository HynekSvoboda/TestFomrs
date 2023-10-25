using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Fomr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            NovaHra nova=new NovaHra();
            nova.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ukoncit ukonceni = new ukoncit();
            ukonceni.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nastaveni nastaveni = new nastaveni();
            nastaveni.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader cteni = new StreamReader("hra.txt");
                Form form = new Form();
                Label label = new Label();
                List <string> list = new List<string>();
                while (!cteni.EndOfStream) 
                {
                    list.Add(cteni.ReadLine());
                }
                for(int i = 0;i<list.Count; i++) 
                {
                    form=new Form();
                    label.Location=new Point(10,10);
                    string text = list[i];
                    label=new Label();
                    label.Text = text;
                    form.Controls.Add(label);
                    form.Show();
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
