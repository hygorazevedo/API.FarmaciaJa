 using AutoMapper;
using FarmaciaJa.API.Adapters.DTOs;
using FarmaciaJa.API.Domain;
using FarmaciaJa.API.Interfaces.Repository.EF;
using FarmaciaJa.API.Repositories.Contexts;

namespace FarmaciaJa.API.Repositories.EF
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private FarmaciaJaContext _contexto;

        public void CriarUsuario(UsuarioDTO usuarioDTO)
        {
            using (_contexto = new FarmaciaJaContext())
            {
                _contexto.Usuarios.Add(Mapper.Map<Usuario>(usuarioDTO));
                _contexto.SaveChanges();
            }
        }

        public void AlterarUsuario(UsuarioDTO usuarioDTO)
        {
            using (_contexto = new FarmaciaJaContext())
            {
                _contexto.Entry(Mapper.Map<Usuario>(usuarioDTO)).State = System.Data.Entity.EntityState.Modified;
                _contexto.SaveChanges();
            }
            using (_contexto = new FarmaciaJaContext())
            {
                _contexto.Entry(Mapper.Map<Endereco>(usuarioDTO.endereco)).State = System.Data.Entity.EntityState.Modified;
                _contexto.SaveChanges();
            }
        }

        public void RemoverUsuario(UsuarioDTO usuarioDTO)
        {
            using (_contexto = new FarmaciaJaContext())
            {
                _contexto.Entry(Mapper.Map<Endereco>(usuarioDTO.endereco)).State = System.Data.Entity.EntityState.Deleted;
                _contexto.SaveChanges();
            }
        }
    }
}
