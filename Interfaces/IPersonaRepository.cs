using challenge_back.Entities;

namespace challenge_back.Interfaces
{
    public interface IPersonaRepository
    {
        IEnumerable<Persona> GetAll();
    }
}
