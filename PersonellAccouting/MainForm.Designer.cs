
namespace PersonellAccouting
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.GroupComboBox = new System.Windows.Forms.ComboBox();
            this.StudentsListBox = new System.Windows.Forms.ListBox();
            this.AddStudent = new System.Windows.Forms.Button();
            this.RemoveStudent = new System.Windows.Forms.Button();
            this.OpenStudent = new System.Windows.Forms.Button();
            this.SortingStudent = new System.Windows.Forms.Button();
            this.FindStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GroupComboBox
            // 
            this.GroupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupComboBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupComboBox.FormattingEnabled = true;
            this.GroupComboBox.Location = new System.Drawing.Point(12, 12);
            this.GroupComboBox.Name = "GroupComboBox";
            this.GroupComboBox.Size = new System.Drawing.Size(169, 25);
            this.GroupComboBox.TabIndex = 0;
            this.GroupComboBox.SelectedIndexChanged += new System.EventHandler(this.GroupComboBox_SelectedIndexChanged);
            // 
            // StudentsListBox
            // 
            this.StudentsListBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentsListBox.FormattingEnabled = true;
            this.StudentsListBox.ItemHeight = 17;
            this.StudentsListBox.Location = new System.Drawing.Point(187, 12);
            this.StudentsListBox.Name = "StudentsListBox";
            this.StudentsListBox.Size = new System.Drawing.Size(378, 344);
            this.StudentsListBox.TabIndex = 1;
            // 
            // AddStudent
            // 
            this.AddStudent.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddStudent.Location = new System.Drawing.Point(187, 373);
            this.AddStudent.Name = "AddStudent";
            this.AddStudent.Size = new System.Drawing.Size(94, 36);
            this.AddStudent.TabIndex = 2;
            this.AddStudent.Text = "Додати";
            this.AddStudent.UseVisualStyleBackColor = true;
            this.AddStudent.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // RemoveStudent
            // 
            this.RemoveStudent.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveStudent.Location = new System.Drawing.Point(287, 373);
            this.RemoveStudent.Name = "RemoveStudent";
            this.RemoveStudent.Size = new System.Drawing.Size(94, 36);
            this.RemoveStudent.TabIndex = 3;
            this.RemoveStudent.Text = "Видалити";
            this.RemoveStudent.UseVisualStyleBackColor = true;
            this.RemoveStudent.Click += new System.EventHandler(this.RemoveStudent_Click);
            // 
            // OpenStudent
            // 
            this.OpenStudent.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpenStudent.Location = new System.Drawing.Point(387, 373);
            this.OpenStudent.Name = "OpenStudent";
            this.OpenStudent.Size = new System.Drawing.Size(94, 36);
            this.OpenStudent.TabIndex = 4;
            this.OpenStudent.Text = "Відкрити";
            this.OpenStudent.UseVisualStyleBackColor = true;
            this.OpenStudent.Click += new System.EventHandler(this.OpenStudent_Click);
            // 
            // SortingStudent
            // 
            this.SortingStudent.BackgroundImage = global::PersonellAccouting.Properties.Resources.alphabetical_sorting;
            this.SortingStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SortingStudent.Location = new System.Drawing.Point(529, 373);
            this.SortingStudent.Name = "SortingStudent";
            this.SortingStudent.Size = new System.Drawing.Size(36, 36);
            this.SortingStudent.TabIndex = 6;
            this.SortingStudent.UseVisualStyleBackColor = true;
            this.SortingStudent.Click += new System.EventHandler(this.SortingStudent_Click);
            // 
            // FindStudent
            // 
            this.FindStudent.BackgroundImage = global::PersonellAccouting.Properties.Resources._58427;
            this.FindStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FindStudent.Location = new System.Drawing.Point(487, 373);
            this.FindStudent.Name = "FindStudent";
            this.FindStudent.Size = new System.Drawing.Size(36, 36);
            this.FindStudent.TabIndex = 5;
            this.FindStudent.UseVisualStyleBackColor = true;
            this.FindStudent.Click += new System.EventHandler(this.FindStudent_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 419);
            this.Controls.Add(this.SortingStudent);
            this.Controls.Add(this.FindStudent);
            this.Controls.Add(this.OpenStudent);
            this.Controls.Add(this.RemoveStudent);
            this.Controls.Add(this.AddStudent);
            this.Controls.Add(this.StudentsListBox);
            this.Controls.Add(this.GroupComboBox);
            this.Name = "MainForm";
            this.Text = "Учет кадров студентов";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox GroupComboBox;
        private System.Windows.Forms.ListBox StudentsListBox;
        private System.Windows.Forms.Button AddStudent;
        private System.Windows.Forms.Button RemoveStudent;
        private System.Windows.Forms.Button OpenStudent;
        private System.Windows.Forms.Button FindStudent;
        private System.Windows.Forms.Button SortingStudent;
    }
}

