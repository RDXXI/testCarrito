using back.Model;

namespace back.Interfaces
{
    public interface IUsuarioRepository
    {
        public Task<UsuarioModel> Login(UsuarioModel input);
    }
}
