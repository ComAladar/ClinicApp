using System;
using System.Collections.Generic;
using System.Threading;
using ClinicAppBusinessLogic.Enumerations;
using ClinicAppDataBase.Entities;
using NUnit.Framework;

namespace ClinicAppUnitTests
{
    [TestFixture]
    class StaffTests
    {
        private Staff CreateStaff()
        {
            var staff = new Staff();
            return staff;
        }

        [Test]
        public void Id_GetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            staff.Id = 1;
            var actualId = staff.Id;

            //Assert
            Assert.AreEqual(staff.Id, actualId);

        }

        [Test]
        public void Id_SetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            var expectedId = 1;
            staff.Id = expectedId;

            //Assert
            Assert.AreEqual(expectedId, staff.Id);
        }

        [Test]
        public void Name_GetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            staff.Name = "TestData";
            var actualName = staff.Name;

            //Assert
            Assert.AreEqual(staff.Name, actualName);
        }

        [Test]
        public void Name_SetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            var expectedName = "TestData";
            staff.Name = expectedName;

            //Assert
            Assert.AreEqual(expectedName, staff.Name);
        }

        [Test]
        public void Name_ThrowsArgumentException_TooLongValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            var input = "11111111111111111111111111" +
                        "111111111111111111111111111111111" +
                        "111111111111111111111111111111111" +
                        "111111111111111111111111111111111";
            //Assert
            Assert.Throws<ArgumentException>((() => { staff.Name = input; }));
        }

        [Test]
        public void Name_ThrowsArgumentException_EmptyString()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            var input = "";
            //Assert
            Assert.Throws<ArgumentException>((() => { staff.Name = input; }));
        }

        [Test]
        public void Surname_GetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            staff.Surname = "TestData";
            var actualSurname = staff.Surname;

            //Assert
            Assert.AreEqual(staff.Surname, actualSurname);
        }

        [Test]
        public void Surname_SetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            var expectedSurname = "TestData";
            staff.Surname = expectedSurname;

            //Assert
            Assert.AreEqual(expectedSurname, staff.Surname);
        }

        [Test]
        public void Surname_ThrowsArgumentException_TooLongValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            var input = "11111111111111111111111111" +
                        "111111111111111111111111111111111" +
                        "111111111111111111111111111111111" +
                        "111111111111111111111111111111111";
            //Assert
            Assert.Throws<ArgumentException>((() => { staff.Surname = input; }));
        }

        [Test]
        public void Surname_ThrowsArgumentException_EmptyString()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            var input = "";
            //Assert
            Assert.Throws<ArgumentException>((() => { staff.Surname = input; }));
        }

        [Test]
        public void Patronymic_GetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            staff.Patronymic = "TestData";
            var actualPatronymic = staff.Patronymic;

            //Assert
            Assert.AreEqual(staff.Patronymic, actualPatronymic);
        }

        [Test]
        public void Patronymic_SetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            var expectedPatronymic = "TestData";
            staff.Patronymic = expectedPatronymic;

            //Assert
            Assert.AreEqual(expectedPatronymic, staff.Patronymic);
        }

        [Test]
        public void Patronymic_ThrowsArgumentException_IncorrectValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            var input = "11111111111111111111111111" +
                        "111111111111111111111111111111111" +
                        "111111111111111111111111111111111" +
                        "111111111111111111111111111111111";
            //Assert
            Assert.Throws<ArgumentException>((() => { staff.Patronymic = input; }));
        }

        [Test]
        public void Sex_GetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            staff.Sex = SexType.Male;
            var actualSex = staff.Sex;

            //Assert
            Assert.AreEqual(staff.Sex, actualSex);
        }

        [Test]
        public void Sex_SetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            var expectedSex = SexType.Male;
            staff.Sex = expectedSex;

            //Assert
            Assert.AreEqual(expectedSex, staff.Sex);
        }

        [Test]
        public void DateOfBirth_GetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            staff.DateOfBirth = DateTime.Now.Date;
            var actualDate = staff.DateOfBirth;

            //Assert
            Assert.AreEqual(staff.DateOfBirth, actualDate);
        }

        [Test]
        public void DateOfBirth_SetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            var expectedDate = DateTime.Now.Date;
            staff.DateOfBirth = expectedDate;

            //Assert
            Assert.AreEqual(expectedDate, staff.DateOfBirth);
        }

        [Test]
        public void DateOfBirth_ThrowsArhumentException_IncorrectValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            var input = DateTime.Now;

            //Assert
            Assert.Throws<ArgumentException>(() => { staff.DateOfBirth = input; });
        }

        [Test]
        public void DateOfRegistration_GetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            staff.DateOfRegistration = DateTime.Now;
            var actualRegistration = staff.DateOfRegistration;

            //Assert
            Assert.AreEqual(staff.DateOfRegistration, actualRegistration);
        }

        [Test]
        public void DateOfRegistration_SetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            var expectedRegistration = DateTime.Now;
            staff.DateOfRegistration = expectedRegistration;

            //Assert
            Assert.AreEqual(expectedRegistration, staff.DateOfRegistration);
        }

        [Test]
        public void PhoneNumber_GetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            staff.PhoneNumber = "1111111111";
            var actualNumber = staff.PhoneNumber;

            //Assert
            Assert.AreEqual(staff.PhoneNumber, actualNumber);
        }

        [Test]
        public void PhoneNumber_SetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            var expectedNumber = "1111111111";
            staff.PhoneNumber = expectedNumber;

            //Assert
            Assert.AreEqual(expectedNumber, staff.PhoneNumber);
        }

        [Test]
        public void PhoneNumber_ThrowsArgumentException_IncorrectValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            var input = "423535";

            //Assert
            Assert.Throws<ArgumentException>((() => { staff.PhoneNumber = input; }));
        }

        [Test]
        public void Email_GetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            staff.Email = "mail@mail.ru";
            var actualMail = staff.Email;

            //Assert
            Assert.AreEqual(staff.Email, actualMail);
        }

        [Test]
        public void Email_SetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            var expectedMail = "mail@mail.ru";
            staff.Email = expectedMail;

            //Assert
            Assert.AreEqual(expectedMail, staff.Email);
        }

        [Test]
        public void Email_ThrowsArgumentException_IncorrectValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            var input = "TestDataFalse@false";

            //Assert
            Assert.Throws<ArgumentException>(() => { staff.Email = input; });
        }

        [Test]
        public void Access_GetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            staff.Access = AccessType.Doctor;
            var actualAccess = staff.Access;

            //Assert
            Assert.AreEqual(staff.Access,actualAccess);
        }

        [Test]
        public void Access_SetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            var expectedAccess = AccessType.Registry;
            staff.Access = expectedAccess;

            //Assert
            Assert.AreEqual(expectedAccess,staff.Access);
        }

        [Test]
        public void Qualification_GetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            staff.Qualification = "Test Data";
            var actualQualification = staff.Qualification;

            //Assert
            Assert.AreEqual(staff.Qualification, actualQualification);
        }

        [Test]
        public void Qualification_SetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            var expectedQualification = "Test Data";
            staff.Qualification = expectedQualification;

            //Assert
            Assert.AreEqual(expectedQualification, staff.Qualification);
        }

        [Test]
        public void Position_GetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            staff.Position = "Test Data";
            var actualPosition = staff.Position;

            //Assert
            Assert.AreEqual(staff.Position, actualPosition);
        }

        [Test]
        public void Position_SetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            var expectedPosition = "Test Data";
            staff.Position = expectedPosition;

            //Assert
            Assert.AreEqual(expectedPosition, staff.Position);
        }

        [Test]
        public void Specialty_GetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            staff.Speciality = "Test Data";
            var actualSpecialty = staff.Speciality;

            //Assert
            Assert.AreEqual(staff.Speciality, actualSpecialty);
        }

        [Test]
        public void Specialty_SetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            var expectedSpecialty = "Test Data";
            staff.Speciality = expectedSpecialty;

            //Assert
            Assert.AreEqual(expectedSpecialty, staff.Speciality);
        }

        [Test]
        public void DateOfEmployment_GetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            staff.DateOfEmployment = DateTime.Now;
            var actualDate = staff.DateOfEmployment;

            //Assert
            Assert.AreEqual(staff.DateOfEmployment, actualDate);
        }

        [Test]
        public void DateOfEmployment_SetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            var expectedDate = DateTime.Now;
            staff.DateOfEmployment = expectedDate;

            //Assert
            Assert.AreEqual(expectedDate, staff.DateOfEmployment);
        }

        [Test]
        public void InUse_GetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            staff.InUse = InUseType.InUse;
            var actualUse = staff.InUse;

            //Assert
            Assert.AreEqual(staff.InUse, actualUse);
        }

        [Test]
        public void InUse_SetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            var expectedInUse = InUseType.InUse;
            staff.InUse = expectedInUse;

            //Assert
            Assert.AreEqual(expectedInUse, staff.InUse);
        }

        [Test]
        public void Login_GetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            staff.Login = "TestLogin1";
            var actualLogin = staff.Login;

            //Assert
            Assert.AreEqual(staff.Login, actualLogin);
        }

        [Test]
        public void Login_SetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            var expectedLogin = "TestLogin1";
            staff.Login = expectedLogin;

            //Assert
            Assert.AreEqual(expectedLogin, staff.Login);
        }

        [Test]
        public void Login_ThrowsArgumentException_IncorrectValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            var input = "Tes";

            //Assert
            Assert.Throws<ArgumentException>(() => { staff.Login = input; });
        }

        [Test]
        public void Password_GetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            staff.Password = "Paswrd";
            var actualPassword = staff.Password;

            //Assert
            Assert.AreEqual(staff.Password, actualPassword);
        }

        [Test]
        public void Password_SetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            var expectedPassword = "Paswrd";
            staff.Password = expectedPassword;

            //Assert
            Assert.AreEqual(expectedPassword, staff.Password);
        }

        [Test]
        public void Password_ThrowsArgumentException_IncorrectValue()
        {
            //Setup
            var staff = CreateStaff();

            //Act
            var input = "Tes";

            //Assert
            Assert.Throws<ArgumentException>(() => { staff.Password = input; });
        }

        [Test]
        public void Receipts_GetSetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();
            ICollection<Receipt> tempCollection = new List<Receipt>();
            Receipt tempReceipt = new Receipt();
            tempCollection.Add(tempReceipt);

            //Act
            staff.Receipts = tempCollection;

            //Assert
            Assert.AreEqual(true,staff.Receipts.Contains(tempReceipt));
        }

        [Test]
        public void Appointments_GetSetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();
            ICollection<Appointment> tempCollection = new List<Appointment>();
            Appointment tempAppointment = new Appointment();
            tempCollection.Add(tempAppointment);

            //Act
            staff.Appointments = tempCollection;

            //Assert
            Assert.AreEqual(true,staff.Appointments.Contains(tempAppointment));
        }

        [Test]
        public void MessageBoard_GetSetCorrectValue_ReturnValue()
        {
            //Setup
            var staff = CreateStaff();
            ICollection<MessageBoard> tempCollection = new List<MessageBoard>();
            MessageBoard tempMessageBoard = new MessageBoard();
            tempCollection.Add(tempMessageBoard);
            //Act
            staff.MessageBoards = tempCollection;

            //Assert
            Assert.AreEqual(true,staff.MessageBoards.Contains(tempMessageBoard));
        }


    }
}
