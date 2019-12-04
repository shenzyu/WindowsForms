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
using WindowsForms.Model;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void queryDate_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext dc = new DataClasses1DataContext())
            {
                var result = from a in dc.category
                             select a;
                foreach(var c in result)
                {
                    Debug.WriteLine("country category_name:" + c.category_name);
                    Debug.WriteLine("parent_id:" + c.parent_id);
                    Debug.WriteLine("is_leaf:" + c.is_leaf);
                    Debug.WriteLine("id:" + c.id);
                }
                
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
