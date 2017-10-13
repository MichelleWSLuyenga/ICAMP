namespace Hades
{
    partial class HomePage
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
            this.campSession = new System.Windows.Forms.Label();
            this.sessions = new System.Windows.Forms.ComboBox();
            this.Menus = new System.Windows.Forms.GroupBox();
            this.registerActivities = new System.Windows.Forms.Button();
            this.chooseActivities = new System.Windows.Forms.Button();
            this.registerEdit = new System.Windows.Forms.Button();
            this.Export = new System.Windows.Forms.GroupBox();
            this.detail = new System.Windows.Forms.Button();
            this.signUp = new System.Windows.Forms.Button();
            this.exportDate = new System.Windows.Forms.DateTimePicker();
            this.newSession = new System.Windows.Forms.Button();
            this.Menus.SuspendLayout();
            this.Export.SuspendLayout();
            this.SuspendLayout();
            // 
            // campSession
            // 
            this.campSession.AutoSize = true;
            this.campSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campSession.Location = new System.Drawing.Point(81, 15);
            this.campSession.Name = "campSession";
            this.campSession.Size = new System.Drawing.Size(190, 31);
            this.campSession.TabIndex = 0;
            this.campSession.Text = "Camp Session";
            // 
            // sessions
            // 
            this.sessions.FormattingEnabled = true;
            this.sessions.Location = new System.Drawing.Point(286, 25);
            this.sessions.Name = "sessions";
            this.sessions.Size = new System.Drawing.Size(173, 21);
            this.sessions.TabIndex = 1;
            // 
            // Menus
            // 
            this.Menus.Controls.Add(this.registerActivities);
            this.Menus.Controls.Add(this.chooseActivities);
            this.Menus.Controls.Add(this.registerEdit);
            this.Menus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menus.Location = new System.Drawing.Point(12, 55);
            this.Menus.Name = "Menus";
            this.Menus.Size = new System.Drawing.Size(685, 183);
            this.Menus.TabIndex = 2;
            this.Menus.TabStop = false;
            this.Menus.Text = "Menu";
            // 
            // registerActivities
            // 
            this.registerActivities.BackColor = System.Drawing.Color.White;
            this.registerActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerActivities.Location = new System.Drawing.Point(459, 36);
            this.registerActivities.Name = "registerActivities";
            this.registerActivities.Size = new System.Drawing.Size(226, 97);
            this.registerActivities.TabIndex = 2;
            this.registerActivities.Text = "Register Activities";
            this.registerActivities.UseVisualStyleBackColor = false;
            this.registerActivities.Click += new System.EventHandler(this.registerActivities_Click);
            // 
            // chooseActivities
            // 
            this.chooseActivities.BackColor = System.Drawing.Color.White;
            this.chooseActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseActivities.Location = new System.Drawing.Point(232, 36);
            this.chooseActivities.Name = "chooseActivities";
            this.chooseActivities.Size = new System.Drawing.Size(226, 97);
            this.chooseActivities.TabIndex = 1;
            this.chooseActivities.Text = "Choose Activities";
            this.chooseActivities.UseVisualStyleBackColor = false;
            this.chooseActivities.Click += new System.EventHandler(this.chooseActivities_Click);
            // 
            // registerEdit
            // 
            this.registerEdit.BackColor = System.Drawing.Color.White;
            this.registerEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerEdit.Location = new System.Drawing.Point(0, 36);
            this.registerEdit.Name = "registerEdit";
            this.registerEdit.Size = new System.Drawing.Size(226, 97);
            this.registerEdit.TabIndex = 0;
            this.registerEdit.Text = "Register/Edit";
            this.registerEdit.UseVisualStyleBackColor = false;
            this.registerEdit.Click += new System.EventHandler(this.registerEdit_Click);
            // 
            // Export
            // 
            this.Export.BackColor = System.Drawing.Color.GhostWhite;
            this.Export.Controls.Add(this.detail);
            this.Export.Controls.Add(this.signUp);
            this.Export.Controls.Add(this.exportDate);
            this.Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Export.ForeColor = System.Drawing.Color.Black;
            this.Export.Location = new System.Drawing.Point(12, 257);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(685, 143);
            this.Export.TabIndex = 3;
            this.Export.TabStop = false;
            this.Export.Text = "Export";
            // 
            // detail
            // 
            this.detail.Location = new System.Drawing.Point(487, 41);
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(165, 59);
            this.detail.TabIndex = 2;
            this.detail.Text = "Detail";
            this.detail.UseVisualStyleBackColor = false;
            // 
            // signUp
            // 
            this.signUp.Location = new System.Drawing.Point(293, 41);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(165, 59);
            this.signUp.TabIndex = 1;
            this.signUp.Text = "Signup Sheet";
            this.signUp.UseVisualStyleBackColor = false;
            this.signUp.Click += new System.EventHandler(this.signUp_Click);
            // 
            // exportDate
            // 
            this.exportDate.Location = new System.Drawing.Point(17, 41);
            this.exportDate.Name = "exportDate";
            this.exportDate.Size = new System.Drawing.Size(251, 30);
            this.exportDate.TabIndex = 0;
            // 
            // newSession
            // 
            this.newSession.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.newSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newSession.ForeColor = System.Drawing.Color.White;
            this.newSession.Location = new System.Drawing.Point(509, 19);
            this.newSession.Name = "newSession";
            this.newSession.Size = new System.Drawing.Size(103, 34);
            this.newSession.TabIndex = 4;
            this.newSession.Text = "New";
            this.newSession.UseVisualStyleBackColor = false;
            this.newSession.Click += new System.EventHandler(this.newSession_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(709, 423);
            this.Controls.Add(this.newSession);
            this.Controls.Add(this.Export);
            this.Controls.Add(this.Menus);
            this.Controls.Add(this.sessions);
            this.Controls.Add(this.campSession);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "HomePage";
            this.ShowIcon = false;
            this.Text = "Home Page";
            this.Click += new System.EventHandler(this.HomePage_Click);
            this.Menus.ResumeLayout(false);
            this.Export.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label campSession;
        private System.Windows.Forms.GroupBox Menus;
        private System.Windows.Forms.Button registerActivities;
        private System.Windows.Forms.Button chooseActivities;
        private System.Windows.Forms.Button registerEdit;
        private System.Windows.Forms.GroupBox Export;
        private System.Windows.Forms.Button detail;
        private System.Windows.Forms.Button signUp;
        private System.Windows.Forms.DateTimePicker exportDate;
        private System.Windows.Forms.Button newSession;
        public System.Windows.Forms.ComboBox sessions;
    }
}

