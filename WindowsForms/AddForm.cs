using System.Windows.Forms;
using WindowsForms.Service;
using WindowsForms.Service.Impl;

namespace WindowsForms
{
    public partial class AddForm : Form
    {
        public delegate void RefreshDelegate();
        public event RefreshDelegate Refresh;
        private readonly IStudentService studentService = new StudentService();
        public AddForm()
        {
            InitializeComponent();

        }

        public AddForm(Student student)
        {

            InitializeComponent();

            if (null != student)
            {
                nameText.Text = student.Name;
                switch (student.Sex)
                {
                    case 0:
                        men.Checked = true;
                        break;
                    case 1:
                        women.Checked = true;
                        break;
                }
                phoneText.Text = student.Phone;
                placeText.Text = student.NativePlace;
                Id.Text = student.Id.ToString();
            }

        }

        private void Clear_Click(object sender, System.EventArgs e)
        {
            nameText.Text = string.Empty;
            men.Checked = false;
            women.Checked = false;
            phoneText.Text = string.Empty;
            placeText.Text = string.Empty;
        }

        private void AddDate_Click(object sender, System.EventArgs e)
        {
            Student student = CheckImput();
            if (null != Id.Text)
            {
                //认为是修改操作
                student.Id = long.Parse(Id.Text);
                studentService.UpdateStudend(student);
                RefreshForm1();

            }
            else if (null != student)
            {
                studentService.AddStudent(student);
                RefreshForm1();
            }

        }

        private void RefreshForm1()
        {
            this.Close();
            this.Refresh();
        }

        private Student CheckImput()
        {
            string errorMessage = string.Empty;
            string name = nameText.Text;
            int sex = 3;
            if (men.Checked)
            {
                sex = 0;
            }
            else if (women.Checked)
            {
                sex = 1;
            }
            else
            {
                errorMessage = errorMessage + "请选择性别!\n";
            }
            string phone = phoneText.Text;
            string place = placeText.Text;
            if (string.Empty.Equals(name, System.StringComparison.Ordinal))
            {
                errorMessage += "姓名不能为空!";
            }

            if (!string.Empty.Equals(errorMessage, System.StringComparison.Ordinal))
            {
                MessageBox.Show(errorMessage);
                return null;
            }
            else
            {
                Student student = new Student { Name = name, Sex = sex, Phone = phone, NativePlace = place };

                return student;
            }
        }
    }
}