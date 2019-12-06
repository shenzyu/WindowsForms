using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            
        }

        public void DeleteStudent(long Id)
        {
            Student student = SelectStudendById(Id);
            
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
                var result = from Student in dc.Student
                             where Student.Id == Id
                             select Student;

                if (null != result && result.Count() == 1)
                {
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
                        return student;
                    }
                }
                return null;
            }
        }

        public List<Student> SelectStudendList()
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
    }
}
