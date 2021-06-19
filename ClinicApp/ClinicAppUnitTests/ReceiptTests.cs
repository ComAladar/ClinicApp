using System;
using System.Collections.Generic;
using System.Threading;
using ClinicAppBusinessLogic.Enumerations;
using ClinicAppDataBase.Entities;
using NUnit.Framework;


namespace ClinicAppUnitTests
{
    [TestFixture]
    class ReceiptTests
    {
        private Receipt CreateReceipt()
        {
            var receipt = new Receipt();
            return receipt;
        }


        [Test]
        public void Id_GetCorrectValue_ReturnValue()
        {
            //Setup
            var receipt = CreateReceipt();

            //Act
            receipt.Id = 1;
            var actualId = receipt.Id;

            //Assert
            Assert.AreEqual(receipt.Id, actualId);

        }

        [Test]
        public void Id_SetCorrectValue_ReturnValue()
        {
            //Setup
            var receipt = CreateReceipt();

            //Act
            var expectedId = 1;
            receipt.Id = expectedId;

            //Assert
            Assert.AreEqual(expectedId, receipt.Id);
        }

        [Test]
        public void ReceiptNumber_GetCorrectValue_ReturnValue()
        {
            //Setup
            var receipt = CreateReceipt();

            //Act
            receipt.ReceiptNumber = 1;
            var actualNumber = receipt.ReceiptNumber;

            //Assert
            Assert.AreEqual(receipt.ReceiptNumber, actualNumber);

        }

        [Test]
        public void ReceiptNumber_SetCorrectValue_ReturnValue()
        {
            //Setup
            var receipt = CreateReceipt();

            //Act
            var expectedNumber = 1;
            receipt.ReceiptNumber = expectedNumber;

            //Assert
            Assert.AreEqual(expectedNumber, receipt.ReceiptNumber);
        }

        [Test]
        public void Price_GetCorrectValue_ReturnValue()
        {
            //Setup
            var receipt = CreateReceipt();

            //Act
            receipt.Price = 1.1;
            var actualPrice = receipt.Price;

            //Assert
            Assert.AreEqual(receipt.Price, actualPrice);

        }

        [Test]
        public void Price_SetCorrectValue_ReturnValue()
        {
            //Setup
            var receipt = CreateReceipt();

            //Act
            var expectedPrice = 1.1;
            receipt.Price = expectedPrice;

            //Assert
            Assert.AreEqual(expectedPrice, receipt.Price);
        }

        [Test]
        public void Status_GetCorrectValue_ReturnValue()
        {
            //Setup
            var receipt = CreateReceipt();

            //Act
            receipt.Status = ReceiptStatus.Paid;
            var actualStatus = receipt.Status;

            //Assert
            Assert.AreEqual(receipt.Status, actualStatus);

        }

        [Test]
        public void Status_SetCorrectValue_ReturnValue()
        {
            //Setup
            var receipt = CreateReceipt();

            //Act
            var expectedStatus = ReceiptStatus.Paid;
            receipt.Status = expectedStatus;

            //Assert
            Assert.AreEqual(expectedStatus, receipt.Status);
        }

        [Test]
        public void Staffs_GetSetCorrectValue_ReturnValue()
        {
            //Setup
            var receipt = CreateReceipt();
            var tempStaff = new Staff();
            tempStaff.Id = 5;

            //Act
            receipt.Staff = tempStaff;
            receipt.StaffId = tempStaff.Id;
            tempStaff.Id = (int)receipt.StaffId;

            //Assert
            Assert.AreEqual(tempStaff,receipt.Staff);
        }

        [Test]
        public void Appointments_GetSetCorrectValue_ReturnValue()
        {
            //Setup
            var receipt = CreateReceipt();
            var tempAppointment = new Appointment();

            //Act
            receipt.Appointment = tempAppointment;

            //Assert
            Assert.AreEqual(tempAppointment,receipt.Appointment);
        }


    }
}
