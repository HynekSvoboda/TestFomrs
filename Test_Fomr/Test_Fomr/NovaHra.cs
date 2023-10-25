using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Fomr
{
    public partial class NovaHra : Form
    {
        public NovaHra()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form uloz=new Form();
            uloz.Text = "Ulozeni hry";
            uloz.ShowIcon = false;
            if (textBox1.Text != "")
            {
                StreamWriter zapis = new StreamWriter("hra.txt", true);
                zapis.WriteLine(textBox1.Text + " " + DateTime.Now);
                uloz.Show();
                MessageBox.Show("Hra uložena");
                uloz.Close();
                this.Close();
                zapis.Close();
            }
            else MessageBox.Show("Zadej jmeno");
        }
    }
}
