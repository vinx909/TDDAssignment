using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDDAssignment.Program.Entities;
using TDDAssignment.Program.Interface;
using TDDAssignment.Program.Service;
using Xunit;

namespace TDDassignment.Program.Test.UserServiceTest
{
    public class Save
    {
        [Fact]
        public void Throw_ArgumentNullException_When_Lastname_Is_Null()
        {
            //arrange
            IUserService userService = new UserService();
            User user = new();

            //act
            var exception = Assert.Throws<ArgumentNullException>(() => userService.Save(user));

            //assert
            Assert.Equal("Value cannot be null. (Parameter 'Lastname')", exception.Message);
        }
        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("   ")]
        public void Throw_ArgumentException_When_Lastname_Is_Empty(string lastname)
        {
            //arrange
            IUserService userService = new UserService();
            User user = new() { Lastname = lastname };

            //act
            var exception = Assert.Throws<ArgumentException>(() => userService.Save(user));

            //assert
            Assert.Equal("Lastname", exception.Message);
        }

        [Fact]
        public void Throw_ArgumentNullException_When_Email_Is_Null()
        {
            //arrange
            IUserService userService = new UserService();
            User user = new() { Lastname = "Test" };

            //act
            var exception = Assert.Throws<ArgumentNullException>(() => userService.Save(user));

            //assert
            Assert.Equal("Value cannot be null. (Parameter 'Email')", exception.Message);
        }
        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData("test")]
        [InlineData("test@test")]
        [InlineData("@test")]
        [InlineData("@test.te")]
        public void Throw_ArgumentException_When_Email_Is_invalid(string email)
        {
            //arrange
            IUserService userService = new UserService();
            User user = new() { Lastname = "Test", Email = email };

            //act
            var exception = Assert.Throws<ArgumentException>(() => userService.Save(user));

            //assert
            Assert.Equal("Email", exception.Message);
        }
    }
}
