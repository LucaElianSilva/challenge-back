using challenge_back.Entities;
using challenge_back.Interfaces;
using challenge_back.Models;

namespace challenge_back.Services
{
    public class PersonaService : IPersonaService
    {
        private readonly IPersonaRepository _personaRepository;
        public PersonaService(IPersonaRepository personaRepository) {
            _personaRepository = personaRepository;
        }

        public List<Persona> GetPersonas() {
            return _personaRepository.GetAll().ToList();
        }
    }
}
