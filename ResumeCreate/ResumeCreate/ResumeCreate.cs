using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResumeCreate
{
    public partial class ResumeCreate : Form
    {
        public ResumeCreate()
        {
            InitializeComponent();
        }

        private void ResumeCreate_Load(object sender, EventArgs e)
        {
            lbl1.ForeColor = Color.White;
            btn1.ForeColor = Color.White;
            lbl2.Hide();
            NameBox.Hide();
            lbl3.Hide();
            SummBox.Hide();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lbl1.Hide();
            btn1.Hide();
            lbl2.Show();
            NameBox.Show();
            lbl3.Show();
            SummBox.Show();
        }
    }
}
