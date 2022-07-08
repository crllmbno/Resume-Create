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
using System.IO;

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
            lbl3.Hide();
            lbl4.Hide();
            lbl5.Hide();
            lbl6.Hide();
            lbl7.Hide();
            lbl8.Hide();
            lbl9.Hide();
            lbl10.Hide();
            lbl11.Hide();
            lbl12.Hide();
            lbl13.Hide();
            lbl14.Hide();
            LastNameBox.Hide();
            FirstNameBox.Hide();
            MIBox.Hide();
            CPNoBox.Hide();
            TeleNoBox.Hide();
            emailAddBox.Hide();
            summaryBox.Hide();
            experienceBox.Hide();
            skillsBox.Hide();
            courseBox.Hide();
            UniBox.Hide();
            SYBox1.Hide();
            SYBox2.Hide();
            wrtJson.Hide();
            rdJSON.Hide();
            readJSON.Hide();

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lbl1.Hide();
            lbl2.Show();
            lbl3.Show();
            lbl4.Show();
            lbl5.Show();
            lbl6.Show();
            lbl7.Show();
            lbl8.Show();
            lbl9.Show();
            lbl10.Show();
            lbl11.Show();
            lbl12.Show();
            lbl13.Show();
            lbl14.Show();
            LastNameBox.Show();
            FirstNameBox.Show();
            MIBox.Show();
            CPNoBox.Show();
            TeleNoBox.Show();
            emailAddBox.Show();
            summaryBox.Show();
            experienceBox.Show();
            skillsBox.Show();
            courseBox.Show();
            UniBox.Show();
            SYBox1.Show();
            SYBox2.Show();
            btn1.Hide();
            wrtJson.Show();
            readJSON.Show();
            
        }

        private void wrtJson_Click(object sender, EventArgs e)
        {
            details Data = new details
            {
                Name = FirstNameBox.Text + " " + MIBox.Text + "." + " " + LastNameBox.Text,
                Contactinfo = CPNoBox.Text + " or " + TeleNoBox.Text,
                Email = emailAddBox.Text,
                Summary = summaryBox.Text,
                Experience = experienceBox.Text,
                Skills = skillsBox.Text,
                Education = courseBox.Text,
                University = UniBox.Text, 
                DateGrad = SYBox1.Text + " to " + SYBox2.Text,

            };

            string jsonToWrite = JsonConvert.SerializeObject(Data, Formatting.Indented);
            File.WriteAllText(Application.StartupPath + "\\JsonFiles\\" + LastNameBox.Text + "_" 
                + FirstNameBox.Text + ".json", jsonToWrite);
            MessageBox.Show("Saved");

            CPNoBox.Clear();
            TeleNoBox.Clear();
            emailAddBox.Clear();
            summaryBox.Clear();
            experienceBox.Clear();
            skillsBox.Clear();
            courseBox.Clear();
            UniBox.Clear();
            SYBox1.Items.Clear();
            SYBox2.Items.Clear();
        }

        private void readJSON_Click(object sender, EventArgs e)
        {
            rdJSON.Show();
            StreamReader str = new StreamReader(Application.StartupPath + "\\JsonFiles\\" + LastNameBox.Text
                + "_" + FirstNameBox.Text + ".json");
            rdJSON.Text = str.ReadToEnd();
            str.Close();
        }

        public class details
        {
            public string Name { get; set; }
            public string Contactinfo { get; set; }
            public string Email { get; set; }
            public string Summary { get; set; }
            public string Experience { get; set; }
            public string Skills { get; set; }
            public string Education { get; set; }
            public string University { get; set; }
            public string DateGrad { get; set; }

        }
    }
}
