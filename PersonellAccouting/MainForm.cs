using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using StudenrsDB;

namespace PersonellAccouting
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            GroupsLoad();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StudentsListLoad();
        }

        private void GroupComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(GroupComboBox.SelectedIndex != -1)
                StudentsListLoad();
        }

        private void GroupsLoad()
        {
            using (var context = new StudentContext())
            {
                var Groups = context.Groups.AsNoTracking().ToList();

                GroupComboBox.DataSource = Groups;
                GroupComboBox.ValueMember = "Id";
                GroupComboBox.DisplayMember = "Name";
            }

        }

        private void StudentsListLoad()
        {
            using (var context = new StudentContext())
            {
                int groupId = ((Group)GroupComboBox.SelectedItem).Id;

                var students = context.Students
                    .Where(s => s.GroupId == groupId)
                .OrderBy(s => s.SecondName)
                .Select(s => new
                 {
                     Id = s.Id,
                     PIB = s.SecondName + " " + s.Name + " " + s.Surname
                 })
                .ToList();

                StudentsListBox.DataSource = students;
                StudentsListBox.ValueMember = "Id";
                StudentsListBox.DisplayMember = "PIB";
            }
        }

        private void SortingStudent_Click(object sender, EventArgs e)
        {
            List<object> list = new List<object>();

            foreach (var item in StudentsListBox.Items)
                list.Add(item);

            list.Reverse();

            StudentsListBox.DataSource = list;
            StudentsListBox.ValueMember = "Id";
            StudentsListBox.DisplayMember = "PIB";
        }

        private void RemoveStudent_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Видалити?", "Видалення",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.No) return;

            var id = StudentsListBox.SelectedValue;

            if (id == null)
            {
                MessageBox.Show("Оберіть елемент для видалення");
                return;
            }

            using (var context = new StudentContext())
            {
                var student = context.Students.Where(s => s.Id == (int?)id).FirstOrDefault();
                context.Students.Remove(student);
                context.SaveChanges();
            }
            StudentsListLoad();
        }

        private void FindStudent_Click(object sender, EventArgs e)
        {
            FindForm find = new FindForm();
            find.Show();
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            Info info = new Info(new Student());
            info.Show();
        }

        private void OpenStudent_Click(object sender, EventArgs e)
        {
            var id = (int?)StudentsListBox.SelectedValue;

            if (id == null)
            {
                MessageBox.Show("Оберіть запис");
                return;
            }
            
            using (var context = new StudentContext())
            {
                var student = context.Students.Where(s => id == s.Id).FirstOrDefault();

                if (student != null)
                {
                    Info info = new Info(student);
                    info.Show();
                }
            }

        }

        private void MainForm_Activated(object sender, EventArgs e) =>  StudentsListLoad();
    }
}
