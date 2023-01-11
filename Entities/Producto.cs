namespace challenge_back.Entities
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public DateTime FechaCarga { get; set; }
        public byte Categoria { get; set; }
    }
}
