using System;
using System.Collections.Generic;
using System.Threading;
using ClinicAppBusinessLogic.Enumerations;
using ClinicAppDataBase.Entities;
using NUnit.Framework;

namespace ClinicAppUnitTests
{
    [TestFixture]
    class MessageBoardTests
    {
        private MessageBoard createMessageBoard()
        {
            var messageBoard = new MessageBoard();
            return messageBoard;
        }

        [Test]
        public void Id_GetCorrectValue_ReturnValue()
        {
            //Setup
            var messageBoard = createMessageBoard();

            //Act
            messageBoard.Id = 1;
            var actualId = messageBoard.Id;

            //Assert
            Assert.AreEqual(messageBoard.Id, actualId);

        }

        [Test]
        public void Id_SetCorrectValue_ReturnValue()
        {
            //Setup
            var messageBoard = createMessageBoard();

            //Act
            var expectedId = 1;
            messageBoard.Id = expectedId;

            //Assert
            Assert.AreEqual(expectedId, messageBoard.Id);
        }

        [Test]
        public void Name_GetCorrectValue_ReturnValue()
        {
            //Setup
            var messageBoard = createMessageBoard();

            //Act
            messageBoard.Name = "Test Data";
            var actualName = messageBoard.Name;

            //Assert
            Assert.AreEqual(messageBoard.Name, actualName);

        }

        [Test]
        public void Name_SetCorrectValue_ReturnValue()
        {
            //Setup
            var messageBoard = createMessageBoard();

            //Act
            var expectedName = "Test Data";
            messageBoard.Name = expectedName;

            //Assert
            Assert.AreEqual(expectedName, messageBoard.Name);
        }

        [Test]
        public void Name_ThrowsArgumentException_EmptyString()
        {
            //Setup
            var messageBoard = createMessageBoard();

            //Act
            var input = "";
            //Assert
            Assert.Throws<ArgumentException>((() => { messageBoard.Name = input; }));
        }

        [Test]
        public void Message_GetCorrectValue_ReturnValue()
        {
            //Setup
            var messageBoard = createMessageBoard();

            //Act
            messageBoard.Message = "Test Data";
            var actualMessage = messageBoard.Message;

            //Assert
            Assert.AreEqual(messageBoard.Message, actualMessage);

        }

        [Test]
        public void Message_SetCorrectValue_ReturnValue()
        {
            //Setup
            var messageBoard = createMessageBoard();

            //Act
            var expectedMessage = "Test Data";
            messageBoard.Message = expectedMessage;

            //Assert
            Assert.AreEqual(expectedMessage, messageBoard.Message);
        }

        [Test]
        public void Message_ThrowsArgumentException_EmptyString()
        {
            //Setup
            var messageBoard = createMessageBoard();

            //Act
            var input = "";
            //Assert
            Assert.Throws<ArgumentException>((() => { messageBoard.Message = input; }));
        }

        [Test]
        public void DateOfMessage_GetCorrectValue_ReturnValue()
        {
            //Setup
            var messageBoard = createMessageBoard();

            //Act
            messageBoard.DateOfMessage = DateTime.Now;
            var actualDate = messageBoard.DateOfMessage;

            //Assert
            Assert.AreEqual(messageBoard.DateOfMessage, actualDate);

        }

        [Test]
        public void DateOfMessage_SetCorrectValue_ReturnValue()
        {
            //Setup
            var messageBoard = createMessageBoard();

            //Act
            var expectedDate = DateTime.Now;
            messageBoard.DateOfMessage = expectedDate;

            //Assert
            Assert.AreEqual(expectedDate, messageBoard.DateOfMessage);
        }

        [Test]
        public void Staffs_GetSetCorrectValue_ReturnValue()
        {
            //Setup
            var messageBoard = createMessageBoard();
            var tempStaff = new Staff();
            tempStaff.Id = 5;

            //Act
            messageBoard.Staff = tempStaff;
            messageBoard.StaffId = tempStaff.Id;
            tempStaff.Id = (int)messageBoard.StaffId;

            //Assert
            Assert.AreEqual(tempStaff, messageBoard.Staff);
        }


    }
}
