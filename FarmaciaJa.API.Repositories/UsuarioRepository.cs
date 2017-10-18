using AutoMapper;
using Dapper;
using FarmaciaJa.API.Domain.DTOs;
using FarmaciaJa.API.Domain.Interfaces.Repository;
using FarmaciaJa.API.Repositories.Contexts;
using System.Collections.Generic;
using System.Linq;

namespace FarmaciaJa.API.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private FarmaciaJaContext _contexto;

        public IEnumerable<UsuarioDTO> ListarUsuarios()
        {
            IEnumerable<UsuarioDTO> usuarios;
            
            using (_contexto = new FarmaciaJaContext())
            {
                string query = @"select _id,
	                                    nome,
	                                    email,
	                                    telefone,
	                                    usuario,
	                                    senha,
	                                    logado,
	                                    logarAuto
                                 from farmacia_ja..usuario";
                usuarios = Mapper.Map<IEnumerable<UsuarioDTO>>(_contexto.Database.Connection.Query(query));
            }
            return usuarios;
        }

        public UsuarioDTO BuscarUsuario(int id)
        {
            UsuarioDTO usuario;
            string query = $@"select _id,
	                                 nome,
	                                 email,
	                                 telefone,
	                                 usuario,
	                                 senha,
	                                 logado,
	                                 logarAuto
                              from farmacia_ja..usuario;
                              where _id = {id}";

            using (_contexto = new FarmaciaJaContext())
            {
                var retorno = _contexto.Database.Connection.Query(query);
                usuario = Mapper.Map<UsuarioDTO>(retorno.FirstOrDefault());
            }
            return usuario;
        }
    }
}
