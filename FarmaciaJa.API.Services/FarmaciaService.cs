using FarmaciaJa.API.Adapters.DTOs;
using FarmaciaJa.API.Interfaces.Repository.EF;
using FarmaciaJa.API.Interfaces.Service;

namespace FarmaciaJa.API.Services
{
    public class FarmaciaService : IFarmaciaService
    {
        private IFarmaciaRepository _farmaciaRepository;

        public FarmaciaService(IFarmaciaRepository farmaciaRepository)
        {
            _farmaciaRepository = farmaciaRepository;
        }

        public void CriarFarmacia(FarmaciaDTO farmaciaDTO)
        {
            _farmaciaRepository.CriarFarmacia(farmaciaDTO);
        }

        public void AlterarFarmacia(FarmaciaDTO farmaciaDTO)
        {
            _farmaciaRepository.AlterarFarmacia(farmaciaDTO);
        }

        public void RemoverFarmacia(FarmaciaDTO farmaciaDTO)
        {
            _farmaciaRepository.RemoverFarmacia(farmaciaDTO);
        }
    }
}
