using AutoMapper;
using FarmaciaJa.API.Adapters.DTOs;
using FarmaciaJa.API.Domain;
using FarmaciaJa.API.Interfaces.Repository.EF;
using FarmaciaJa.API.Repositories.Contexts;
using System.Data.Entity;

namespace FarmaciaJa.API.Repositories.EF
{
    public class FarmaciaRepository : IFarmaciaRepository
    {
        private FarmaciaJaContext _contexto;

        public void CriarFarmacia(FarmaciaDTO farmaciaDTO)
        {
            using (_contexto = new FarmaciaJaContext())
            {
                _contexto.Farmacias.Add(Mapper.Map<Farmacia>(farmaciaDTO));
                _contexto.SaveChanges();
            }
        }

        public void AlterarFarmacia(FarmaciaDTO farmaciaDTO)
        {
            using (_contexto = new FarmaciaJaContext())
            {
                _contexto.Entry(Mapper.Map<Farmacia>(farmaciaDTO)).State = EntityState.Modified;
                _contexto.SaveChanges();
            }
        }

        public void RemoverFarmacia(FarmaciaDTO farmaciaDTO)
        {
            using (_contexto = new FarmaciaJaContext())
            {
                _contexto.Entry(Mapper.Map<Farmacia>(farmaciaDTO)).State = EntityState.Deleted;
                _contexto.SaveChanges();
            }
        }
    }
}
