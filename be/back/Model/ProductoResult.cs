namespace back.Model
{
    public class ProductoResult
    {
        public string CodigoRetorno { get; set; }
        public string MensajeRetorno { get; set; }
        public List<ProductoModel> Data { get; set; }
    }
}
