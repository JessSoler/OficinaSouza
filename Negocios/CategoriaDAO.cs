using Dapper;
using Oficina.Mapeamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Negocios
{
    public class CategoriaDAO : Conexao
    {
        public List<Categoria> ListarTodas()
        {
            return banco.Query<Categoria>("SELECT * FROM Categorias order by ID").ToList();
        }
    }
}
