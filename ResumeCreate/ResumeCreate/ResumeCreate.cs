using System;
using System.Drawing;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using PdfSharp.Drawing.Layout;

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
            newbtn.Hide();

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
            GeneratePDF();
            MessageBox.Show("Saved");

            rdJSON.Show();
            StreamReader str = new StreamReader(Application.StartupPath + "\\JsonFiles\\" + LastNameBox.Text
                + "_" + FirstNameBox.Text + ".json");
            rdJSON.Text = str.ReadToEnd();
            str.Close();

            wrtJson.Hide();
            newbtn.Show();
        }

        private void GeneratePDF()
        {
            PdfDocument doc = new PdfDocument();

            PdfPage page = doc.AddPage();

            XGraphics gfx = XGraphics.FromPdfPage(page);

            gfx.DrawString("RESUME", new XFont("Rockwell", 40, XFontStyle.Bold), XBrushes.Black,
                new XPoint(50, 50));
            
            int x = 50;

            gfx.DrawString(FirstNameBox.Text + " " + MIBox.Text + "." + " " + LastNameBox.Text,
                new XFont("Tahoma", 25, XFontStyle.Regular), XBrushes.Black, new XPoint(x, 100));

            gfx.DrawString(CPNoBox.Text + " | " + TeleNoBox.Text + " | " + emailAddBox.Text, 
                new XFont("Tahoma", 15, XFontStyle.Regular), XBrushes.Black, new XPoint(x, 120));

            gfx.DrawString(summaryBox.Text, new XFont("Tahoma", 13, XFontStyle.Regular),
                XBrushes.Black, new XPoint(x, 170));

            gfx.DrawString(experienceBox.Text, new XFont("Tahoma", 13, XFontStyle.Regular),
                XBrushes.Black, new XPoint(x, 200));

            gfx.DrawString(skillsBox.Text, new XFont("Tahoma", 13, XFontStyle.Regular),
                XBrushes.Black, new XPoint(x, 250));

            gfx.DrawString(courseBox.Text, new XFont("Tahoma", 23, XFontStyle.Regular), 
                XBrushes.Black, new XPoint(x, 350));

            gfx.DrawString(UniBox.Text, new XFont("Tahoma", 15, XFontStyle.Regular),
                XBrushes.Black, new XPoint(x, 370));

            gfx.DrawString(SYBox1.Text + " - " + SYBox2.Text, new XFont("Tahoma", 12, XFontStyle.Regular),
                XBrushes.Black, new XPoint(x, 390));


            doc.Save(Application.StartupPath + "\\PDF\\" + LastNameBox.Text + "_" + FirstNameBox.Text + ".pdf");
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

        private void newbtn_Click(object sender, EventArgs e)
        {
            LastNameBox.Clear();
            FirstNameBox.Clear();
            MIBox.Clear();
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
            rdJSON.Clear();
            wrtJson.Show();
            rdJSON.Hide();
            newbtn.Hide();
        }
    }
}
