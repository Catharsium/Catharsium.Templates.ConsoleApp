using Catharsium.Templates.ConsoleApp._Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace Catharsium.Templates.ConsoleApp.Tests._Configuration
{
    [TestClass]
    public class RegistrationTests
    {
        [TestMethod]
        public void AddProject_RegistersDependencies()
        {
            var serviceCollection = Substitute.For<IServiceCollection>();
            var configuration = Substitute.For<IConfiguration>();

            serviceCollection.AddCatharsiumProjectClassName(configuration);
        }


        [TestMethod]
        public void AddProject_RegistersPackages()
        {
            var serviceCollection = Substitute.For<IServiceCollection>();
            var configuration = Substitute.For<IConfiguration>();

            serviceCollection.AddCatharsiumProjectClassName(configuration);
        }
    }
}