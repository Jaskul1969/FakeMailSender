using System.Diagnostics.Eventing.Reader;

namespace FakeMailSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            StreamReader sr = new StreamReader("C:\\Users\\jasku\\Desktop\\programowanie\\C\\C#\\FakeMailSender\\FakeMailSender\\login.txt");
            StreamReader fr = new StreamReader("C:\\Users\\jasku\\Desktop\\programowanie\\C\\C#\\FakeMailSender\\psswrd.txt");
            Haslo h = new Haslo();
            h.login = sr.ReadLine();
            h.haslo = fr.ReadLine();
            if (textBox1.Text == h.login && textBox2.Text == h.haslo)
            {
                MessageBox.Show($"Zalogowano u¿ytkownika {h.login} pomyœlnie", "Logowanie udane", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form3 f = new Form3();
                f.ShowDialog();

            }
            else
            {
                MessageBox.Show("B³êdne dane logowanie", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("C:\\Users\\jasku\\Desktop\\programowanie\\C\\C#\\FakeMailSender\\FakeMailSender\\login.txt");
            StreamReader fr = new StreamReader("C:\\Users\\jasku\\Desktop\\programowanie\\C\\C#\\FakeMailSender\\psswrd.txt");
            Haslo h = new Haslo();
            h.login = sr.ReadLine();
            h.haslo = fr.ReadLine();
            if (textBox1.Text == h.login && textBox2.Text == h.haslo)
            {
                MessageBox.Show($"Zalogowano u¿ytkownika {h.login} pomyœlnie", "Logowanie udane", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form2 f = new Form2();
                f.ShowDialog();
                Form1 n = new Form1();
                n.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}