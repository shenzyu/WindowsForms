using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms.Service
{
    interface IStudentService
    {
        /**
         * 根据Id查询
         */
        Student SelectStudendById(long Id);


        /**
        * 列表查询
        */
        List<Student> SelectStudendList();


        /**
        * 列表查询
        */
        void AddStudent(Student student);

        /**
        *逻辑删除ByID
        */
        void DeleteStudent(long Id);

        /**
        *删除,物理删除
        */
        void DeleteStudent(Student student);

        /**
        *删除所有
        */
        void DeleteAllStudent();
    }
}
