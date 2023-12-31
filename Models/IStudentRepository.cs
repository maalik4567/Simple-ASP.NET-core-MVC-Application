namespace StdMgtSystem.Models
{
    public interface IStudentRepository
    {
        Students GetStudent(int id);
        IEnumerable<Students> GetAllStudents();
        Students Add(Students student);
        void Update(Students studentChanges);
        void Delete(int id);
    }
}
