namespace back.Model
{
    public class PlanModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Icono { get; set; }
        public string Descripcion { get; set; }
        public decimal Valor { get; set; }
        public string Frecuencia { get; set; }
        public string Codigo { get; set; }
        public int Plan { get; set; }
        public List<ProductoPlanModel> ProductosPlan { get; set; }
    }
}
