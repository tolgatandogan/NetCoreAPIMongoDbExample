using NetCoreAPIMongoDbExample.Models;

namespace NetCoreAPIMongoDbExample.Services
{
    public interface IStudentService
    {
        List<Student> Get();
        Student Get(string id);
        Student Create(Student student);
        void Update(string id,Student student);
        void Delete(string id);

    }
}
