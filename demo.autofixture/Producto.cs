namespace demo.autofixture
{
    public class Producto
    {
        public Producto()
        {
            Codigo = string.Empty;
            Nombre = string.Empty;
            Precio = 0;
            Stock = 0;
        }

        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }
}