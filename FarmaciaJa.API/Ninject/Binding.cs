using Ninject.Modules;
using FarmaciaJa.API.Domain.Interfaces.Service;
using FarmaciaJa.API.Services;
using FarmaciaJa.API.Repositories.ReadOnly;
using FarmaciaJa.API.Domain.Interfaces.Repository.ReadOnly;
using FarmaciaJa.API.Repositories.EF;
using FarmaciaJa.API.Interfaces.Repository.EF;
using FarmaciaJa.API.Interfaces.Repository.ReadOnly;
using FarmaciaJa.API.Interfaces.Service;

namespace FarmaciaJa.API.Ninject
{
    public class Binding : NinjectModule
    {
        public override void Load()
        {
            //Service
            Bind<IFarmaciaService>().To<FarmaciaService>();
            Bind<IProdutoService>().To<ProdutoService>();
            Bind<IUsuarioService>().To<UsuarioService>();

            //EF
            Bind<IFarmaciaRepository>().To<FarmaciaRepository>();
            Bind<IProdutoRepository>().To<ProdutoRepository>();
            Bind<IUsuarioRepository>().To<UsuarioRepository>();

            //ReadOnly
            Bind<IFarmaciaReadOnlyRepository>().To<FarmaciaReadOnlyRepository>();
            Bind<IProdutoReadOnlyRepository>().To<ProdutoReadOnlyRepository>();
            Bind<IUsuarioReadOnlyRepository>().To<UsuarioReadOnlyRepository>();
        }
    }
}