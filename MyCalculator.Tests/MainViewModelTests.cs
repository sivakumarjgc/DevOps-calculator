using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalculator.ViewModel;

namespace MyCalculator.Tests
{
    [TestClass]
    public class MainViewModelTests
    {
        [TestMethod]
        public void AddCommand_set_good_result()
        {
            var viewModel = new MainViewModel()
            {
                Operator1 = 10,
                Operator2 = 5
            };

            viewModel.AddCommand.Execute(null);

            Assert.AreEqual(15, viewModel.Result);
        }

        [TestMethod]
        public void SubstractCommand_set_good_result()
        {
            var viewModel = new MainViewModel()
            {
                Operator1 = 10,
                Operator2 = 5
            };

            viewModel.SubstractCommand.Execute(null);

            Assert.AreEqual(5, viewModel.Result);
        }

        [TestMethod]
        public void MultiplyCommand_set_good_result()
        {
            var viewModel = new MainViewModel()
            {
                Operator1 = 10,
                Operator2 = 5
            };

            viewModel.MultiplyCommand.Execute(null);

            Assert.AreEqual(50, viewModel.Result);
        }

        [TestMethod]
        public void DivideCommand_set_good_result()
        {
            var viewModel = new MainViewModel()
            {
                Operator1 = 10,
                Operator2 = 5
            };

            viewModel.DivideCommand.Execute(null);

            Assert.AreEqual(2, viewModel.Result);
            Assert.AreEqual(2, viewModel.Result);
        }

        [TestMethod]
        public void DivideCommand_divisionbyzero_ishandled()
        {
            var viewModel = new MainViewModel()
            {
                Operator1 = 10,
                Operator2 = 0
            };

            viewModel.DivideCommand.Execute(null);

            Assert.AreEqual(float.NaN, viewModel.Result);
            Assert.IsFalse(string.IsNullOrEmpty(viewModel.Error));
        }
    }
}
