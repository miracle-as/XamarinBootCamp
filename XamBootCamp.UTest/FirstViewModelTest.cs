using MvvmCross.Test.Core;
using NUnit.Framework;
using XamBootCamp.ViewModels;

namespace XamBootCamp.UTest
{
    [TestFixture]
    public class FirstViewModelTest : MvxIoCSupportingTest
    {
        private MockApplicationVersionService _applicationVersionService;

        public FirstViewModelTest ()
        {
            base.Setup ();
        }

        protected override void AdditionalSetup ()
        {
            // an automatically Mocked service:
            // var firstService = new Mock<IFirstService> ();
            // Ioc.RegisterSingleton<IFirstService> (firstService.Object);

            _applicationVersionService = new MockApplicationVersionService();
        }

        protected const string _dontPanic = "Don't Panic!";

        [Test]
        public void TestInitial()
        {
            var vm = new FirstViewModel(_applicationVersionService);

            Assert.AreEqual("Hello MvvmCross", vm.Hello);
        }

        [Test]
        public void TestHello ()
        {
            var vm = new FirstViewModel (_applicationVersionService);
            vm.Hello = _dontPanic;
            Assert.AreEqual (_dontPanic, vm.Hello);
        }
    }
}

