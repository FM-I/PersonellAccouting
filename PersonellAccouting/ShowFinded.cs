using StudenrsDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PersonellAccouting
{
    public partial class ShowFinded : Form
    {
        public ShowFinded(IQueryable<Student> findedStudents)
        {
            InitializeComponent();
            StudentsListLoad(findedStudents);
        }

        private void StudentsListLoad(IQueryable<Student> findedStudents)
        {
                var students = findedStudents.OrderBy(s => s.SecondName).Select(s => new
                    {
                        Id = s.Id,
                        PIB = s.SecondName + " " + s.Name + " " + s.Surname
                    }).ToList();

                StudentsListBox.DataSource = students;
                StudentsListBox.ValueMember = "Id";
                StudentsListBox.DisplayMember = "PIB";
        }

        private void OpenStudent_Click(object sender, EventArgs e)
        {
            var id = StudentsListBox.SelectedValue;

            if(id == null)
            {
                MessageBox.Show("Оберіть запис");
                return;
            }


            using (var context = new StudentContext())
            {
                var student = context.Students.Where(s => s.Id == (int?)id).FirstOrDefault();

                if (student != null)
                {
                    Info info = new Info(student);
                    info.Show();
                }
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
    }
}
