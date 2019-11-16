using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace hackathon
{
    public partial class nowe_aukcje_2 : Form
    {
        private nowe_aukcje nowe_Aukcje;
        public nowe_aukcje_2(nowe_aukcje nowe_aukcje)
        {
            InitializeComponent();
            txtOdp.Hide();
            txtpyt.Hide();
            txtMailpyt.Hide();
            txtMailOdp.Hide();
            button1.Hide();
            nowe_Aukcje = nowe_aukcje;
    }

        private void button1_Click(object sender, EventArgs e)
        {
            string odpowiedz = txtOdp.Text;
            string mail = txtMailOdp.Text;
            if (odpowiedz == "T")
            {


                MailMessage wiadomosc = new MailMessage();
                wiadomosc.From = new System.Net.Mail.MailAddress("krystian.kisielow@gmail.com");
                wiadomosc.Subject = "dane logowania";
                wiadomosc.Body = "login to:  ";
                wiadomosc.To.Add(mail);
                SmtpClient client = new SmtpClient();
                client.Credentials = new NetworkCredential("krystian.kisielow@gmail.com", "Rudik2004#" +
                    "");
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.Send(wiadomosc);
                Form2 form2 = new Form2();
                form2.Show();
                Hide();
            }
            else if (odpowiedz == "N")
            {
                Form2 form2 = new Form2();
                form2.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("nie podałeś dobrej litery");
                Form2 form2 = new Form2();
                form2.Show();
                Hide();
            }
        }

        private void txtOdp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpyt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMailOdp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMailpyt_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSprawdz_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int poczatek = 0;
            int koniec = 1000;
            int wylosowana = rnd.Next(poczatek, koniec);
            if (int.TryParse(txtCena.Text, out int twojaliczba))
            {
                if (twojaliczba > wylosowana)
                {
                    nowe_Aukcje.nowe2Wygrana();
                    txtKoniec.Text = "Brawo! Wygrałeś aukcję ";
                    txtpyt.Show();
                    txtOdp.Show();
                    txtMailOdp.Show();
                    txtMailpyt.Show();
                    button1.Show();
                }
                if (twojaliczba < wylosowana)
                {
                    txtKoniec.Text = "zamala";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nowe_aukcje nowe = new nowe_aukcje();
            nowe.Show();
            Hide();
        }

        private void nowe_aukcje_2_Load(object sender, EventArgs e)
        {

        }
    }
}
