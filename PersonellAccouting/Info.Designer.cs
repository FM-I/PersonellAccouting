
namespace PersonellAccouting
{
    partial class Info
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
            this.StudentGropBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentPhone = new System.Windows.Forms.TextBox();
            this.StudentAdress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentSurnameBox = new System.Windows.Forms.TextBox();
            this.StudentSecondNameBox = new System.Windows.Forms.TextBox();
            this.StudentNameBox = new System.Windows.Forms.TextBox();
            this.SpecialtyGroupBox = new System.Windows.Forms.GroupBox();
            this.StudentYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SpecialtyBox = new System.Windows.Forms.ComboBox();
            this.GroupBox = new System.Windows.Forms.ComboBox();
            this.ParentGroupBox = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ParentOnePhone = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.ParentTwoPhone = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ParentTwoSurname = new System.Windows.Forms.TextBox();
            this.ParentTwoSecondName = new System.Windows.Forms.TextBox();
            this.ParentTwoName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ParentOneSuname = new System.Windows.Forms.TextBox();
            this.ParentOneSecondName = new System.Windows.Forms.TextBox();
            this.ParentOneName = new System.Windows.Forms.TextBox();
            this.ChangeBtn = new System.Windows.Forms.Button();
            this.ConfirmBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.StudentGropBox.SuspendLayout();
            this.SpecialtyGroupBox.SuspendLayout();
            this.ParentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentGropBox
            // 
            this.StudentGropBox.Controls.Add(this.label5);
            this.StudentGropBox.Controls.Add(this.label4);
            this.StudentGropBox.Controls.Add(this.label3);
            this.StudentGropBox.Controls.Add(this.StudentPhone);
            this.StudentGropBox.Controls.Add(this.StudentAdress);
            this.StudentGropBox.Controls.Add(this.label2);
            this.StudentGropBox.Controls.Add(this.label1);
            this.StudentGropBox.Controls.Add(this.StudentSurnameBox);
            this.StudentGropBox.Controls.Add(this.StudentSecondNameBox);
            this.StudentGropBox.Controls.Add(this.StudentNameBox);
            this.StudentGropBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentGropBox.Location = new System.Drawing.Point(12, 12);
            this.StudentGropBox.Name = "StudentGropBox";
            this.StudentGropBox.Size = new System.Drawing.Size(690, 166);
            this.StudentGropBox.TabIndex = 0;
            this.StudentGropBox.TabStop = false;
            this.StudentGropBox.Text = "Студент";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(334, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Адреса проживання";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(334, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Номер телефону";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "По-батькові";
            // 
            // StudentPhone
            // 
            this.StudentPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentPhone.Location = new System.Drawing.Point(490, 32);
            this.StudentPhone.Name = "StudentPhone";
            this.StudentPhone.Size = new System.Drawing.Size(188, 26);
            this.StudentPhone.TabIndex = 3;
            this.StudentPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnluNumber_KeyPress);
            // 
            // StudentAdress
            // 
            this.StudentAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentAdress.Location = new System.Drawing.Point(490, 74);
            this.StudentAdress.Name = "StudentAdress";
            this.StudentAdress.Size = new System.Drawing.Size(188, 26);
            this.StudentAdress.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Прізвище";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ім\'я";
            // 
            // StudentSurnameBox
            // 
            this.StudentSurnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentSurnameBox.Location = new System.Drawing.Point(124, 118);
            this.StudentSurnameBox.Name = "StudentSurnameBox";
            this.StudentSurnameBox.Size = new System.Drawing.Size(188, 26);
            this.StudentSurnameBox.TabIndex = 2;
            // 
            // StudentSecondNameBox
            // 
            this.StudentSecondNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentSecondNameBox.Location = new System.Drawing.Point(124, 71);
            this.StudentSecondNameBox.Name = "StudentSecondNameBox";
            this.StudentSecondNameBox.Size = new System.Drawing.Size(188, 26);
            this.StudentSecondNameBox.TabIndex = 1;
            // 
            // StudentNameBox
            // 
            this.StudentNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentNameBox.Location = new System.Drawing.Point(124, 29);
            this.StudentNameBox.Name = "StudentNameBox";
            this.StudentNameBox.Size = new System.Drawing.Size(188, 26);
            this.StudentNameBox.TabIndex = 0;
            // 
            // SpecialtyGroupBox
            // 
            this.SpecialtyGroupBox.Controls.Add(this.StudentYear);
            this.SpecialtyGroupBox.Controls.Add(this.label6);
            this.SpecialtyGroupBox.Controls.Add(this.label7);
            this.SpecialtyGroupBox.Controls.Add(this.label8);
            this.SpecialtyGroupBox.Controls.Add(this.SpecialtyBox);
            this.SpecialtyGroupBox.Controls.Add(this.GroupBox);
            this.SpecialtyGroupBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpecialtyGroupBox.Location = new System.Drawing.Point(12, 184);
            this.SpecialtyGroupBox.Name = "SpecialtyGroupBox";
            this.SpecialtyGroupBox.Size = new System.Drawing.Size(690, 143);
            this.SpecialtyGroupBox.TabIndex = 1;
            this.SpecialtyGroupBox.TabStop = false;
            this.SpecialtyGroupBox.Text = "Група/Спеціальність";
            // 
            // StudentYear
            // 
            this.StudentYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentYear.Location = new System.Drawing.Point(124, 106);
            this.StudentYear.Name = "StudentYear";
            this.StudentYear.Size = new System.Drawing.Size(188, 26);
            this.StudentYear.TabIndex = 11;
            this.StudentYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnluNumber_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Рік вступу";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(7, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Спеціальність";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(7, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Група";
            // 
            // SpecialtyBox
            // 
            this.SpecialtyBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpecialtyBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpecialtyBox.FormattingEnabled = true;
            this.SpecialtyBox.Location = new System.Drawing.Point(124, 63);
            this.SpecialtyBox.Name = "SpecialtyBox";
            this.SpecialtyBox.Size = new System.Drawing.Size(188, 27);
            this.SpecialtyBox.TabIndex = 1;
            // 
            // GroupBox
            // 
            this.GroupBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GroupBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBox.FormattingEnabled = true;
            this.GroupBox.Location = new System.Drawing.Point(124, 22);
            this.GroupBox.Name = "GroupBox";
            this.GroupBox.Size = new System.Drawing.Size(188, 27);
            this.GroupBox.TabIndex = 0;
            // 
            // ParentGroupBox
            // 
            this.ParentGroupBox.Controls.Add(this.label16);
            this.ParentGroupBox.Controls.Add(this.ParentOnePhone);
            this.ParentGroupBox.Controls.Add(this.label15);
            this.ParentGroupBox.Controls.Add(this.ParentTwoPhone);
            this.ParentGroupBox.Controls.Add(this.label12);
            this.ParentGroupBox.Controls.Add(this.label13);
            this.ParentGroupBox.Controls.Add(this.label14);
            this.ParentGroupBox.Controls.Add(this.ParentTwoSurname);
            this.ParentGroupBox.Controls.Add(this.ParentTwoSecondName);
            this.ParentGroupBox.Controls.Add(this.ParentTwoName);
            this.ParentGroupBox.Controls.Add(this.label9);
            this.ParentGroupBox.Controls.Add(this.label10);
            this.ParentGroupBox.Controls.Add(this.label11);
            this.ParentGroupBox.Controls.Add(this.ParentOneSuname);
            this.ParentGroupBox.Controls.Add(this.ParentOneSecondName);
            this.ParentGroupBox.Controls.Add(this.ParentOneName);
            this.ParentGroupBox.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParentGroupBox.Location = new System.Drawing.Point(12, 333);
            this.ParentGroupBox.Name = "ParentGroupBox";
            this.ParentGroupBox.Size = new System.Drawing.Size(690, 191);
            this.ParentGroupBox.TabIndex = 2;
            this.ParentGroupBox.TabStop = false;
            this.ParentGroupBox.Text = "Батьки студента";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(6, 155);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 17);
            this.label16.TabIndex = 23;
            this.label16.Text = "Номер телефону";
            // 
            // ParentOnePhone
            // 
            this.ParentOnePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParentOnePhone.Location = new System.Drawing.Point(124, 149);
            this.ParentOnePhone.Name = "ParentOnePhone";
            this.ParentOnePhone.Size = new System.Drawing.Size(188, 26);
            this.ParentOnePhone.TabIndex = 22;
            this.ParentOnePhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnluNumber_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(354, 155);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 17);
            this.label15.TabIndex = 21;
            this.label15.Text = "Номер телефону";
            // 
            // ParentTwoPhone
            // 
            this.ParentTwoPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParentTwoPhone.Location = new System.Drawing.Point(490, 152);
            this.ParentTwoPhone.Name = "ParentTwoPhone";
            this.ParentTwoPhone.Size = new System.Drawing.Size(188, 26);
            this.ParentTwoPhone.TabIndex = 20;
            this.ParentTwoPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnluNumber_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(354, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 17);
            this.label12.TabIndex = 19;
            this.label12.Text = "По-батькові";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(354, 73);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "Прізвище";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(354, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 17);
            this.label14.TabIndex = 17;
            this.label14.Text = "Ім\'я";
            // 
            // ParentTwoSurname
            // 
            this.ParentTwoSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParentTwoSurname.Location = new System.Drawing.Point(490, 108);
            this.ParentTwoSurname.Name = "ParentTwoSurname";
            this.ParentTwoSurname.Size = new System.Drawing.Size(188, 26);
            this.ParentTwoSurname.TabIndex = 16;
            // 
            // ParentTwoSecondName
            // 
            this.ParentTwoSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParentTwoSecondName.Location = new System.Drawing.Point(490, 61);
            this.ParentTwoSecondName.Name = "ParentTwoSecondName";
            this.ParentTwoSecondName.Size = new System.Drawing.Size(188, 26);
            this.ParentTwoSecondName.TabIndex = 15;
            // 
            // ParentTwoName
            // 
            this.ParentTwoName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParentTwoName.Location = new System.Drawing.Point(490, 19);
            this.ParentTwoName.Name = "ParentTwoName";
            this.ParentTwoName.Size = new System.Drawing.Size(188, 26);
            this.ParentTwoName.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "По-батькові";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 70);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Прізвище";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(6, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Ім\'я";
            // 
            // ParentOneSuname
            // 
            this.ParentOneSuname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParentOneSuname.Location = new System.Drawing.Point(124, 108);
            this.ParentOneSuname.Name = "ParentOneSuname";
            this.ParentOneSuname.Size = new System.Drawing.Size(188, 26);
            this.ParentOneSuname.TabIndex = 10;
            // 
            // ParentOneSecondName
            // 
            this.ParentOneSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParentOneSecondName.Location = new System.Drawing.Point(124, 64);
            this.ParentOneSecondName.Name = "ParentOneSecondName";
            this.ParentOneSecondName.Size = new System.Drawing.Size(188, 26);
            this.ParentOneSecondName.TabIndex = 9;
            // 
            // ParentOneName
            // 
            this.ParentOneName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ParentOneName.Location = new System.Drawing.Point(124, 22);
            this.ParentOneName.Name = "ParentOneName";
            this.ParentOneName.Size = new System.Drawing.Size(188, 26);
            this.ParentOneName.TabIndex = 8;
            // 
            // ChangeBtn
            // 
            this.ChangeBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeBtn.Location = new System.Drawing.Point(607, 530);
            this.ChangeBtn.Name = "ChangeBtn";
            this.ChangeBtn.Size = new System.Drawing.Size(95, 40);
            this.ChangeBtn.TabIndex = 3;
            this.ChangeBtn.Text = "Редагувати";
            this.ChangeBtn.UseVisualStyleBackColor = true;
            this.ChangeBtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConfirmBtn.Location = new System.Drawing.Point(506, 530);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(95, 40);
            this.ConfirmBtn.TabIndex = 4;
            this.ConfirmBtn.Text = "Підтвердити";
            this.ConfirmBtn.UseVisualStyleBackColor = true;
            this.ConfirmBtn.Visible = false;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelBtn.Location = new System.Drawing.Point(607, 530);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(95, 40);
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "Відмінити";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Visible = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 576);
            this.Controls.Add(this.ConfirmBtn);
            this.Controls.Add(this.ChangeBtn);
            this.Controls.Add(this.ParentGroupBox);
            this.Controls.Add(this.SpecialtyGroupBox);
            this.Controls.Add(this.StudentGropBox);
            this.Controls.Add(this.CancelBtn);
            this.Name = "Info";
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Info_Load);
            this.StudentGropBox.ResumeLayout(false);
            this.StudentGropBox.PerformLayout();
            this.SpecialtyGroupBox.ResumeLayout(false);
            this.SpecialtyGroupBox.PerformLayout();
            this.ParentGroupBox.ResumeLayout(false);
            this.ParentGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox StudentGropBox;
        private System.Windows.Forms.GroupBox SpecialtyGroupBox;
        private System.Windows.Forms.GroupBox ParentGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StudentPhone;
        private System.Windows.Forms.TextBox StudentAdress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StudentSurnameBox;
        private System.Windows.Forms.TextBox StudentSecondNameBox;
        private System.Windows.Forms.TextBox StudentNameBox;
        private System.Windows.Forms.TextBox StudentYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox SpecialtyBox;
        private System.Windows.Forms.ComboBox GroupBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox ParentOnePhone;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox ParentTwoPhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ParentTwoSurname;
        private System.Windows.Forms.TextBox ParentTwoSecondName;
        private System.Windows.Forms.TextBox ParentTwoName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ParentOneSuname;
        private System.Windows.Forms.TextBox ParentOneSecondName;
        private System.Windows.Forms.TextBox ParentOneName;
        private System.Windows.Forms.Button ChangeBtn;
        private System.Windows.Forms.Button ConfirmBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}