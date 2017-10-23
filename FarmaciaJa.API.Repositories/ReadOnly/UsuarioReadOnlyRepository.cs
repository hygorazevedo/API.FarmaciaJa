using Dapper;
using FarmaciaJa.API.Adapters.DTOs;
using FarmaciaJa.API.Domain.Interfaces.Repository.ReadOnly;
using FarmaciaJa.API.Repositories.Contexts;
using System.Collections.Generic;

namespace FarmaciaJa.API.Repositories.ReadOnly
{
    public class UsuarioReadOnlyRepository : IUsuarioReadOnlyRepository
    {
        private FarmaciaJaContext _contexto;

        public List<UsuarioDTO> ListarUsuarios()
        {
            List<UsuarioDTO> usuarios = new List<UsuarioDTO>();
            using (_contexto = new FarmaciaJaContext())
            {
                string query = @"select *
                                 from farmaciaja..usuario u
                                 inner join farmaciaja..endereco e
                                 on e._id = u._id";
                var lista = _contexto.Database.Connection.Query(query);
                foreach (var item in lista)
                {
                    usuarios.Add(new UsuarioDTO
                    { _id = item._id,
                        nome = item.nome,
                        email = item.email,
                        telefone = item.telefone,
                        usuario = item.usuario,
                        senha = item.senha,
                        logado = item.logado,
                        logarAuto = item.logarAuto,
                        endereco = new EnderecoDTO
                        {
                            _id = item._id,
                            logradouro = item.logradouro,
                            numero = item.numero,
                            complemento = item.complemento,
                            bairro = item.bairro,
                            cidade = item.cidade,
                            Estado = item.estado
                        }
                    });
                }
            }
            return usuarios;
        }

        public UsuarioDTO BuscarUsuario(int id)
        {
            UsuarioDTO usuario = new UsuarioDTO();
            string query = $@"select *
                              from farmaciaja..usuario u
                              inner join farmaciaja..endereco e
                              on e._id = u._id
                              where u._id = {id}";

            using (_contexto = new FarmaciaJaContext())
            {
                var lista = _contexto.Database.Connection.Query(query);
                foreach (var item in lista)
                {
                    usuario._id = item._id;
                    usuario.nome = item.nome;
                    usuario.email = item.email;
                    usuario.telefone = item.telefone;
                    usuario.usuario = item.usuario;
                    usuario.senha = item.senha;
                    usuario.logado = item.logado;
                    usuario.logarAuto = item.logarAuto;
                    usuario.endereco = new EnderecoDTO
                    {
                        _id = item._id,
                        logradouro = item.logradouro,
                        numero = item.numero,
                        complemento = item.complemento,
                        bairro = item.bairro,
                        cidade = item.cidade,
                        Estado = item.estado
                    };
                }
            }
            return usuario;
        }
    }
}
