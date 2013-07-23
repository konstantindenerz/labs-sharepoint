using Lab.Core.Dao;
using Lab.Core.Dao.Adapter;
using Lab.Core.Dao.Adapter.Internal;
using Lab.Core.Dao.Internal;
using Lab.Core.DomainObjects;
using Lab.Core.Services;
using Lab.Core.Services.Internal;
using Ninject;

namespace Lab.Core.Di
{
    public class KernelConfiguration
    {
        private static IKernel kernel;
        public static IKernel GetDefault()
        {
            
            if (null == kernel)
            {
                CreateKernelInstance();
            }

            return kernel;
        }

        private static void CreateKernelInstance()
        {
            //kernel = new StandardKernel();
            ////TODO Move this code to seperate modules...
            //kernel.Bind(typeof(IObjectAdministrationService<>)).To(typeof(GenericObjectAdministrationService<>));
            //kernel.Bind(typeof(IObjectDao<>)).To(typeof(GenericObjectDao<>));
            //kernel.Bind(typeof(IDataAssembler<>)).To(typeof(GenericDataAssembler<>));
            //kernel.Bind(typeof(IDataAdapter<>)).To(typeof(HeroSecretBaseAdapter<>));
            //kernel.Bind(typeof(IDataAdapter<>)).To(typeof(OtherUnusedAdapter<>));
            //kernel.Bind(typeof(IDataAdapter<>)).To(typeof(HeroNameAdapter<>));
            //kernel.Bind(typeof(IListItemDispatcher<>)).To(typeof(MockListItemDispatcher<>));
            //OtherStuff();
        }

        private static void OtherStuff()
        {
            //ObjectFactory.Register<IHero>(new HeroFactoryStrategy());
        }
    }

}
