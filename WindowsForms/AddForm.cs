using System.Windows.Forms;

namespace WindowsForms
{
    public partial class AddForm : Form
    {
        public delegate void RefreshDelegate();
        public event RefreshDelegate refresh;
        public AddForm()
        {
            InitializeComponent();
        }

        private void clear_Click(object sender, System.EventArgs e)
        {

        }

        private void addDate_Click(object sender, System.EventArgs e)
        {
           Student student = checkImput();
            if(null != student)
            {
                using (DataClasses1DataContext dc = new DataClasses1DataContext())
                {
                    dc.Student.InsertOnSubmit(student);
                    dc.SubmitChanges();
                }
                this.Close();
                this.refresh();
            }

        }

        private Student checkImput()
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