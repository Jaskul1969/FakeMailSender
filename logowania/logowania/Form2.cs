using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logowania
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Haslo h = new Haslo();
            h.haslo = "";
        }

        public void btnUstaw_Click(object sender, EventArgs e)
        {
            Haslo h = new Haslo();
            h.haslo = txtNoweHaslo.Text;
            if (h.haslo == txtNoweHaslo.Text)
            {
                MessageBox.Show("Hasło zostało pomyślnie zmienione", "Zmiana hasła", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form1 f=new Form1();
                f.ShowDialog();

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
