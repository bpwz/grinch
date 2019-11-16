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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nowe_aukcje nowe = new nowe_aukcje();
            nowe.Show();
            Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            gorace_aukcje gorace = new gorace_aukcje();
            gorace.Show();
            Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            zakonczone_aukcje zakonczone = new zakonczone_aukcje();
            zakonczone.Show();
            Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
