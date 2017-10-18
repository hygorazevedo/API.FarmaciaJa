using Ninject.Modules;
using FarmaciaJa.API.Domain.Interfaces.Service;
using FarmaciaJa.API.Services;
using FarmaciaJa.API.Domain.Interfaces.Repository;
using FarmaciaJa.API.Repositories;

namespace FarmaciaJa.API.Ninject
{
    public class Binding : NinjectModule
    {
        public override void Load()
        {
            Bind<IUsuarioService>().To<UsuarioService>();
            Bind<IUsuarioRepository>().To<UsuarioRepository>();
        }
    }
}