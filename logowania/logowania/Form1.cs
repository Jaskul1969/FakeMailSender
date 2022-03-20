using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace logowania
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
            Haslo h = new Haslo();
            
           
        }

        private void txtlogin_TextChanged(object sender, EventArgs e)
        {
            

           
                           
            
        }

        private void txtHaslo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Haslo h = new Haslo();
            StreamReader sr = new StreamReader("password.txt");
            h.haslo = sr.ReadLine();
            if (h.haslo == null)
                return; //blad
            sr.Close();

            if (txtlogin.Text == "Admin" && txtHaslo.Text == h.haslo && checkBox1.Checked)
            {
                Form2 f = new Form2();
                f.ShowDialog();
                Close();
            }
            if (txtlogin.Text == h.login && txtHaslo.Text == h.haslo)
            {
                MessageBox.Show($"Zalogowano użytkownika {h.login} pomyślnie", "Logowanie udane", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Form3 f = new Form3();
                f.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Błędne dane logowanie","Błąd",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
        }
    }
}
