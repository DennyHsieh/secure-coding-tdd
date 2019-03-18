using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;

namespace OnlineStoreBackend.Test.Unit
{
    [TestFixture]
    public class RegistrationMgrTests
    {
        [TestCase("usr")]
        [TestCase("user123")]
        [TestCase("chengwei45")]
        [TestCase("123test456")]
        public void IsValidUsername_LegalLengthCharsAndNotExistingUser_ReturnsTrue(string username)
        {
            // Arrange
            IPersistenceMgr fakePersistenceMgr = Substitute.For<IPersistenceMgr>();
            RegistrationMgr regMgr = new RegistrationMgr(fakePersistenceMgr);
            fakePersistenceMgr.UsernameExists(username).Returns(false);

            // Act
            bool isValid = regMgr.IsValidUsername(username);

            // Assert
            Assert.True(isValid);
        }

        // Dependence Breaking
        [TestCase("usr")]
        [TestCase("user123")]
        [TestCase("chengwei45")]
        [TestCase("123test456")]
        public void IsValidUsername_LegalLengthCharsButNotExistingUser_ReturnsTrue(string username)
        {
            // Arrange
            IPersistenceMgr fakePersistenceMgr = Substitute.For<IPersistenceMgr>();
            RegistrationMgr regMgr = new RegistrationMgr(fakePersistenceMgr);
            fakePersistenceMgr.UsernameExists(username).Returns(true);

            // Act
            bool isValid = regMgr.IsValidUsername(username);

            // Assert
            Assert.False(isValid);
        }

        [TestCase("u")]
        [TestCase("us")]
        [TestCase("user5678901")]
        public void IsValidUsername_IllegalUsernameLength_ReturnsFalse(string username)
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
