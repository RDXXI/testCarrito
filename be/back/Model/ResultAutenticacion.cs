namespace back.Model
{
    public class ResultAutenticacion
    {
        public string CodigoRetorno { get; set; }
        public string MensajeRetorno { get; set; }
        public UsuarioModel Usuario { get; set; }
        public string Token { get; set; }
    }
}
