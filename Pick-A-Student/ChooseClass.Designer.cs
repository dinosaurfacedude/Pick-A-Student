namespace Pick_A_Student
{
    partial class ChooseClass
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
            this.AddClass = new System.Windows.Forms.Button();
            this.DeleteClass = new System.Windows.Forms.Button();
            this.LoadClass = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // AddClass
            // 
            this.AddClass.BackColor = System.Drawing.Color.DimGray;
            this.AddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddClass.Location = new System.Drawing.Point(43, 44);
            this.AddClass.Name = "AddClass";
            this.AddClass.Size = new System.Drawing.Size(111, 50);
            this.AddClass.TabIndex = 0;
            this.AddClass.Text = "Add Class +";
            this.AddClass.UseVisualStyleBackColor = false;
            // 
            // DeleteClass
            // 
            this.DeleteClass.BackColor = System.Drawing.Color.DimGray;
            this.DeleteClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteClass.Location = new System.Drawing.Point(24, 403);
            this.DeleteClass.Name = "DeleteClass";
            this.DeleteClass.Size = new System.Drawing.Size(119, 32);
            this.DeleteClass.TabIndex = 1;
            this.DeleteClass.Text = "Delete Class";
            this.DeleteClass.UseVisualStyleBackColor = false;
            // 
            // LoadClass
            // 
            this.LoadClass.BackColor = System.Drawing.Color.DimGray;
            this.LoadClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadClass.Location = new System.Drawing.Point(669, 403);
            this.LoadClass.Name = "LoadClass";
            this.LoadClass.Size = new System.Drawing.Size(119, 32);
            this.LoadClass.TabIndex = 2;
            this.LoadClass.Text = "Load Class";
            this.LoadClass.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(560, 55);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(129, 39);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "COSC 1303A";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // ChooseClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.LoadClass);
            this.Controls.Add(this.DeleteClass);
            this.Controls.Add(this.AddClass);
            this.Name = "ChooseClass";
            this.Text = "ChooseClass";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddClass;
        private System.Windows.Forms.Button DeleteClass;
        private System.Windows.Forms.Button LoadClass;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}