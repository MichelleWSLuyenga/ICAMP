namespace Hades
{
    partial class RegisterActivities
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
            this.dateRA = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AddSubject = new System.Windows.Forms.GroupBox();
            this.add = new System.Windows.Forms.Button();
            this.subjectName = new System.Windows.Forms.TextBox();
            this.subjects = new System.Windows.Forms.ComboBox();
            this.Subject3 = new System.Windows.Forms.GroupBox();
            this.del3 = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.Subject5 = new System.Windows.Forms.GroupBox();
            this.del5 = new System.Windows.Forms.Button();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.Subject4 = new System.Windows.Forms.GroupBox();
            this.del4 = new System.Windows.Forms.Button();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.Subject2 = new System.Windows.Forms.GroupBox();
            this.del2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.Subject1 = new System.Windows.Forms.GroupBox();
            this.del1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.AddSubject.SuspendLayout();
            this.Subject3.SuspendLayout();
            this.Subject5.SuspendLayout();
            this.Subject4.SuspendLayout();
            this.Subject2.SuspendLayout();
            this.Subject1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateRA
            // 
            this.dateRA.Location = new System.Drawing.Point(153, 12);
            this.dateRA.Name = "dateRA";
            this.dateRA.Size = new System.Drawing.Size(294, 20);
            this.dateRA.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AddSubject);
            this.groupBox1.Controls.Add(this.Subject3);
            this.groupBox1.Controls.Add(this.Subject5);
            this.groupBox1.Controls.Add(this.Subject4);
            this.groupBox1.Controls.Add(this.Subject2);
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 375);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // AddSubject
            // 
            this.AddSubject.Controls.Add(this.add);
            this.AddSubject.Controls.Add(this.subjectName);
            this.AddSubject.Controls.Add(this.subjects);
            this.AddSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSubject.Location = new System.Drawing.Point(415, 189);
            this.AddSubject.Name = "AddSubject";
            this.AddSubject.Size = new System.Drawing.Size(200, 186);
            this.AddSubject.TabIndex = 4;
            this.AddSubject.TabStop = false;
            this.AddSubject.Text = "Add Subject";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(58, 129);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 41);
            this.add.TabIndex = 2;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // subjectName
            // 
            this.subjectName.Location = new System.Drawing.Point(22, 84);
            this.subjectName.Name = "subjectName";
            this.subjectName.Size = new System.Drawing.Size(157, 23);
            this.subjectName.TabIndex = 1;
            // 
            // subjects
            // 
            this.subjects.FormattingEnabled = true;
            this.subjects.Items.AddRange(new object[] {
            "Subject1",
            "Subject2",
            "Subject3",
            "Subject4",
            "Subject5"});
            this.subjects.Location = new System.Drawing.Point(22, 32);
            this.subjects.Name = "subjects";
            this.subjects.Size = new System.Drawing.Size(157, 24);
            this.subjects.TabIndex = 0;
            // 
            // Subject3
            // 
            this.Subject3.Controls.Add(this.del3);
            this.Subject3.Controls.Add(this.listBox3);
            this.Subject3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject3.Location = new System.Drawing.Point(430, 0);
            this.Subject3.Name = "Subject3";
            this.Subject3.Size = new System.Drawing.Size(200, 174);
            this.Subject3.TabIndex = 3;
            this.Subject3.TabStop = false;
            this.Subject3.Text = "Subject3";
            // 
            // del3
            // 
            this.del3.BackColor = System.Drawing.Color.Transparent;
            this.del3.Location = new System.Drawing.Point(58, 137);
            this.del3.Name = "del3";
            this.del3.Size = new System.Drawing.Size(75, 23);
            this.del3.TabIndex = 1;
            this.del3.Text = "Delete";
            this.del3.UseVisualStyleBackColor = false;
            this.del3.Click += new System.EventHandler(this.del3_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 16;
            this.listBox3.Location = new System.Drawing.Point(6, 31);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(188, 100);
            this.listBox3.TabIndex = 0;
            // 
            // Subject5
            // 
            this.Subject5.Controls.Add(this.del5);
            this.Subject5.Controls.Add(this.listBox5);
            this.Subject5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject5.Location = new System.Drawing.Point(200, 199);
            this.Subject5.Name = "Subject5";
            this.Subject5.Size = new System.Drawing.Size(200, 174);
            this.Subject5.TabIndex = 2;
            this.Subject5.TabStop = false;
            this.Subject5.Text = "Subject5";
            // 
            // del5
            // 
            this.del5.BackColor = System.Drawing.Color.Transparent;
            this.del5.Location = new System.Drawing.Point(58, 137);
            this.del5.Name = "del5";
            this.del5.Size = new System.Drawing.Size(75, 23);
            this.del5.TabIndex = 1;
            this.del5.Text = "Delete";
            this.del5.UseVisualStyleBackColor = false;
            this.del5.Click += new System.EventHandler(this.del5_Click);
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 16;
            this.listBox5.Location = new System.Drawing.Point(6, 31);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(188, 100);
            this.listBox5.TabIndex = 0;
            // 
            // Subject4
            // 
            this.Subject4.Controls.Add(this.del4);
            this.Subject4.Controls.Add(this.listBox4);
            this.Subject4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject4.Location = new System.Drawing.Point(0, 199);
            this.Subject4.Name = "Subject4";
            this.Subject4.Size = new System.Drawing.Size(200, 174);
            this.Subject4.TabIndex = 2;
            this.Subject4.TabStop = false;
            this.Subject4.Text = "Subject4";
            // 
            // del4
            // 
            this.del4.BackColor = System.Drawing.Color.Transparent;
            this.del4.Location = new System.Drawing.Point(58, 137);
            this.del4.Name = "del4";
            this.del4.Size = new System.Drawing.Size(75, 23);
            this.del4.TabIndex = 1;
            this.del4.Text = "Delete";
            this.del4.UseVisualStyleBackColor = false;
            this.del4.Click += new System.EventHandler(this.del4_Click);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.ItemHeight = 16;
            this.listBox4.Location = new System.Drawing.Point(6, 31);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(188, 100);
            this.listBox4.TabIndex = 0;
            // 
            // Subject2
            // 
            this.Subject2.Controls.Add(this.del2);
            this.Subject2.Controls.Add(this.listBox2);
            this.Subject2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject2.Location = new System.Drawing.Point(215, 0);
            this.Subject2.Name = "Subject2";
            this.Subject2.Size = new System.Drawing.Size(200, 174);
            this.Subject2.TabIndex = 1;
            this.Subject2.TabStop = false;
            this.Subject2.Text = "Subject2";
            // 
            // del2
            // 
            this.del2.BackColor = System.Drawing.Color.Transparent;
            this.del2.Location = new System.Drawing.Point(58, 137);
            this.del2.Name = "del2";
            this.del2.Size = new System.Drawing.Size(75, 23);
            this.del2.TabIndex = 1;
            this.del2.Text = "Delete";
            this.del2.UseVisualStyleBackColor = false;
            this.del2.Click += new System.EventHandler(this.del2_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(6, 31);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(188, 100);
            this.listBox2.TabIndex = 0;
            // 
            // Subject1
            // 
            this.Subject1.Controls.Add(this.del1);
            this.Subject1.Controls.Add(this.listBox1);
            this.Subject1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject1.Location = new System.Drawing.Point(12, 48);
            this.Subject1.Name = "Subject1";
            this.Subject1.Size = new System.Drawing.Size(200, 174);
            this.Subject1.TabIndex = 0;
            this.Subject1.TabStop = false;
            this.Subject1.Text = "Subject1";
            // 
            // del1
            // 
            this.del1.BackColor = System.Drawing.Color.Transparent;
            this.del1.Location = new System.Drawing.Point(58, 137);
            this.del1.Name = "del1";
            this.del1.Size = new System.Drawing.Size(75, 23);
            this.del1.TabIndex = 1;
            this.del1.Text = "Delete";
            this.del1.UseVisualStyleBackColor = false;
            this.del1.Click += new System.EventHandler(this.del1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(6, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 100);
            this.listBox1.TabIndex = 0;
            // 
            // RegisterActivities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(654, 432);
            this.Controls.Add(this.Subject1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateRA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RegisterActivities";
            this.Text = "RegisterActivities";
            this.Load += new System.EventHandler(this.RegisterActivities_Load);
            this.groupBox1.ResumeLayout(false);
            this.AddSubject.ResumeLayout(false);
            this.AddSubject.PerformLayout();
            this.Subject3.ResumeLayout(false);
            this.Subject5.ResumeLayout(false);
            this.Subject4.ResumeLayout(false);
            this.Subject2.ResumeLayout(false);
            this.Subject1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateRA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Subject4;
        private System.Windows.Forms.GroupBox Subject5;
        private System.Windows.Forms.Button del5;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.Button del4;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.GroupBox Subject2;
        private System.Windows.Forms.Button del2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.GroupBox Subject1;
        private System.Windows.Forms.Button del1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox AddSubject;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox subjectName;
        private System.Windows.Forms.ComboBox subjects;
        private System.Windows.Forms.GroupBox Subject3;
        private System.Windows.Forms.Button del3;
        private System.Windows.Forms.ListBox listBox3;
    }
}