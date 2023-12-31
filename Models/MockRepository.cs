namespace StdMgtSystem.Models
{
    public class MockRepository : IStudentRepository
    {
        private static List<Students> listStudents = new List<Students>()
        {
            new Students { StudentId = 101, Name = "Abdul Malik", Branch = "CS", Section = "A", Gender = "Male" },
            new Students { StudentId = 102, Name = "Smith", Branch = "ETC", Section = "B", Gender = "Male" },
            new Students { StudentId = 103, Name = "David", Branch = "CSE", Section = "A", Gender = "Male" },
            new Students { StudentId = 104, Name = "Sara", Branch = "CSE", Section = "A", Gender = "Female" },
            new Students { StudentId = 105, Name = "Pam", Branch = "ETC", Section = "B", Gender = "Female" }
        };

        public Students GetStudent(int id)
        {
            return listStudents.FirstOrDefault(std => std.StudentId == id);
        }

        public IEnumerable<Students> GetAllStudents()
        {
            return listStudents;
        }

        public Students Add(Students student)
        {
            student.StudentId = listStudents.Max(e => e.StudentId) + 1;
            listStudents.Add(student);
            return student;
        }
       
        public void Update(Students studentChanges)
        {
            var existingStudent = listStudents.FirstOrDefault(std => std.StudentId == studentChanges.StudentId);
            if (existingStudent != null)
            {
                existingStudent.Name = studentChanges.Name;
                existingStudent.Branch = studentChanges.Branch;
                existingStudent.Section = studentChanges.Section;
                existingStudent.Gender = studentChanges.Gender;
            }
        }

        public void Delete(int id)
        {
            var studentToRemove = listStudents.FirstOrDefault(std => std.StudentId == id);
            if (studentToRemove != null)
            {
                listStudents.Remove(studentToRemove);
            }
        }
    }
}
