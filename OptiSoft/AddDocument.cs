using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptiSoft
{
    public partial class AddDocument : Form
    {
        public AddDocument()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String number = DocumentNumber.Text;
            String description = DocumentDescription.Text;
            String dateTime = DocumentDate.Value.ToShortDateString();
            Console.WriteLine(number);Console.WriteLine(description); Console.WriteLine(dateTime);


            if(number!=null && description!=null && dateTime!=null)
            {
                SQL sql = new SQL();
                sql.InsertData(dateTime,description,1,number);
            }
        }
    }
}
