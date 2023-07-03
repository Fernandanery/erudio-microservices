using RestWithASPNETUdemy.Model;

namespace RestWithASPNETUdemy.Services.Implementations
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindByID(long id);
        List<Person> FindAll(); // retorna uma lista com todas as pessoas
        Person Update(Person person);
        Person Delete(long id);

    }
}
