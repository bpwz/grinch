using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hackathon
{
    public partial class nowe_aukcje : Form
    {
        public nowe_aukcje()
        {
            InitializeComponent();
            button1.Visible = !Program.nowe1Wygrana;
            button2.Visible = !Program.nowe2Wygrana;
            button3.Visible = !Program.nowe3Wygrana;
            button4.Visible = !Program.nowe4Wygrana;

        }
        public void nowe1Wygrana()
        {
            Program.nowe1Wygrana = true;
            button1.Visible = false;
        }
        public void nowe2Wygrana()
        {
            Program.nowe2Wygrana = true;
            button2.Visible = false;
        }
        public void nowe3Wygrana()
        {
            Program.nowe3Wygrana = true;
            button3.Visible = false;
        }
        public void nowe4Wygrana()
        {
            Program.nowe4Wygrana = true;
            button4.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            nowe_aukcje_1 nowe_aukcje_1 = new nowe_aukcje_1(this);
            nowe_aukcje_1.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nowe_aukcje_2 nowe_aukcje_2 = new nowe_aukcje_2(this);
            nowe_aukcje_2.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nowe_aukcje_3 nowe_aukcje_3 = new nowe_aukcje_3(this);
            nowe_aukcje_3.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nowe_aukcje_4 nowe_aukcje_4 = new nowe_aukcje_4(this);
            nowe_aukcje_4.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Hide();
        }

        private void nowe_aukcje_Load(object sender, EventArgs e)
        {

        }
    }
}
