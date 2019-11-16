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
    public partial class gorace_aukcje : Form
    {
        public gorace_aukcje()
        {
            InitializeComponent();
            btnGoronca1.Visible = !Program.goronca1Wygrana;
            btnGoronca2.Visible = !Program.goronca2Wygrana;
            btnGoronca3.Visible = !Program.goronca3Wygrana;
            btnGoronca4.Visible = !Program.goronca4Wygrana;
            btnGoronca5.Visible = !Program.goronca5Wygrana;
            btnGoronca6.Visible = !Program.goronca6Wygrana;
            btnGoronca7.Visible = !Program.goronca7Wygrana;
        }

        public void gorocaAukcja1Wygrana()
        {
            Program.goronca1Wygrana = true;
            btnGoronca1.Visible = false;
        }
        public void gorocaAukcja2Wygrana()
        {
            Program.goronca2Wygrana = true;
            btnGoronca2.Visible = false;
        }
        public void gorocaAukcja3Wygrana()
        {
            Program.goronca3Wygrana = true;
            btnGoronca3.Visible = false;
        }
        public void gorocaAukcja4Wygrana()
        {
            Program.goronca4Wygrana = true;
            btnGoronca4.Visible = false;
        }
        public void gorocaAukcja5Wygrana()
        {
            Program.goronca5Wygrana = true;
            btnGoronca5.Visible = false;
        }
        public void gorocaAukcja6Wygrana()
        {
            Program.goronca6Wygrana = true;
            btnGoronca6.Visible = false;
        }
        public void gorocaAukcja7Wygrana()
        {
            Program.goronca7Wygrana = true;
            btnGoronca7.Visible = false;
        }

        private void btnGoronca1_Click(object sender, EventArgs e)
        {
            goronca1 goronca1 = new goronca1(this);
            goronca1.Show();
            Hide();
        }

        private void btnGoronca2_Click(object sender, EventArgs e)
        {
            goronca2 goronca2 = new goronca2(this);
            goronca2.Show();
            Hide();
        }

        private void btnGoronca3_Click(object sender, EventArgs e)
        {
            goronca3 goronca3 = new goronca3(this);
            goronca3.Show();
            Hide();
        }

        private void btnGoronca4_Click(object sender, EventArgs e)
        {
            goronca4 goronca4 = new goronca4(this);
            goronca4.Show();
            Hide();
        }

        private void btnGoronca5_Click(object sender, EventArgs e)
        {
            goronca5 goronca5 = new goronca5(this);
            goronca5.Show();
            Hide();
        }

        private void btnGoronca6_Click(object sender, EventArgs e)
        {
            goronca6 goronca6 = new goronca6(this);
            goronca6.Show();
            Hide();
        }

        private void btnGoronca7_Click(object sender, EventArgs e)
        {
            goronca7 goronca7 = new goronca7(this);
            goronca7.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Hide();
        }

        private void gorace_aukcje_Load(object sender, EventArgs e)
        {

        }
    }
}
