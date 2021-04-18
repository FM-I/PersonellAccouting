using StudenrsDB;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PersonellAccouting
{
    public partial class Info : Form
    {
        private Student _student;
        public Info(Student student)
        {
            InitializeComponent();

            _student = student;
        }

        private void LoadInfo()
        {
            if(_student.Id != null)
            {
                StudentNameBox.Text = _student.Name;
                StudentSecondNameBox.Text = _student.SecondName;
                StudentSurnameBox.Text = _student.Surname;
                StudentPhone.Text = _student.Phone;
                StudentAdress.Text = _student.Address;
                StudentYear.Text = _student.YearEntry.ToString();

                ParentOneName.Text = _student.ParentOneName;
                ParentOneSecondName.Text = _student.ParentOneSecondName;
                ParentOneSuname.Text = _student.ParentOneSurname;
                ParentOnePhone.Text = _student.ParentOnePhone;

                ParentTwoName.Text = _student.ParentTwoName;
                ParentTwoSecondName.Text = _student.ParentTwoSecondName;
                ParentTwoSurname.Text = _student.ParentTwoSurname;
                ParentTwoPhone.Text = _student.ParentTwoPhone;
            }

        }

        private void LoadGroup()
        {
            using (var context = new StudentContext())
            {
                var group = context.Groups.ToList();
                var spetialty = context.Specialties.ToList();

                GroupBox.DataSource = group;
                GroupBox.ValueMember = "Id";
                GroupBox.DisplayMember = "Name";

                if(_student.Group != null)
                    GroupBox.SelectedValue = _student.GroupId;

                SpecialtyBox.DataSource = spetialty;
                SpecialtyBox.ValueMember = "Id";
                SpecialtyBox.DisplayMember = "Name";

                if (_student.Group != null)
                    SpecialtyBox.SelectedValue = _student.SpecialtyId;
            }
        }

        private void TextBoxesReadOnly()
        {
            foreach (var control in Controls)
                if (control is GroupBox groupBox)
                    foreach (var textBox in groupBox.Controls)
                    {
                        if (textBox is TextBox box)
                            box.ReadOnly = !box.ReadOnly;
                        if (textBox is ComboBox cBox)
                            cBox.Enabled = !cBox.Enabled;
                    }
                        
        }

        private bool CheckInfo()
        {
            foreach (var control in Controls)
                if (control is GroupBox groupBox && groupBox.Name != "ParentGroupBox")
                    foreach (var textBox in groupBox.Controls)
                        if (textBox is TextBox box && string.IsNullOrWhiteSpace(box.Text)) return false;
            
            return true;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Внести зміни", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.No == result)
                return;

            if (!CheckInfo())
            {
                MessageBox.Show("Заповніть всі дані студента");
                return;
            }
           
            if (_student.Id != null) CurrentStudent();
            else NewStudent();

            LoadInfo();
            ChangeControls();
        }

        private void NewStudent()
        {
            using (var context = new StudentContext())
            {
                _student.Name = StudentNameBox.Text;
                _student.SecondName = StudentSecondNameBox.Text;
                _student.Surname = StudentSurnameBox.Text;
                _student.Phone = StudentPhone.Text;
                _student.Address = StudentAdress.Text;
                _student.YearEntry = Int32.Parse(StudentYear.Text);
                
                _student.ParentOneName = ParentOneName.Text;
                _student.ParentOneSecondName = ParentOneSecondName.Text;
                _student.ParentOneSurname = ParentOneSuname.Text;
                _student.ParentOnePhone = ParentOnePhone.Text;
                
                _student.ParentTwoName = ParentTwoName.Text;
                _student.ParentOneSecondName = ParentTwoSecondName.Text;
                _student.ParentOneSurname = ParentTwoSurname.Text;
                _student.ParentTwoPhone = ParentTwoPhone.Text;
                
                _student.GroupId = (int)GroupBox.SelectedValue;
                _student.SpecialtyId = (int)SpecialtyBox.SelectedValue;

                context.Students.Add(_student);
                context.SaveChanges();
            }   
        }

        private void CurrentStudent()
        {
            using (var context = new StudentContext())
            {
                var student = context.Students.Where(s => s.Id == _student.Id).FirstOrDefault();

                student.Name = StudentNameBox.Text;
                student.SecondName = StudentSecondNameBox.Text;
                student.Surname = StudentSurnameBox.Text;
                student.Phone = StudentPhone.Text;
                student.Address = StudentAdress.Text;
                student.YearEntry = Int32.Parse(StudentYear.Text);

                student.ParentOneName = ParentOneName.Text;
                student.ParentOneSecondName = ParentOneSecondName.Text;
                student.ParentOneSurname = ParentOneSuname.Text;
                student.ParentOnePhone = ParentOnePhone.Text;

                student.ParentTwoName = ParentTwoName.Text;
                student.ParentOneSecondName = ParentTwoSecondName.Text;
                student.ParentOneSurname = ParentTwoSurname.Text;
                student.ParentTwoPhone = ParentTwoPhone.Text;

                student.GroupId = (int)GroupBox.SelectedValue;
                student.SpecialtyId = (int)SpecialtyBox.SelectedValue;
                _student = student;
                context.SaveChanges();
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Введені зміни не збережуться", "Відмінення", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.No == result)
                return;

            if (_student.Id == null) Close();

            LoadInfo();
            ChangeControls();
        }

        private void ChangeBtn_Click(object sender, EventArgs e) => ChangeControls();

        private void ChangeControls()
        {
            if(_student.Id != null)
                TextBoxesReadOnly();

            ConfirmBtn.Visible = !ConfirmBtn.Visible;
            CancelBtn.Visible = !CancelBtn.Visible;
            ChangeBtn.Visible = !ChangeBtn.Visible;
        }

        private void Info_Load(object sender, EventArgs e)
        {
            LoadInfo();
            LoadGroup();

            if (_student.Id != null)
                TextBoxesReadOnly();
            else
                ChangeBtn_Click(null, EventArgs.Empty);
        }

        private void OnluNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
