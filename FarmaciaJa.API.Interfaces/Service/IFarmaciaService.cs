using FarmaciaJa.API.Adapters.DTOs;

namespace FarmaciaJa.API.Interfaces.Service
{
    public interface IFarmaciaService
    {
        void CriarFarmacia(FarmaciaDTO farmaciaDTO);
        void AlterarFarmacia(FarmaciaDTO farmaciaDTO);
        void RemoverFarmacia(FarmaciaDTO farmaciaDTO);
    }
}
