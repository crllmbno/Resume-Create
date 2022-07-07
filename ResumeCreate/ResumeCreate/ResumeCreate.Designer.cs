namespace ResumeCreate
{
    partial class ResumeCreate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.NameBox = new System.Windows.Forms.TextBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.SummBox = new System.Windows.Forms.TextBox();
            this.lbl3 = new System.Windows.Forms.Label();
            this.ContBox = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.lbl6 = new System.Windows.Forms.Label();
            this.ExpBox = new System.Windows.Forms.TextBox();
            this.lbl7 = new System.Windows.Forms.Label();
            this.skillBox = new System.Windows.Forms.TextBox();
            this.lbl8 = new System.Windows.Forms.Label();
            this.EducBox = new System.Windows.Forms.TextBox();
            this.wrtJson = new System.Windows.Forms.Button();
            this.LV1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Rockwell", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl1.Location = new System.Drawing.Point(256, 243);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(721, 106);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Resume Create";
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Transparent;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Calibri Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn1.Location = new System.Drawing.Point(488, 352);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(235, 38);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "Create your own resume";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // tmr
            // 
            this.tmr.Enabled = true;
            this.tmr.Interval = 1000;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(279, 105);
            this.NameBox.MaxLength = 40;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(266, 27);
            this.NameBox.TabIndex = 2;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.White;
            this.lbl2.Location = new System.Drawing.Point(160, 109);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(113, 23);
            this.lbl2.TabIndex = 0;
            this.lbl2.Text = "Full Name:";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.Color.White;
            this.lbl5.Location = new System.Drawing.Point(160, 144);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(189, 23);
            this.lbl5.TabIndex = 3;
            this.lbl5.Text = "Resume Summary:";
            // 
            // SummBox
            // 
            this.SummBox.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummBox.Location = new System.Drawing.Point(355, 138);
            this.SummBox.MaxLength = 300;
            this.SummBox.Multiline = true;
            this.SummBox.Name = "SummBox";
            this.SummBox.Size = new System.Drawing.Size(737, 82);
            this.SummBox.TabIndex = 4;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.White;
            this.lbl3.Location = new System.Drawing.Point(571, 109);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(109, 23);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Contact #:";
            // 
            // ContBox
            // 
            this.ContBox.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContBox.Location = new System.Drawing.Point(686, 105);
            this.ContBox.MaxLength = 11;
            this.ContBox.Name = "ContBox";
            this.ContBox.Size = new System.Drawing.Size(98, 27);
            this.ContBox.TabIndex = 6;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ForeColor = System.Drawing.Color.White;
            this.lbl4.Location = new System.Drawing.Point(799, 109);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(70, 23);
            this.lbl4.TabIndex = 7;
            this.lbl4.Text = "Email:";
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(875, 105);
            this.emailBox.MaxLength = 32;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(217, 27);
            this.emailBox.TabIndex = 8;
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.ForeColor = System.Drawing.Color.White;
            this.lbl6.Location = new System.Drawing.Point(160, 233);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(251, 23);
            this.lbl6.TabIndex = 9;
            this.lbl6.Text = "Professional Experience:";
            // 
            // ExpBox
            // 
            this.ExpBox.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpBox.Location = new System.Drawing.Point(417, 233);
            this.ExpBox.MaxLength = 3000;
            this.ExpBox.Multiline = true;
            this.ExpBox.Name = "ExpBox";
            this.ExpBox.Size = new System.Drawing.Size(675, 82);
            this.ExpBox.TabIndex = 10;
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl7.ForeColor = System.Drawing.Color.White;
            this.lbl7.Location = new System.Drawing.Point(160, 322);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(205, 23);
            this.lbl7.TabIndex = 11;
            this.lbl7.Text = "Skills/Certifications:";
            // 
            // skillBox
            // 
            this.skillBox.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillBox.Location = new System.Drawing.Point(371, 322);
            this.skillBox.MaxLength = 3000;
            this.skillBox.Multiline = true;
            this.skillBox.Name = "skillBox";
            this.skillBox.Size = new System.Drawing.Size(721, 82);
            this.skillBox.TabIndex = 12;
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Font = new System.Drawing.Font("Rockwell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl8.ForeColor = System.Drawing.Color.White;
            this.lbl8.Location = new System.Drawing.Point(160, 414);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(112, 23);
            this.lbl8.TabIndex = 13;
            this.lbl8.Text = "Education:";
            // 
            // EducBox
            // 
            this.EducBox.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EducBox.Location = new System.Drawing.Point(278, 414);
            this.EducBox.MaxLength = 3000;
            this.EducBox.Multiline = true;
            this.EducBox.Name = "EducBox";
            this.EducBox.Size = new System.Drawing.Size(814, 82);
            this.EducBox.TabIndex = 14;
            // 
            // wrtJson
            // 
            this.wrtJson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wrtJson.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wrtJson.ForeColor = System.Drawing.Color.White;
            this.wrtJson.Location = new System.Drawing.Point(1007, 502);
            this.wrtJson.Name = "wrtJson";
            this.wrtJson.Size = new System.Drawing.Size(85, 34);
            this.wrtJson.TabIndex = 15;
            this.wrtJson.Text = "writeJSON";
            this.wrtJson.UseVisualStyleBackColor = true;
            // 
            // LV1
            // 
            this.LV1.HideSelection = false;
            this.LV1.Location = new System.Drawing.Point(85, 43);
            this.LV1.Name = "LV1";
            this.LV1.Size = new System.Drawing.Size(1058, 566);
            this.LV1.TabIndex = 16;
            this.LV1.UseCompatibleStateImageBehavior = false;
            // 
            // ResumeCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1221, 669);
            this.Controls.Add(this.LV1);
            this.Controls.Add(this.wrtJson);
            this.Controls.Add(this.EducBox);
            this.Controls.Add(this.lbl8);
            this.Controls.Add(this.skillBox);
            this.Controls.Add(this.lbl7);
            this.Controls.Add(this.ExpBox);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.ContBox);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.SummBox);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lbl1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "ResumeCreate";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resume Create";
            this.Load += new System.EventHandler(this.ResumeCreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.TextBox SummBox;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.TextBox ContBox;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.TextBox ExpBox;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.TextBox skillBox;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.TextBox EducBox;
        private System.Windows.Forms.Button wrtJson;
        private System.Windows.Forms.ListView LV1;
    }
}

