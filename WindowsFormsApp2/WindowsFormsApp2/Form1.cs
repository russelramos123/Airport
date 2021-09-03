using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (QAEntities db = new QAEntities())
            {
                string[] obj = db.Table1_ListCategory().ToArray();

                foreach (string item in obj)
                {
                    Debug.WriteLine(item);
                }

                DateTime from, to;
                from = Convert.ToDateTime("2021-08-19");
                to = Convert.ToDateTime("2021-08-19");

                List<Table1_GetTransactions_Result> data = db.Table1_GetTransactions(from, to).ToList();

                foreach ( var item in data)
                {
                    Debug.WriteLine(item.product);
                }
            }
        }
    }
}
