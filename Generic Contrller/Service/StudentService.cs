using Generic_Contrller.IService;
using Generic_Contrller.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Generic_Contrller.Service
{
    public class StudentService : IGenericService<Student>
    {
        List<Student> lstStudent = new List<Student>();

        public StudentService()
        {
            for (int i = 0; i < 9; i++)
            {
                lstStudent.Add(new Student()
                {
                    StudentId=i,
                    Name="Student"+1,
                    Roll="100"+1

                });


            }
        }
        public List<Student> Delete(int Id)
        {
            lstStudent.RemoveAll(x=>x.StudentId==Id);
            return lstStudent;
        }

        public List<Student> GetAll()
        {
            return lstStudent.ToList();
        }

        public Student GetById(int Id)
        {
            return lstStudent.Where(x => x.StudentId == Id).FirstOrDefault();
        }

        public List<Student> Insert(Student Insert)
        {
            lstStudent.Add(Insert);

            return lstStudent;
        }
    }
}
