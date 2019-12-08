using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using WindowsForms.Service;
using WindowsForms.Service.Impl;

namespace WindowsForms
{
    public partial class FormList : Form
    {
        private readonly IStudentService studentService = new StudentService();

        public FormList()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            InitListView(this.studentList);


        }

        private void InitListView(ListView studentList)
        {
            List<Student> studentDateList = studentService.SelectStudendList();

            loadListView(studentList, studentDateList);

        }


        private void loadListView(ListView studentList, List<Student> studentDateList)
        {
            //添加列名
            //设置属性
            studentList.GridLines = true;  //显示网格线
            studentList.FullRowSelect = true;  //显示全行
            studentList.MultiSelect = false;  //设置只能单选
            studentList.View = View.Details;  //设置显示模式为详细

            //把列名添加到listView中
            studentList.Columns.Add("编号", 90, HorizontalAlignment.Center);
            studentList.Columns.Add("姓名", 90, HorizontalAlignment.Center);
            studentList.Columns.Add("性别", 90, HorizontalAlignment.Center);
            studentList.Columns.Add("电话", 90, HorizontalAlignment.Center);
            studentList.Columns.Add("籍贯", 100, HorizontalAlignment.Center);

            if (studentDateList.Count > 0)
            {
                this.studentList.BeginUpdate();
                studentDateList.ForEach(s =>
                {
                    ListViewItem studentItem = new ListViewItem();
                    studentItem.Text = s.Id.ToString();
                    studentItem.SubItems.Add(s.Name);
                    switch (s.Sex)
                    {
                        case 0:
                            studentItem.SubItems.Add("男");
                            break;
                        case 1:
                            studentItem.SubItems.Add("女");
                            break;
                    }

                    studentItem.SubItems.Add(s.Phone);
                    studentItem.SubItems.Add(s.NativePlace);
                    studentList.Items.Add(studentItem);
                });

                this.studentList.EndUpdate();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm { Visible = false, StartPosition = FormStartPosition.CenterParent };
            addForm.Refresh += RefreshForm;
            addForm.ShowDialog();
        }


        public void RefreshForm()
        {
            studentList.Items.Clear();
            InitListView(this.studentList);
        }

        private void studentList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DeleteSelect_Click(object sender, EventArgs e)
        {
            Student student = GetSelectStudent();
            studentService.DeleteStudent(student.Id);
            RefreshForm();

        }

        private void DeleteAll_Click(object sender, EventArgs e)
        {
            studentService.DeleteAllStudent();
            RefreshForm();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Student student = GetSelectStudent();
            AddForm addForm = new AddForm(student) { Visible = false, StartPosition = FormStartPosition.CenterParent, Name = "修改" };
            addForm.Refresh += RefreshForm;
            addForm.ShowDialog();
        }

        private Student GetSelectStudent()
        {
            int selectCount = studentList.SelectedItems.Count;
            if (selectCount > 0)//若selectCount大於0，说明用户有选中某列。
            {

                long selcetId = long.Parse(studentList.SelectedItems[0].SubItems[0].Text);
                Student student = studentService.SelectStudendById(selcetId);
                return student;
            }
            return null;

        }

        private void Query_Click(object sender, EventArgs e)
        {
            List<Student> studentDateList = null;
            String name = textQueryName.Text;
            String sex = sexComboBox.Text;
            if (!String.Equals(name, String.Empty))
            {
                studentDateList = studentService.SelectStudendList();
                studentDateList = studentDateList.Where(s => s.Name.Contains(name)).ToList();
            }
            if (!String.Equals(sex, String.Empty))
            {
                if (null == studentDateList)
                {
                   studentDateList = studentService.SelectStudendList();
                }
                switch (sex)
                {
                    case "男":
                        studentDateList = studentDateList.Where(s => s.Sex==0).ToList();
                        break;
                    case "女":
                        studentDateList = studentDateList.Where(s => s.Sex == 1).ToList();
                        break;
                }


            }
            studentList.Items.Clear();
            loadListView(studentList, studentDateList);
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            textQueryName.Text = String.Empty;
            sexComboBox.Text = String.Empty;
        }
    }

}
