namespace Hades
{
    partial class Register
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
            this.Session = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Parent2 = new System.Windows.Forms.GroupBox();
            this.parent2Email = new System.Windows.Forms.TextBox();
            this.P2Email = new System.Windows.Forms.Label();
            this.parent2No = new System.Windows.Forms.TextBox();
            this.P2No = new System.Windows.Forms.Label();
            this.parent2Name = new System.Windows.Forms.TextBox();
            this.P2Name = new System.Windows.Forms.Label();
            this.Parent1 = new System.Windows.Forms.GroupBox();
            this.P1Email = new System.Windows.Forms.Label();
            this.parent1Email = new System.Windows.Forms.TextBox();
            this.parent1No = new System.Windows.Forms.TextBox();
            this.P1No = new System.Windows.Forms.Label();
            this.parent1Name = new System.Windows.Forms.TextBox();
            this.P1Name = new System.Windows.Forms.Label();
            this.Camper = new System.Windows.Forms.GroupBox();
            this.camperLeavedate = new System.Windows.Forms.DateTimePicker();
            this.camperStartdate = new System.Windows.Forms.DateTimePicker();
            this.camperTransportation = new System.Windows.Forms.TextBox();
            this.camperMedications = new System.Windows.Forms.TextBox();
            this.camperRestriction = new System.Windows.Forms.TextBox();
            this.camperAge = new System.Windows.Forms.TextBox();
            this.camperNickname = new System.Windows.Forms.TextBox();
            this.camperNationality = new System.Windows.Forms.TextBox();
            this.camperBunk = new System.Windows.Forms.TextBox();
            this.camperName = new System.Windows.Forms.TextBox();
            this.CAge = new System.Windows.Forms.Label();
            this.CTransportation = new System.Windows.Forms.Label();
            this.CMedications = new System.Windows.Forms.Label();
            this.CRestriction = new System.Windows.Forms.Label();
            this.CBunk = new System.Windows.Forms.Label();
            this.CNationality = new System.Windows.Forms.Label();
            this.CStartdate = new System.Windows.Forms.Label();
            this.CLeavedate = new System.Windows.Forms.Label();
            this.CNName = new System.Windows.Forms.Label();
            this.CName = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.Parent2.SuspendLayout();
            this.Parent1.SuspendLayout();
            this.Camper.SuspendLayout();
            this.SuspendLayout();
            // 
            // Session
            // 
            this.Session.FormattingEnabled = true;
            this.Session.Location = new System.Drawing.Point(22, 570);
            this.Session.Name = "Session";
            this.Session.Size = new System.Drawing.Size(223, 21);
            this.Session.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Parent2);
            this.groupBox1.Controls.Add(this.Parent1);
            this.groupBox1.Controls.Add(this.Camper);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 525);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // Parent2
            // 
            this.Parent2.Controls.Add(this.parent2Email);
            this.Parent2.Controls.Add(this.P2Email);
            this.Parent2.Controls.Add(this.parent2No);
            this.Parent2.Controls.Add(this.P2No);
            this.Parent2.Controls.Add(this.parent2Name);
            this.Parent2.Controls.Add(this.P2Name);
            this.Parent2.Location = new System.Drawing.Point(354, 310);
            this.Parent2.Name = "Parent2";
            this.Parent2.Size = new System.Drawing.Size(343, 207);
            this.Parent2.TabIndex = 2;
            this.Parent2.TabStop = false;
            this.Parent2.Text = "Parent 2 Info";
            // 
            // parent2Email
            // 
            this.parent2Email.Location = new System.Drawing.Point(121, 148);
            this.parent2Email.Name = "parent2Email";
            this.parent2Email.Size = new System.Drawing.Size(181, 30);
            this.parent2Email.TabIndex = 16;
            // 
            // P2Email
            // 
            this.P2Email.AutoSize = true;
            this.P2Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2Email.Location = new System.Drawing.Point(27, 161);
            this.P2Email.Name = "P2Email";
            this.P2Email.Size = new System.Drawing.Size(42, 17);
            this.P2Email.TabIndex = 15;
            this.P2Email.Text = "Email";
            // 
            // parent2No
            // 
            this.parent2No.Location = new System.Drawing.Point(121, 96);
            this.parent2No.Name = "parent2No";
            this.parent2No.Size = new System.Drawing.Size(181, 30);
            this.parent2No.TabIndex = 14;
            // 
            // P2No
            // 
            this.P2No.AutoSize = true;
            this.P2No.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2No.Location = new System.Drawing.Point(27, 106);
            this.P2No.Name = "P2No";
            this.P2No.Size = new System.Drawing.Size(75, 17);
            this.P2No.TabIndex = 13;
            this.P2No.Text = "Phone No.";
            // 
            // parent2Name
            // 
            this.parent2Name.Location = new System.Drawing.Point(121, 45);
            this.parent2Name.Name = "parent2Name";
            this.parent2Name.Size = new System.Drawing.Size(181, 30);
            this.parent2Name.TabIndex = 12;
            // 
            // P2Name
            // 
            this.P2Name.AutoSize = true;
            this.P2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2Name.Location = new System.Drawing.Point(27, 58);
            this.P2Name.Name = "P2Name";
            this.P2Name.Size = new System.Drawing.Size(45, 17);
            this.P2Name.TabIndex = 11;
            this.P2Name.Text = "Name";
            // 
            // Parent1
            // 
            this.Parent1.Controls.Add(this.P1Email);
            this.Parent1.Controls.Add(this.parent1Email);
            this.Parent1.Controls.Add(this.parent1No);
            this.Parent1.Controls.Add(this.P1No);
            this.Parent1.Controls.Add(this.parent1Name);
            this.Parent1.Controls.Add(this.P1Name);
            this.Parent1.Location = new System.Drawing.Point(0, 310);
            this.Parent1.Name = "Parent1";
            this.Parent1.Size = new System.Drawing.Size(329, 207);
            this.Parent1.TabIndex = 1;
            this.Parent1.TabStop = false;
            this.Parent1.Text = "Parent 1 Info";
            // 
            // P1Email
            // 
            this.P1Email.AutoSize = true;
            this.P1Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1Email.Location = new System.Drawing.Point(16, 158);
            this.P1Email.Name = "P1Email";
            this.P1Email.Size = new System.Drawing.Size(42, 17);
            this.P1Email.TabIndex = 15;
            this.P1Email.Text = "Email";
            // 
            // parent1Email
            // 
            this.parent1Email.Location = new System.Drawing.Point(110, 148);
            this.parent1Email.Name = "parent1Email";
            this.parent1Email.Size = new System.Drawing.Size(181, 30);
            this.parent1Email.TabIndex = 16;
            // 
            // parent1No
            // 
            this.parent1No.Location = new System.Drawing.Point(110, 96);
            this.parent1No.Name = "parent1No";
            this.parent1No.Size = new System.Drawing.Size(181, 30);
            this.parent1No.TabIndex = 18;
            // 
            // P1No
            // 
            this.P1No.AutoSize = true;
            this.P1No.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1No.Location = new System.Drawing.Point(16, 109);
            this.P1No.Name = "P1No";
            this.P1No.Size = new System.Drawing.Size(75, 17);
            this.P1No.TabIndex = 17;
            this.P1No.Text = "Phone No.";
            // 
            // parent1Name
            // 
            this.parent1Name.Location = new System.Drawing.Point(110, 45);
            this.parent1Name.Name = "parent1Name";
            this.parent1Name.Size = new System.Drawing.Size(181, 30);
            this.parent1Name.TabIndex = 12;
            // 
            // P1Name
            // 
            this.P1Name.AutoSize = true;
            this.P1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1Name.Location = new System.Drawing.Point(16, 58);
            this.P1Name.Name = "P1Name";
            this.P1Name.Size = new System.Drawing.Size(45, 17);
            this.P1Name.TabIndex = 11;
            this.P1Name.Text = "Name";
            // 
            // Camper
            // 
            this.Camper.Controls.Add(this.camperLeavedate);
            this.Camper.Controls.Add(this.camperStartdate);
            this.Camper.Controls.Add(this.camperTransportation);
            this.Camper.Controls.Add(this.camperMedications);
            this.Camper.Controls.Add(this.camperRestriction);
            this.Camper.Controls.Add(this.camperAge);
            this.Camper.Controls.Add(this.camperNickname);
            this.Camper.Controls.Add(this.camperNationality);
            this.Camper.Controls.Add(this.camperBunk);
            this.Camper.Controls.Add(this.camperName);
            this.Camper.Controls.Add(this.CAge);
            this.Camper.Controls.Add(this.CTransportation);
            this.Camper.Controls.Add(this.CMedications);
            this.Camper.Controls.Add(this.CRestriction);
            this.Camper.Controls.Add(this.CBunk);
            this.Camper.Controls.Add(this.CNationality);
            this.Camper.Controls.Add(this.CStartdate);
            this.Camper.Controls.Add(this.CLeavedate);
            this.Camper.Controls.Add(this.CNName);
            this.Camper.Controls.Add(this.CName);
            this.Camper.Location = new System.Drawing.Point(0, 13);
            this.Camper.Name = "Camper";
            this.Camper.Size = new System.Drawing.Size(697, 282);
            this.Camper.TabIndex = 0;
            this.Camper.TabStop = false;
            this.Camper.Text = "CamperInfo";
            // 
            // camperLeavedate
            // 
            this.camperLeavedate.Location = new System.Drawing.Point(110, 240);
            this.camperLeavedate.Name = "camperLeavedate";
            this.camperLeavedate.Size = new System.Drawing.Size(200, 30);
            this.camperLeavedate.TabIndex = 21;
            // 
            // camperStartdate
            // 
            this.camperStartdate.Location = new System.Drawing.Point(110, 185);
            this.camperStartdate.Name = "camperStartdate";
            this.camperStartdate.Size = new System.Drawing.Size(200, 30);
            this.camperStartdate.TabIndex = 20;
            // 
            // camperTransportation
            // 
            this.camperTransportation.Location = new System.Drawing.Point(479, 231);
            this.camperTransportation.Name = "camperTransportation";
            this.camperTransportation.Size = new System.Drawing.Size(181, 30);
            this.camperTransportation.TabIndex = 19;
            // 
            // camperMedications
            // 
            this.camperMedications.Location = new System.Drawing.Point(479, 184);
            this.camperMedications.Name = "camperMedications";
            this.camperMedications.Size = new System.Drawing.Size(181, 30);
            this.camperMedications.TabIndex = 18;
            // 
            // camperRestriction
            // 
            this.camperRestriction.Location = new System.Drawing.Point(479, 135);
            this.camperRestriction.Name = "camperRestriction";
            this.camperRestriction.Size = new System.Drawing.Size(181, 30);
            this.camperRestriction.TabIndex = 17;
            // 
            // camperAge
            // 
            this.camperAge.Location = new System.Drawing.Point(479, 86);
            this.camperAge.Name = "camperAge";
            this.camperAge.Size = new System.Drawing.Size(181, 30);
            this.camperAge.TabIndex = 16;
            // 
            // camperNickname
            // 
            this.camperNickname.Location = new System.Drawing.Point(479, 36);
            this.camperNickname.Name = "camperNickname";
            this.camperNickname.Size = new System.Drawing.Size(181, 30);
            this.camperNickname.TabIndex = 15;
            // 
            // camperNationality
            // 
            this.camperNationality.Location = new System.Drawing.Point(110, 132);
            this.camperNationality.Name = "camperNationality";
            this.camperNationality.Size = new System.Drawing.Size(181, 30);
            this.camperNationality.TabIndex = 12;
            // 
            // camperBunk
            // 
            this.camperBunk.Location = new System.Drawing.Point(110, 86);
            this.camperBunk.Name = "camperBunk";
            this.camperBunk.Size = new System.Drawing.Size(181, 30);
            this.camperBunk.TabIndex = 11;
            // 
            // camperName
            // 
            this.camperName.Location = new System.Drawing.Point(110, 36);
            this.camperName.Name = "camperName";
            this.camperName.Size = new System.Drawing.Size(181, 30);
            this.camperName.TabIndex = 10;
            // 
            // CAge
            // 
            this.CAge.AutoSize = true;
            this.CAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CAge.Location = new System.Drawing.Point(351, 96);
            this.CAge.Name = "CAge";
            this.CAge.Size = new System.Drawing.Size(33, 17);
            this.CAge.TabIndex = 9;
            this.CAge.Text = "Age";
            // 
            // CTransportation
            // 
            this.CTransportation.AutoSize = true;
            this.CTransportation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CTransportation.Location = new System.Drawing.Point(351, 244);
            this.CTransportation.Name = "CTransportation";
            this.CTransportation.Size = new System.Drawing.Size(101, 17);
            this.CTransportation.TabIndex = 8;
            this.CTransportation.Text = "Transportation";
            // 
            // CMedications
            // 
            this.CMedications.AutoSize = true;
            this.CMedications.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMedications.Location = new System.Drawing.Point(351, 197);
            this.CMedications.Name = "CMedications";
            this.CMedications.Size = new System.Drawing.Size(83, 17);
            this.CMedications.TabIndex = 7;
            this.CMedications.Text = "Medications";
            // 
            // CRestriction
            // 
            this.CRestriction.AutoSize = true;
            this.CRestriction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CRestriction.Location = new System.Drawing.Point(351, 148);
            this.CRestriction.Name = "CRestriction";
            this.CRestriction.Size = new System.Drawing.Size(75, 17);
            this.CRestriction.TabIndex = 6;
            this.CRestriction.Text = "Restriction";
            // 
            // CBunk
            // 
            this.CBunk.AutoSize = true;
            this.CBunk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBunk.Location = new System.Drawing.Point(16, 99);
            this.CBunk.Name = "CBunk";
            this.CBunk.Size = new System.Drawing.Size(40, 17);
            this.CBunk.TabIndex = 5;
            this.CBunk.Text = "Bunk";
            // 
            // CNationality
            // 
            this.CNationality.AutoSize = true;
            this.CNationality.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNationality.Location = new System.Drawing.Point(16, 145);
            this.CNationality.Name = "CNationality";
            this.CNationality.Size = new System.Drawing.Size(74, 17);
            this.CNationality.TabIndex = 4;
            this.CNationality.Text = "Nationality";
            // 
            // CStartdate
            // 
            this.CStartdate.AutoSize = true;
            this.CStartdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CStartdate.Location = new System.Drawing.Point(16, 194);
            this.CStartdate.Name = "CStartdate";
            this.CStartdate.Size = new System.Drawing.Size(72, 17);
            this.CStartdate.TabIndex = 3;
            this.CStartdate.Text = "Start Date";
            // 
            // CLeavedate
            // 
            this.CLeavedate.AutoSize = true;
            this.CLeavedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLeavedate.Location = new System.Drawing.Point(16, 241);
            this.CLeavedate.Name = "CLeavedate";
            this.CLeavedate.Size = new System.Drawing.Size(81, 17);
            this.CLeavedate.TabIndex = 2;
            this.CLeavedate.Text = "Leave Date";
            // 
            // CNName
            // 
            this.CNName.AutoSize = true;
            this.CNName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CNName.Location = new System.Drawing.Point(351, 49);
            this.CNName.Name = "CNName";
            this.CNName.Size = new System.Drawing.Size(104, 17);
            this.CNName.TabIndex = 1;
            this.CNName.Text = "Prefered Name";
            // 
            // CName
            // 
            this.CName.AutoSize = true;
            this.CName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CName.Location = new System.Drawing.Point(16, 49);
            this.CName.Name = "CName";
            this.CName.Size = new System.Drawing.Size(45, 17);
            this.CName.TabIndex = 0;
            this.CName.Text = "Name";
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Black;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Save.Location = new System.Drawing.Point(559, 543);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(145, 70);
            this.Save.TabIndex = 3;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // New
            // 
            this.New.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.New.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.ForeColor = System.Drawing.Color.White;
            this.New.Location = new System.Drawing.Point(289, 558);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(122, 45);
            this.New.TabIndex = 4;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = false;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(716, 625);
            this.Controls.Add(this.New);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Session);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.groupBox1.ResumeLayout(false);
            this.Parent2.ResumeLayout(false);
            this.Parent2.PerformLayout();
            this.Parent1.ResumeLayout(false);
            this.Parent1.PerformLayout();
            this.Camper.ResumeLayout(false);
            this.Camper.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox Parent2;
        private System.Windows.Forms.TextBox parent2Email;
        private System.Windows.Forms.Label P2Email;
        private System.Windows.Forms.TextBox parent2No;
        private System.Windows.Forms.Label P2No;
        private System.Windows.Forms.TextBox parent2Name;
        private System.Windows.Forms.Label P2Name;
        private System.Windows.Forms.GroupBox Parent1;
        private System.Windows.Forms.Label P1Email;
        private System.Windows.Forms.TextBox parent1Email;
        private System.Windows.Forms.TextBox parent1No;
        private System.Windows.Forms.Label P1No;
        private System.Windows.Forms.TextBox parent1Name;
        private System.Windows.Forms.Label P1Name;
        private System.Windows.Forms.GroupBox Camper;
        private System.Windows.Forms.TextBox camperTransportation;
        private System.Windows.Forms.TextBox camperMedications;
        private System.Windows.Forms.TextBox camperRestriction;
        private System.Windows.Forms.TextBox camperAge;
        private System.Windows.Forms.TextBox camperNickname;
        private System.Windows.Forms.TextBox camperNationality;
        private System.Windows.Forms.TextBox camperBunk;
        private System.Windows.Forms.TextBox camperName;
        private System.Windows.Forms.Label CAge;
        private System.Windows.Forms.Label CTransportation;
        private System.Windows.Forms.Label CMedications;
        private System.Windows.Forms.Label CRestriction;
        private System.Windows.Forms.Label CBunk;
        private System.Windows.Forms.Label CNationality;
        private System.Windows.Forms.Label CStartdate;
        private System.Windows.Forms.Label CLeavedate;
        private System.Windows.Forms.Label CNName;
        private System.Windows.Forms.Label CName;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.DateTimePicker camperLeavedate;
        private System.Windows.Forms.DateTimePicker camperStartdate;
        public System.Windows.Forms.ComboBox Session;
    }
}