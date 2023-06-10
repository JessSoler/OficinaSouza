using Oficina;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Oficina
{
    public class Conexao
    {
        public SqlConnection banco = null;

        public Conexao()
        {
            if (banco == null)
                banco = new SqlConnection(Sessao.StringConn);
        }
    }
}
