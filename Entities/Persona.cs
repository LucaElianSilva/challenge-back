namespace challenge_back.Entities
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Documento { get; set; }
        public byte Sexo { get; set; }
    }
}
