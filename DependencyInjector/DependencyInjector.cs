using Business;
using DataAccess;
using Domain.Business.Interfaces;
using Domain.Repository;
using SimpleInjector;
using SimpleInjector.Lifestyles;

namespace DependencyInjector
{
	public static class DependencyInjector
    {
		public static void Init(Container container)
		{
			_container = container;
			_container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
			Registrations();
		}

		private static void Registrations()
		{
			_container.Register<IUserBusiness, UserBusiness>(Lifestyle.Scoped);

			_container.Register<IUserRepository, UserRepository>(Lifestyle.Scoped);
		}

		private static Container _container;
	}
}
