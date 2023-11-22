using back.Interfaces;
using back.Migrations;
using back.Model;
using Microsoft.EntityFrameworkCore;

namespace back.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private AplicationContext _context;
        public UsuarioRepository(AplicationContext context)
        {
            _context = context;
        }
        public async Task<UsuarioModel> Login(UsuarioModel input)
        {
            //return _context.UsuarioModel.FirstOrDefault(x=> x.Password.Equals(input.Password) && x.Email.Equals(input.Email));
            if (input.Email.Equals("ruben777_93@hotmail.com") && input.Password.Equals("2023"))
            {
                return new UsuarioModel { Password = "2023", Email = "ruben777_93hotmail.com", Id = 1 };
            }
            else
            {
                return null;
            }
        }
    }
}
