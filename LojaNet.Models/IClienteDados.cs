using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaNet.Models
{
    public interface IClienteDados
    {
        void Incluir (Cliente cliente);

        void Alterar (Cliente cliente);

        void Excluir (Cliente cliente);

            List<Cliente> ObterTodos ();
        
        Cliente ObterPorID (string id);

        Cliente ObterPorEmail (string Email);

    }
}
