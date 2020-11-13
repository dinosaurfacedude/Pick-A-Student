namespace Pick_A_Student
{
    partial class EditWindow
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
            this.CorrectAnswer = new System.Windows.Forms.TextBox();
            this.StudentThinking = new System.Windows.Forms.TextBox();
            this.WrongAnswer = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.ClassName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StudentName
            // 
            this.StudentName.BackColor = System.Drawing.Color.DimGray;
            this.StudentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentName.Location = new System.Drawing.Point(57, 52);
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            this.StudentName.Size = new System.Drawing.Size(100, 15);
            this.StudentName.TabIndex = 0;
            this.StudentName.Text = "Student Name";
            this.StudentName.TextChanged += new System.EventHandler(this.StudentName_TextChanged);
            // 
            // CorrectAnswer
            // 
            this.CorrectAnswer.BackColor = System.Drawing.Color.DimGray;
            this.CorrectAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CorrectAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectAnswer.Location = new System.Drawing.Point(347, 52);
            this.CorrectAnswer.Name = "CorrectAnswer";
            this.CorrectAnswer.ReadOnly = true;
            this.CorrectAnswer.Size = new System.Drawing.Size(100, 15);
            this.CorrectAnswer.TabIndex = 1;
            this.CorrectAnswer.Text = "Correct Answers";
            this.CorrectAnswer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // StudentThinking
            // 
            this.StudentThinking.BackColor = System.Drawing.Color.DimGray;
            this.StudentThinking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StudentThinking.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentThinking.Location = new System.Drawing.Point(490, 52);
            this.StudentThinking.Multiline = true;
            this.StudentThinking.Name = "StudentThinking";
            this.StudentThinking.ReadOnly = true;
            this.StudentThinking.Size = new System.Drawing.Size(103, 24);
            this.StudentThinking.TabIndex = 2;
            this.StudentThinking.Text = "Student thinking";
            this.StudentThinking.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // WrongAnswer
            // 
            this.WrongAnswer.BackColor = System.Drawing.Color.DimGray;
            this.WrongAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WrongAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WrongAnswer.Location = new System.Drawing.Point(615, 52);
            this.WrongAnswer.Multiline = true;
            this.WrongAnswer.Name = "WrongAnswer";
            this.WrongAnswer.ReadOnly = true;
            this.WrongAnswer.Size = new System.Drawing.Size(169, 24);
            this.WrongAnswer.TabIndex = 3;
            this.WrongAnswer.Text = "Wrong Answers or Absent";
            // 
            // Save
            // 
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Location = new System.Drawing.Point(369, 408);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 16;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.DimGray;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Location = new System.Drawing.Point(29, 404);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(85, 27);
            this.Add.TabIndex = 15;
            this.Add.Text = "Add a Student";
            this.Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click_1);
            // 
            // Remove
            // 
            this.Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove.Location = new System.Drawing.Point(691, 405);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(61, 25);
            this.Remove.TabIndex = 17;
            this.Remove.Text = "Remove ";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click_1);
            // 
            // ClassName
            // 
            this.ClassName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassName.Location = new System.Drawing.Point(178, 12);
            this.ClassName.Multiline = true;
            this.ClassName.Name = "ClassName";
            this.ClassName.Size = new System.Drawing.Size(155, 34);
            this.ClassName.TabIndex = 14;
            this.ClassName.Text = "COSC 2104";
            this.ClassName.TextChanged += new System.EventHandler(this.ClassName_TextChanged);
            // 
            // EditWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ClassName);
            this.Controls.Add(this.WrongAnswer);
            this.Controls.Add(this.StudentThinking);
            this.Controls.Add(this.CorrectAnswer);
            this.Controls.Add(this.StudentName);
            this.Name = "EditWindow";
            this.Text = "EditWindow";
            this.Load += new System.EventHandler(this.EditWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StudentName;
        private System.Windows.Forms.TextBox CorrectAnswer;
        private System.Windows.Forms.TextBox StudentThinking;
        private System.Windows.Forms.TextBox WrongAnswer;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.TextBox ClassName;
    }
}