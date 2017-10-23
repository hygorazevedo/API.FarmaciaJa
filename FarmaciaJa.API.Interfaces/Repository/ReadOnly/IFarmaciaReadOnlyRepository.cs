using FarmaciaJa.API.Adapters.DTOs;
using System.Collections.Generic;

namespace FarmaciaJa.API.Interfaces.Repository.ReadOnly
{
    public interface IFarmaciaReadOnlyRepository
    {
        List<FarmaciaDTO> ListarFarmacias();
        FarmaciaDTO BuscarFarmacia(int id);
    }
}
