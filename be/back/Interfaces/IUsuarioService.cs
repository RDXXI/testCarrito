using back.Model;

namespace back.Interfaces
{
    public interface IUsuarioService
    {
        public Task<UsuarioModel> Login(UsuarioModel input);
    }
}
