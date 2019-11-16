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
    public partial class zakonczone_aukcje : Form

    
    {
       
        public zakonczone_aukcje()
        {
            InitializeComponent();
            button1.Visible = Program.goronca1Wygrana;
            button2.Visible = Program.goronca2Wygrana;
            button3.Visible = Program.goronca3Wygrana;
            button4.Visible = Program.goronca4Wygrana;
            button5.Visible = Program.goronca5Wygrana;
            button6.Visible = Program.goronca6Wygrana;
            button7.Visible = Program.goronca7Wygrana;
            button8.Visible = Program.nowe1Wygrana;
            button9.Visible = Program.nowe2Wygrana;
            button10.Visible = Program.nowe3Wygrana;
            button11.Visible = Program.nowe4Wygrana;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Hide();
        }

        private void btnCofniecie_Click(object sender, EventArgs e)
        {
           
        }

        private void zakonczone_aukcje_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Hide();
        }
    }
}
