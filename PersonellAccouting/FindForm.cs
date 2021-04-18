using System;
using System.Linq;
using System.Windows.Forms;
using StudenrsDB;

namespace PersonellAccouting
{
    public partial class FindForm : Form
    {
        public FindForm()
        {
            InitializeComponent();
        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchText.Text))
            {
                MessageBox.Show("Введіть дані для пошуку");
                return;
            }

            using (var context = new StudentContext())
            {
                var students = context.Students.Where(s => s.SecondName.Contains(SearchText.Text));

                if(students.Count() == 0)
                {
                    MessageBox.Show("Нічого незнайдено");
                    return;
                }

                ShowFinded showFinded = new ShowFinded(students);
                showFinded.Show();

                Close();

            }
        }
    }
}
