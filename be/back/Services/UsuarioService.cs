using back.Interfaces;
using back.Migrations;
using back.Model;
using Microsoft.IdentityModel.Abstractions;

namespace back.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly AplicationContext _aplicationContext;
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioService(AplicationContext aplicationContext, IUsuarioRepository usuarioRepository)
        {
            _aplicationContext = aplicationContext;
            _usuarioRepository = usuarioRepository;
        }
        public async Task<UsuarioModel> Login(UsuarioModel input)
        {
            //return await _usuarioRepository.Login(input);
            var result = await _usuarioRepository.Login(input);
            if (result.Id > 0)
                return result;
            return null;
        }

    }
}
