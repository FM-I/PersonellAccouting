
namespace PersonellAccouting
{
    partial class ShowFinded
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
            this.OpenStudent = new System.Windows.Forms.Button();
            this.StudentsListBox = new System.Windows.Forms.ListBox();
            this.SortingStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenStudent
            // 
            this.OpenStudent.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenStudent.Location = new System.Drawing.Point(254, 373);
            this.OpenStudent.Name = "OpenStudent";
            this.OpenStudent.Size = new System.Drawing.Size(94, 36);
            this.OpenStudent.TabIndex = 8;
            this.OpenStudent.Text = "Відкрити";
            this.OpenStudent.UseVisualStyleBackColor = true;
            this.OpenStudent.Click += new System.EventHandler(this.OpenStudent_Click);
            // 
            // StudentsListBox
            // 
            this.StudentsListBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentsListBox.FormattingEnabled = true;
            this.StudentsListBox.ItemHeight = 17;
            this.StudentsListBox.Location = new System.Drawing.Point(12, 12);
            this.StudentsListBox.Name = "StudentsListBox";
            this.StudentsListBox.Size = new System.Drawing.Size(378, 344);
            this.StudentsListBox.TabIndex = 7;
            // 
            // SortingStudent
            // 
            this.SortingStudent.BackgroundImage = global::PersonellAccouting.Properties.Resources.alphabetical_sorting;
            this.SortingStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SortingStudent.Location = new System.Drawing.Point(354, 373);
            this.SortingStudent.Name = "SortingStudent";
            this.SortingStudent.Size = new System.Drawing.Size(36, 36);
            this.SortingStudent.TabIndex = 9;
            this.SortingStudent.UseVisualStyleBackColor = true;
            this.SortingStudent.Click += new System.EventHandler(this.SortingStudent_Click);
            // 
            // ShowFinded
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 418);
            this.Controls.Add(this.SortingStudent);
            this.Controls.Add(this.OpenStudent);
            this.Controls.Add(this.StudentsListBox);
            this.Name = "ShowFinded";
            this.Text = "ShowFinded";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SortingStudent;
        private System.Windows.Forms.Button OpenStudent;
        private System.Windows.Forms.ListBox StudentsListBox;
    }
}