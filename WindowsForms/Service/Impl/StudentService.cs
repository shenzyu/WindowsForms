using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsForms.Enum;

namespace WindowsForms.Service.Impl
{
    class StudentService : IStudentService
    {
        public void AddStudent(Student student)
        {
            using (DataClasses1DataContext dc = new DataClasses1DataContext())
            {
                dc.Student.InsertOnSubmit(student);
                dc.SubmitChanges();
            }
        }

        public void DeleteAllStudent()
        {
            using (DataClasses1DataContext dc = new DataClasses1DataContext())
            {
                var result = from Student in dc.Student
                             where Student.IsDel == (int)IsDeletedEnum.NoDeleted
                             select Student;

                foreach (var st in result)
                {
                    st.IsDel = (int)IsDeletedEnum.IsDeleted;

                }
                dc.SubmitChanges();

            }
        }

        public void DeleteStudent(long Id)
        {
            using (DataClasses1DataContext dc = new DataClasses1DataContext())
            {
                Student student = dc.Student.First(s => s.Id == Id);
                student.IsDel = (int)IsDeletedEnum.IsDeleted;
                dc.SubmitChanges();
                /*var msg = dc.Student.Where(c => c.Id == student.Id);
                dc.Student.DeleteAllOnSubmit(msg);
                dc.SubmitChanges();*/
            }

        }

        public void DeleteStudent(Student student)
        {
            using (DataClasses1DataContext dc = new DataClasses1DataContext())
            {
                var msg = dc.Student.Where(c => c.Id == student.Id);
                dc.Student.DeleteAllOnSubmit(msg);
                dc.SubmitChanges();
            }
        }

        public Student SelectStudendById(long Id)
        {
            using (DataClasses1DataContext dc = new DataClasses1DataContext())
            {
                Student student = dc.Student.First(s => s.Id == Id);
                return student;
            }
        }

        public List<Student> SelectStudendList()
        {
            List<Student> studentList = new List<Student>();
            using (DataClasses1DataContext dc = new DataClasses1DataContext())
            {
                var result = from Student in dc.Student
                             where Student.IsDel ==0
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

        public void UpdateStudendById(Student student)
        {
           
        }
    }
}
