using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuarioLib
{
    public record struct FormularioDTO(string Nome, string Cpf, int Idade, string Cargo)
    {
    }
}
