using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FakeMailSender
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Haslo h = new Haslo();
            StreamWriter sw = new StreamWriter("C:\\Users\\jasku\\Desktop\\programowanie\\C\\C#\\FakeMailSender\\FakeMailSender\\login.txt");
            if (textBox1.Text != null)
            {
                h.haslo = textBox1.Text;
                sw.WriteLine(textBox1);
            }


        }
    }
}
