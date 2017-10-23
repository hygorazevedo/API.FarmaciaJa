using FarmaciaJa.API.Adapters.DTOs;

namespace FarmaciaJa.API.Interfaces.Repository.EF
{
    public interface IFarmaciaRepository
    {
        void CriarFarmacia(FarmaciaDTO farmaciaDTO);
        void AlterarFarmacia(FarmaciaDTO farmaciaDTO);
        void RemoverFarmacia(FarmaciaDTO farmaciaDTO);
    }
}
