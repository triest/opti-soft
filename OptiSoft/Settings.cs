using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptiSoft
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Test_Click(object sender, EventArgs e)
        {
            /*Console.WriteLine(ServerName.Text);
            Console.WriteLine(User.Text);
            Console.WriteLine(Password.Text);
            Console.WriteLine(Database.Text);*/
            SQL sql = new SQL();
            bool rez=sql.TestConnect(ServerName.Text, User.Text, Password.Text, Database.Text);

            if (rez)
            {
                Console.WriteLine("connenct");

            }
            else
            {
                Console.WriteLine("no connect");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (StreamWriter writetext = new StreamWriter("write.txt"))
            {
                writetext.WriteLine(ServerName.Text);
                writetext.WriteLine(User.Text);
                writetext.WriteLine(Database.Text);
                writetext.WriteLine(Password.Text);

            }
        }
    }
}
