using Oficina.Mapeamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Drawing;
using System.Data.SqlClient;

namespace Oficina.Negocios
{
    public class UsuarioDAO : Conexao
    {
        public Usuario Login(string Email, string senha)
        {
            try
            {
              var usuario =  banco.Query<Usuario>(
                    @"SELECT  
                        ID, Nome, Email, Ativo, AcessaCategorias, AcessaProdutos, AcessaUsuarios 
                      FROM 
                        Usuarios 
                      WHERE 
                        Email = @pEmail and Senha = @pSenha",
                    new
                    {
                        pEmail = Email,
                        pSenha = senha
                    }).SingleOrDefault();

                return usuario;
            }
            catch 
            {
                return null;
            }
        }

        public bool CompararSenhas(int id, string senha)
        {
            try
            {
                var usuario = banco.Query<Usuario>(
                      @"SELECT  
                        ID, Nome, Email, Senha 
                      FROM 
                        Usuarios 
                      WHERE 
                        ID = @pID",
                      new
                      {
                          pID = id
                      }).SingleOrDefault();

                return usuario.Senha == senha;
            }
            catch
            {
                return false;
            }
        }

        public bool AlterarPerfil(Usuario usuario)
        {
            return banco.Execute("update usuarios set " +
                "nome=@nome, " +
                "Email=@Email " +
                "where id=@id",
                usuario)== 1;
        }

        public bool AlterarSenha(Usuario usuario)
        {
            return banco.Execute("update usuarios set " +
                "senha=@senha " +
                "where id=@id",
                usuario) == 1;
        }
        public void Adicionar(string Nome, string Email, string Senha, bool AcessaCategorias, bool AcessaProdutos, bool AcessaUsuarios, bool Ativo)
        {
                banco.Execute("INSERT INTO Usuarios (Nome, Email, Senha, AcessaCategorias, AcessaProdutos, AcessaUsuarios, Ativo) VALUES (@Nome, @Email, @Senha, @AcessaCategorias, @AcessaProdutos,@AcessaUsuarios, @Ativo",
                new { Nome, Email, Senha, AcessaCategorias, AcessaProdutos, AcessaUsuarios, Ativo });
            
        }
        public void Excluir(int ID)
        {
            banco.Execute("DELETE FROM Usuarios WHERE ID=@ID",
             new { ID });
        }
        public List<Usuario> ListarTodas()
        {
            return banco.Query<Usuario>("SELECT * FROM Usuarios order by ID").ToList();
        }

    }
}
