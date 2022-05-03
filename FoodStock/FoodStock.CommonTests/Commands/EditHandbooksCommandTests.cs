using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using FoodStock.Common.DomainModel;

namespace FoodStock.Common.Commands.Tests
{
    [TestClass()]
    public class EditHandbooksCommandTests
    {
        [TestMethod()]
        public void ExecuteTest()
        {
            var presenterMock = new Mock<IHandbooksPresenter>();
            var handbooksRepositoryMock = new Mock<IHandbooksRepository>();

            var handbook = new Handbook();
            handbooksRepositoryMock.Setup(rpstr => rpstr.GetHandbook()).Returns(handbook);
            

            OpenHandbookCommand command = new OpenHandbookCommand(handbooksRepositoryMock.Object, presenterMock.Object);
            command.Execute();

            presenterMock.Verify(pr => pr.Show(It.Is<Handbook>(hb => hb == handbook)), Times.Once, "Команда должна забирать справочник из репозитария и отдавать его в для отображения");

        }
    }
}