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
            ContBox.Hide();
            lbl4.Hide();
            emailBox.Hide();
            lbl5.Hide();
            SummBox.Hide();
            lbl6.Hide();
            lbl7.Hide();
            lbl8.Hide();
            ExpBox.Hide();
            skillBox.Hide();
            EducBox.Hide();
            wrtJson.Hide();
            LV1.Hide();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lbl1.Hide();
            btn1.Hide();
            lbl2.Show();
            NameBox.Show();
            lbl3.Show();
            ContBox.Show();
            lbl4.Show();
            emailBox.Show();    
            lbl5.Show();
            SummBox.Show();
            lbl6.Show();
            lbl7.Show();
            lbl8.Show();
            ExpBox.Show();
            skillBox.Show();
            EducBox.Show();
            wrtJson.Show();
        }

        private void filldata()
        {
            LV1.Clear();
            LV1.Columns.Add("Name", 250);
            LV1.Columns.Add("Contact#", 250);
            LV1.Columns.Add("Email", 250);
            LV1.Columns.Add("Resume Summary", 250);
            LV1.Columns.Add("Professional Experiences", 250);
            LV1.Columns.Add("Skills", 250);
            LV1.Columns.Add("Education", 250);
        }
    }
}
