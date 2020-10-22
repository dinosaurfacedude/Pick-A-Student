namespace Pick_A_Student
{
    partial class PickAStudent
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
            this.StudentName = new System.Windows.Forms.TextBox();
            this.Edit = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.TextBox();
            this.ClassChoose = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.NextStudent = new System.Windows.Forms.Button();
            this.sleeping = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ThinkingBright = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentName
            // 
            this.StudentName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.StudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentName.Location = new System.Drawing.Point(197, 158);
            this.StudentName.Name = "StudentName";
            this.StudentName.ShortcutsEnabled = false;
            this.StudentName.Size = new System.Drawing.Size(431, 49);
            this.StudentName.TabIndex = 1;
            this.StudentName.Text = "Daniel Jones";
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.DimGray;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.Location = new System.Drawing.Point(706, 26);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(80, 32);
            this.Edit.TabIndex = 3;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.Color.DimGray;
            this.About.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.About.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.About.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.About.Location = new System.Drawing.Point(12, 457);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(75, 23);
            this.About.TabIndex = 7;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = false;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.DimGray;
            this.Save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Save.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(706, 448);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(82, 32);
            this.Save.TabIndex = 10;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.DimGray;
            this.title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.title.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(197, 26);
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.ShortcutsEnabled = false;
            this.title.Size = new System.Drawing.Size(431, 38);
            this.title.TabIndex = 14;
            this.title.Text = "Pick A Student";
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.title.TextChanged += new System.EventHandler(this.title_TextChanged);
            // 
            // ClassChoose
            // 
            this.ClassChoose.BackColor = System.Drawing.Color.DimGray;
            this.ClassChoose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClassChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassChoose.Location = new System.Drawing.Point(12, 26);
            this.ClassChoose.Name = "ClassChoose";
            this.ClassChoose.Size = new System.Drawing.Size(116, 38);
            this.ClassChoose.TabIndex = 15;
            this.ClassChoose.Text = "Choose Class";
            this.ClassChoose.UseVisualStyleBackColor = false;
            this.ClassChoose.Click += new System.EventHandler(this.ClassChoose_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DimGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(638, 212);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 13);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "Queue size: 1";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // NextStudent
            // 
            this.NextStudent.BackColor = System.Drawing.Color.DimGray;
            this.NextStudent.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.NextStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextStudent.ForeColor = System.Drawing.SystemColors.ControlText;
            this.NextStudent.Image = global::Pick_A_Student.Properties.Resources.ClipartKey_237173;
            this.NextStudent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NextStudent.Location = new System.Drawing.Point(365, 406);
            this.NextStudent.Name = "NextStudent";
            this.NextStudent.Size = new System.Drawing.Size(108, 71);
            this.NextStudent.TabIndex = 12;
            this.NextStudent.Text = "Next Student";
            this.NextStudent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NextStudent.UseVisualStyleBackColor = false;
            // 
            // sleeping
            // 
            this.sleeping.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sleeping.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sleeping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sleeping.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sleeping.Image = global::Pick_A_Student.Properties.Resources.Sleeping_Emoji2;
            this.sleeping.Location = new System.Drawing.Point(518, 245);
            this.sleeping.Name = "sleeping";
            this.sleeping.Size = new System.Drawing.Size(110, 99);
            this.sleeping.TabIndex = 9;
            this.sleeping.UseVisualStyleBackColor = false;
            this.sleeping.Click += new System.EventHandler(this.sleeping_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Pick_A_Student.Properties.Resources.dark_smilly1;
            this.button1.Location = new System.Drawing.Point(197, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 100);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ThinkingBright
            // 
            this.ThinkingBright.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ThinkingBright.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ThinkingBright.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ThinkingBright.Image = global::Pick_A_Student.Properties.Resources.dark_thinking1;
            this.ThinkingBright.Location = new System.Drawing.Point(365, 244);
            this.ThinkingBright.Name = "ThinkingBright";
            this.ThinkingBright.Size = new System.Drawing.Size(108, 100);
            this.ThinkingBright.TabIndex = 5;
            this.ThinkingBright.UseVisualStyleBackColor = false;
            this.ThinkingBright.Click += new System.EventHandler(this.ThinkingBright_Click);
            // 
            // PickAStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 492);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ClassChoose);
            this.Controls.Add(this.title);
            this.Controls.Add(this.NextStudent);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.sleeping);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.About);
            this.Controls.Add(this.ThinkingBright);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.StudentName);
            this.Name = "PickAStudent";
            this.RightToLeftLayout = true;
            this.Text = "Pick A Student";
            this.Load += new System.EventHandler(this.PickAStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox StudentName;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button ThinkingBright;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sleeping;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button NextStudent;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Button ClassChoose;
        private System.Windows.Forms.TextBox textBox1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

