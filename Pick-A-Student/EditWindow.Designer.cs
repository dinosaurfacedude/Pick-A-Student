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
            this.Save = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.ClassName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.studentDelete = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.toChange = new System.Windows.Forms.TextBox();
            this.changeTo = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Transparent;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Save.ForeColor = System.Drawing.Color.Transparent;
            this.Save.Location = new System.Drawing.Point(791, 15);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 16;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.Transparent;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Add.ForeColor = System.Drawing.Color.Transparent;
            this.Add.Location = new System.Drawing.Point(10, 11);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(85, 27);
            this.Add.TabIndex = 15;
            this.Add.Text = "Add a Student";
            this.Add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click_1);
            // 
            // ClassName
            // 
            this.ClassName.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassName.Location = new System.Drawing.Point(101, 4);
            this.ClassName.Multiline = true;
            this.ClassName.Name = "ClassName";
            this.ClassName.Size = new System.Drawing.Size(155, 34);
            this.ClassName.TabIndex = 14;
            this.ClassName.TextChanged += new System.EventHandler(this.ClassName_TextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(633, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 15);
            this.label4.TabIndex = 22;
            this.label4.Text = "Wrong Answers or Absent";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(495, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Student Thinking";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(351, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Correct Answers";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 25;
            this.label1.Text = "Student Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // studentDelete
            // 
            this.studentDelete.Location = new System.Drawing.Point(262, 4);
            this.studentDelete.Multiline = true;
            this.studentDelete.Name = "studentDelete";
            this.studentDelete.Size = new System.Drawing.Size(143, 34);
            this.studentDelete.TabIndex = 26;
            this.studentDelete.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.Transparent;
            this.delete.Location = new System.Drawing.Point(411, 4);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(96, 34);
            this.delete.TabIndex = 27;
            this.delete.Text = "delete student";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // toChange
            // 
            this.toChange.Location = new System.Drawing.Point(513, 12);
            this.toChange.Name = "toChange";
            this.toChange.Size = new System.Drawing.Size(93, 20);
            this.toChange.TabIndex = 28;
            this.toChange.Text = "student to change";
            this.toChange.TextChanged += new System.EventHandler(this.toChange_TextChanged);
            // 
            // changeTo
            // 
            this.changeTo.Location = new System.Drawing.Point(613, 12);
            this.changeTo.Name = "changeTo";
            this.changeTo.Size = new System.Drawing.Size(78, 20);
            this.changeTo.TabIndex = 29;
            this.changeTo.Text = "new name";
            this.changeTo.TextChanged += new System.EventHandler(this.changeTo_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(697, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::Pick_A_Student.Properties.Resources.Light_Blue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.changeTo);
            this.Controls.Add(this.toChange);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.studentDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ClassName);
            this.Name = "EditWindow";
            this.Text = "EditWindow";
            this.Load += new System.EventHandler(this.EditWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.TextBox ClassName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentDelete;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox toChange;
        private System.Windows.Forms.TextBox changeTo;
        private System.Windows.Forms.Button button1;
    }
}