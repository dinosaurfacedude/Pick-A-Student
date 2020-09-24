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
            this.Student1 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Correct1 = new System.Windows.Forms.TextBox();
            this.Thinking1 = new System.Windows.Forms.TextBox();
            this.Wrong1 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.Student2 = new System.Windows.Forms.TextBox();
            this.Correct2 = new System.Windows.Forms.TextBox();
            this.Thinking2 = new System.Windows.Forms.TextBox();
            this.Wrong2 = new System.Windows.Forms.TextBox();
            this.ClassName = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
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
            // Student1
            // 
            this.Student1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student1.Location = new System.Drawing.Point(61, 104);
            this.Student1.Multiline = true;
            this.Student1.Name = "Student1";
            this.Student1.Size = new System.Drawing.Size(210, 34);
            this.Student1.TabIndex = 4;
            this.Student1.Text = "Tanner Waters";
            this.Student1.TextChanged += new System.EventHandler(this.Student1_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 113);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Correct1
            // 
            this.Correct1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correct1.Location = new System.Drawing.Point(369, 110);
            this.Correct1.Multiline = true;
            this.Correct1.Name = "Correct1";
            this.Correct1.Size = new System.Drawing.Size(52, 37);
            this.Correct1.TabIndex = 6;
            this.Correct1.Text = "0";
            this.Correct1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Thinking1
            // 
            this.Thinking1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thinking1.Location = new System.Drawing.Point(515, 110);
            this.Thinking1.Multiline = true;
            this.Thinking1.Name = "Thinking1";
            this.Thinking1.Size = new System.Drawing.Size(52, 37);
            this.Thinking1.TabIndex = 7;
            this.Thinking1.Text = "0";
            this.Thinking1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Thinking1.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // Wrong1
            // 
            this.Wrong1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wrong1.Location = new System.Drawing.Point(663, 110);
            this.Wrong1.Multiline = true;
            this.Wrong1.Name = "Wrong1";
            this.Wrong1.Size = new System.Drawing.Size(52, 37);
            this.Wrong1.TabIndex = 8;
            this.Wrong1.Text = "0";
            this.Wrong1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(12, 195);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Student2
            // 
            this.Student2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student2.Location = new System.Drawing.Point(61, 186);
            this.Student2.Multiline = true;
            this.Student2.Name = "Student2";
            this.Student2.Size = new System.Drawing.Size(210, 34);
            this.Student2.TabIndex = 10;
            this.Student2.Text = "Michael Tanner Waters";
            this.Student2.TextChanged += new System.EventHandler(this.Student2_TextChanged);
            // 
            // Correct2
            // 
            this.Correct2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correct2.Location = new System.Drawing.Point(369, 192);
            this.Correct2.Multiline = true;
            this.Correct2.Name = "Correct2";
            this.Correct2.Size = new System.Drawing.Size(52, 37);
            this.Correct2.TabIndex = 11;
            this.Correct2.Text = "0";
            this.Correct2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Thinking2
            // 
            this.Thinking2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thinking2.Location = new System.Drawing.Point(515, 192);
            this.Thinking2.Multiline = true;
            this.Thinking2.Name = "Thinking2";
            this.Thinking2.Size = new System.Drawing.Size(52, 37);
            this.Thinking2.TabIndex = 12;
            this.Thinking2.Text = "0";
            this.Thinking2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Thinking2.TextChanged += new System.EventHandler(this.Thinking2_TextChanged);
            // 
            // Wrong2
            // 
            this.Wrong2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Wrong2.Location = new System.Drawing.Point(663, 192);
            this.Wrong2.Multiline = true;
            this.Wrong2.Name = "Wrong2";
            this.Wrong2.Size = new System.Drawing.Size(52, 37);
            this.Wrong2.TabIndex = 13;
            this.Wrong2.Text = "0";
            this.Wrong2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Controls.Add(this.Wrong2);
            this.Controls.Add(this.Thinking2);
            this.Controls.Add(this.Correct2);
            this.Controls.Add(this.Student2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.Wrong1);
            this.Controls.Add(this.Thinking1);
            this.Controls.Add(this.Correct1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Student1);
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
        private System.Windows.Forms.TextBox Student1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox Correct1;
        private System.Windows.Forms.TextBox Thinking1;
        private System.Windows.Forms.TextBox Wrong1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox Student2;
        private System.Windows.Forms.TextBox Correct2;
        private System.Windows.Forms.TextBox Thinking2;
        private System.Windows.Forms.TextBox Wrong2;
        private System.Windows.Forms.TextBox ClassName;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Remove;
    }
}