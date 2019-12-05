using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class FormList : Form
    {
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
           
            //添加列名
            //设置属性
            studentList.GridLines = true;  //显示网格线
            studentList.FullRowSelect = true;  //显示全行
            studentList.MultiSelect = false;  //设置只能单选
            studentList.View = View.Details;  //设置显示模式为详细
            studentList.HoverSelection = true;  //当鼠标停留数秒后自动选择
            //把列名添加到listView中
            studentList.Columns.Add("编号", 90, HorizontalAlignment.Center);
            studentList.Columns.Add("姓名", 90, HorizontalAlignment.Center);
            studentList.Columns.Add("性别", 90, HorizontalAlignment.Center);
            studentList.Columns.Add("电话", 90, HorizontalAlignment.Center);
            studentList.Columns.Add("籍贯", 100, HorizontalAlignment.Center);

            List<Student> studentDateList = SelectStudent();

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
            addForm.refresh += RefreshForm;
            addForm.ShowDialog();
        }

        private List<Student> SelectStudent()
        {
            List<Student> studentList = new List<Student>();
            using (DataClasses1DataContext dc = new DataClasses1DataContext())
            {
                var result = from Student in dc.Student

                             select Student;

                foreach (var st in result)
                {
                    Student student = new Student
                    {
                        Id = st.Id,
                        Name = st.Name,
                        Sex = st.Sex,
                        Phone = st.Phone,
                        NativePlace = st.NativePlace
                    };
                    studentList.Add(student);
                }

            }
            return studentList;
        }
        public void RefreshForm()
        {
            studentList.Items.Clear();
            InitListView(this.studentList);
        }
    }

    
}
