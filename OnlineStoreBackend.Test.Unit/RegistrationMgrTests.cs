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
        [TestCase("usr")]
        [TestCase("user123")]
        [TestCase("chengwei45")]
        [TestCase("123test456")]
        public void IsValidUsername_ValidUsername_ReturnsTrue(string username)
        {
            // Arrange
            RegistrationMgr regMgr = new RegistrationMgr();

            // Act
            bool isValid = regMgr.IsValidUsername(username);

            // Assert
            Assert.True(isValid);
        }

        [TestCase("u")]
        [TestCase("us")]
        [TestCase("user5678901")]
        public void IsValidUsername_InvalidUsernameLength_ReturnsFalse(string username)
        {
            // Arrange
            RegistrationMgr regMgr = new RegistrationMgr();

            // Act
            bool isValid = regMgr.IsValidUsername(username);

            // Assert
            Assert.False(isValid);
        }

        [TestCase("“user@123")]
        [TestCase("!user")]
        public void IsValidUsername_InvalidUsernameChars_ReturnsFalse(string username)
        {
            // Arrange
            RegistrationMgr regMgr = new RegistrationMgr();

            // Act
            bool isValid = regMgr.IsValidUsername(username);

            // Assert
            Assert.False(isValid);
        }
    }
}
