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
    public partial class goronca6 : Form
    {
        private gorace_aukcje gorace_Aukcje;
        public goronca6(gorace_aukcje gorace_aukcje)
        {
            InitializeComponent();
            txtOdp.Hide();
            txtpyt.Hide();
            txtMailpyt.Hide();
            txtMailOdp.Hide();
            button1.Hide();
            gorace_Aukcje = gorace_aukcje;
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
                    gorace_Aukcje.gorocaAukcja6Wygrana();
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

        private void button2_Click(object sender, EventArgs e)
        {
            gorace_aukcje gorace = new gorace_aukcje();
            gorace.Show();
            Hide();
        }

        private void goronca6_Load(object sender, EventArgs e)
        {

        }
    }
}
