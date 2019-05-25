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
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SQL sql = new SQL();
            //sql.GetDBConnection();
            dataGridView1.DataSource = sql.GetAllData();
        }

        private void AddDocumentDialogButton_Click(object sender, EventArgs e)
        {
            SQL sql = new SQL();
            AddDocument addDocument = new AddDocument();
            addDocument.statusBox.Items.AddRange(sql.getStatusList());
            addDocument.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
            DataGridView temp = (DataGridView)sender;
            if (temp.CurrentRow == null)
            {
                return;
            }
           string txtFullName = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Console.WriteLine("current row "+txtFullName);
            int id = Int32.Parse(txtFullName);  //get id

            SQL sql = new SQL();
            Record record = sql.SelectSingle(id); //get record

            EditDocument edit = new EditDocument();
            Console.WriteLine(record.doc_number);
            edit.DocumentNumber.Text =record.doc_number;
            edit.DocumentDescription.Text = record.description;


            // string[] array = sql.getStatusList();
            edit.documentId.Value = record.id;
            edit.statusBox.Items.AddRange(sql.getStatusList());
            edit.statusBox.SelectedIndex = record.status-1;
            edit.Show();
        }
    }
}
