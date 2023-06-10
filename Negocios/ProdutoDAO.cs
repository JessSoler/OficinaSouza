using Dapper;
using Oficina.Mapeamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Negocios
{
    public class ProdutoDAO : Conexao
    {

        public List<Produto> ListarTodas()
        {
            return banco.Query<Produto>("SELECT * FROM Produtos order by ID").ToList();
        }
    }
    //public void ExcluirProduto(int ID)
    //{
    //    banco.Execute("DELETE FROM Produtos WHERE ID=@ID",
    //     new { ID });
    //}

    //public void AdicionarProduto(string Nome, string Marca, int Quantidade, decimal ValorUnitario)
    //{
    //    banco.Execute("INSERT INTO Usuarios (Nome, Marca, Quantidade, ValorUnitario) VALUES (@Nome, @Marca, @Quantidade, @ValorUnitario",
    //    new { Nome, Email, Quantidade, ValorUnitario});

    //}
}
