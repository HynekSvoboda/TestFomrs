using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Fomr
{
    public partial class ukoncit : Form
    {
        public ukoncit()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        bool jedna = true;

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.DialogResult = DialogResult.OK;
            if (jedna)
            {
                Random random = new Random();
                int x = random.Next(0, 150);
                int y = random.Next(0, 150);
                button1.Location = new Point(x, y);
                jedna = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
