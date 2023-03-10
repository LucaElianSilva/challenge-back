using challenge_back.Entities;
using challenge_back.Interfaces;
using challenge_back.Models;

namespace challenge_back.Repositories
{
    public class PersonaRepository : IPersonaRepository
    {
        private readonly ChallengeContext _dbContext;
        public PersonaRepository(ChallengeContext dbContext)
        {
            _dbContext = dbContext;
        }


        public IEnumerable<Persona> GetAll() {
            return _dbContext.Personas;
        }
    }
}
