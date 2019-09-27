using kcconstruction.BusinessLogic.Interfaces.ValidationService;
using kcconstruction.BusinessLogic.Services.ValidationService;
using NUnit.Framework;

namespace Tests
{
    public class ValidationServiceTests
    {

        private IValidationService _service;
        [SetUp]
        public void Setup()
        {
            _service= new ValidationService();
        }

        [Test]
        public void ValidateFeedbackForm_ValidData_Success()
        {
            //Arrange
            string name = "asdfasdfasdfasdf";
            string email = "asdf@asdf.asdf";
            string phone = "987654321";
            string message = "asdfasdfasdfasdfasdfasdfasdfasdfasdf asdfasdfasdfasdfasdfasdfasdfasdfasdf";

            //Act
            var result = _service.ValidateFeedbackForm(name, email, phone, message);

            //Assert
            Assert.AreEqual(true, result);
        }
    }
}