using MvvmCross.Test.Core;
using NUnit.Framework;
using XamBootCamp.ViewModels;

namespace XamBootCamp.UTest
{
    [TestFixture]
    public class FirstViewModelTest : MvxIoCSupportingTest
    {
        public FirstViewModelTest ()
        {
            base.Setup ();
        }

        protected override void AdditionalSetup ()
        {
            // an automatically Mocked service:
            // var firstService = new Mock<IFirstService> ();
            // Ioc.RegisterSingleton<IFirstService> (firstService.Object);
        }

        protected const string _dontPanic = "Don't Panic!";

        [Test]
        public void TestHello ()
        {
            var vm = new FirstViewModel ();
            vm.Hello = _dontPanic;
            Assert.AreEqual (_dontPanic, vm.Hello);
        }

        [Test]
        public void TestInitial ()
        {
            var vm = new FirstViewModel ();

            Assert.AreEqual ("Hello MvvmCross", vm.Hello);
        }
    }
}

