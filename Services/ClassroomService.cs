using System.Collections.Generic;

namespace ClassroomApp.Services
{
    public class ClassroomService : IClassroomService
    {
        private IList<Student> _students;

        public ClassroomService()
        {
            _students = new List<Student>();

            var student1 = new Student()
            {
                Id = 1,
                Name = "Jon Doe",
                Grade = "1",
            };

            var student2 = new Student()
            {
                Id = 1,
                Name = "Alice",
                Grade = "2",
            };

            _students.Add(student1);
            _students.Add(student2);

        }

        public bool AddStudent(Student student)
        {
            if (student != null)
            {
                _students.Add(student);
                return true;
            }
            return false;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _students;
        }
    }

}