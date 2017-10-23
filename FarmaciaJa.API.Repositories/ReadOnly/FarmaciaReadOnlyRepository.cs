using System;
using System.Collections.Generic;
using FarmaciaJa.API.Adapters.DTOs;
using FarmaciaJa.API.Interfaces.Repository.ReadOnly;
using FarmaciaJa.API.Repositories.Contexts;
using Dapper;

namespace FarmaciaJa.API.Repositories.ReadOnly
{
    public class FarmaciaReadOnlyRepository : IFarmaciaReadOnlyRepository
    {
        private FarmaciaJaContext _contexto;
        
        public List<FarmaciaDTO> ListarFarmacias()
        {
            List<FarmaciaDTO> farmacias = new List<FarmaciaDTO>();
            using (_contexto = new FarmaciaJaContext())
            {
                string query = @"select *
                                 from farmaciaja..farmacia f";
                var lista = _contexto.Database.Connection.Query(query);
                foreach (var item in lista)
                {
                    farmacias.Add(new FarmaciaDTO
                    {
                        _id = item._id,
                        descFarmacia = item.descFarmacia,
                        endereco = item.endereco,
                        mediaTempoEntrega = item.mediaTempoEntrega,
                        mediaNotaAtendimento = item.mediaNotaAtendimento,
                        informacoesFarmacia = item.informacoesFarmacia
                    });
                }
            }
            return farmacias;
        }

        public FarmaciaDTO BuscarFarmacia(int id)
        {
            FarmaciaDTO farmacia = new FarmaciaDTO();
            string query = $@"select *
                              from farmaciaja..farmacia f
                              where f._id = {id}";

            using (_contexto = new FarmaciaJaContext())
            {
                var lista = _contexto.Database.Connection.Query(query);
                foreach (var item in lista)
                {
                    farmacia._id = item._id;
                    farmacia.descFarmacia = item.descFarmacia;
                    farmacia.endereco = item.endereco;
                    farmacia.mediaTempoEntrega = item.mediaTempoEntrega;
                    farmacia.mediaNotaAtendimento = item.mediaNotaAtendimento;
                    farmacia.informacoesFarmacia = item.informacoesFarmacia;
                }
            }
            return farmacia;
        }
    }
}
