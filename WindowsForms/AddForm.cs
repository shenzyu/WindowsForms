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

        private void Clear_Click(object sender, System.EventArgs e)
        {

        }

        private void AddDate_Click(object sender, System.EventArgs e)
        {
           Student student = CheckImput();
            if(null != student)
            {
                studentService.AddStudent(student);
                this.Close();
                this.Refresh();
            }

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