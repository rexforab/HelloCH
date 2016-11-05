using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld.Controllers;
using Microsoft.AspNetCore.Mvc;
using HelloService.Interfaces;
using Moq;

namespace HelloWorld.UnitTests
{
    [TestClass]
    public class HelloControllerTests
    {
        [TestMethod]
        public void GetHello_ReturnsHelloString()
        {

            // Arrange
            var mockService = new Mock<IMessageService>();
            mockService.Setup(repo => repo.GetHello()).Returns("Test Success");

            var controller = new HelloController(mockService.Object);

            // Act
            var result = controller.Get();

            // Assert
            Assert.AreEqual(result, "Test Success");

        }
    }
}
