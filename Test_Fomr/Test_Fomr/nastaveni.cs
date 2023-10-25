using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Test_Fomr
{
    public partial class nastaveni : Form
    {
        public nastaveni()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        ColorDialog cd;
        public  Color barva = Color.White;
        public  Font font = null;
        FontDialog fontDialog;

        private void button1_Click(object sender, EventArgs e)
        {
            cd=new ColorDialog();
            cd.ShowDialog();
            barva = cd.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fontDialog = new FontDialog();
            fontDialog.ShowDialog();
            font=fontDialog.Font;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.BackColor = barva;
            this.Font = font;
            if(checkBox1.Checked)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else this.WindowState= FormWindowState.Normal;
        }
    }
}
