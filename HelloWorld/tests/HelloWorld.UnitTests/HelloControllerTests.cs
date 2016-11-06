using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld.Controllers;
using HelloService.Interfaces;
using Moq;
using HelloEntities;

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
            mockService.Setup(repo => repo.GetMessage(It.IsAny<int>())).Returns(new Message() { HelloMessage = "Test Success" });

            var controller = new HelloController(mockService.Object);

            // Act
            var result = controller.Get();

            // Assert
            Assert.AreEqual(result, "Test Success");

        }
    }
}
