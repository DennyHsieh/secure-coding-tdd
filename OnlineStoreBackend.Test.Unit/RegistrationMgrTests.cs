using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStoreBackend.Test.Unit
{
    [TestFixture]
    public class RegistrationMgrTests
    {
        [Test]
        public void IsValidUsername_ValidUsername_ReturnsTrue()
        {
            // Arrange
            RegistrationMgr regMgr = new RegistrationMgr();

            // Act
            bool isValid = regMgr.IsValidUsername("user");

            // Assert
            Assert.True(isValid);
        }
    }
}
