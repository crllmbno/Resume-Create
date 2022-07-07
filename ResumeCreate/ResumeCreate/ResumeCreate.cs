using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft;

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
            
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lbl1.Hide();
            btn1.Hide();
        }

        private void wrtJson_Click(object sender, EventArgs e)
        {
            _ = new Details();
            {
             
            }
        }
        

        public class Details
        {
            public string Name { get; set; }
            public int ContactNo { get; set; }
            public string Email { get; set; }
            public string Summary { get; set; }
            public string Experience { get; set; }
            public string Skills { get; set; }
            public string Education { get; set; }

        }
    }
}
