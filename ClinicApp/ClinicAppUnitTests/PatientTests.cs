using System;
using System.Collections.Generic;
using System.Threading;
using ClinicAppBusinessLogic.Enumerations;
using ClinicAppDataBase.Entities;
using NUnit.Framework;

namespace ClinicAppUnitTests
{
    [TestFixture]
    class PatientTests
    {
        private Patient CreatePatient()
        {
            var patient = new Patient();
            return patient;
        }

        [Test]
        public void Id_GetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            patient.Id = 1;
            var actualId = patient.Id;

            //Assert
            Assert.AreEqual(patient.Id, actualId);

        }

        [Test]
        public void Id_SetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            var expectedId = 1;
            patient.Id = expectedId;

            //Assert
            Assert.AreEqual(expectedId, patient.Id);
        }

        [Test]
        public void Name_GetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            patient.Name = "TestData";
            var actualName = patient.Name;

            //Assert
            Assert.AreEqual(patient.Name,actualName);
        }

        [Test]
        public void Name_SetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            var expectedName = "TestData";
            patient.Name = expectedName;

            //Assert
            Assert.AreEqual(expectedName,patient.Name);
        }

        [Test]
        public void Name_ThrowsArgumentException_TooLongValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            var input = "11111111111111111111111111" +
                        "111111111111111111111111111111111" +
                        "111111111111111111111111111111111" +
                        "111111111111111111111111111111111";
            //Assert
            Assert.Throws<ArgumentException>((() => { patient.Name = input; }));
        }

        [Test]
        public void Name_ThrowsArgumentException_EmptyString()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            var input = "";
            //Assert
            Assert.Throws<ArgumentException>((() => { patient.Name = input; }));
        }

        [Test]
        public void Surname_GetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            patient.Surname = "TestData";
            var actualSurname = patient.Surname;

            //Assert
            Assert.AreEqual(patient.Surname, actualSurname);
        }

        [Test]
        public void Surname_SetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            var expectedSurname = "TestData";
            patient.Surname = expectedSurname;

            //Assert
            Assert.AreEqual(expectedSurname, patient.Surname);
        }

        [Test]
        public void Surname_ThrowsArgumentException_TooLongValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            var input = "11111111111111111111111111" +
                        "111111111111111111111111111111111" +
                        "111111111111111111111111111111111" +
                        "111111111111111111111111111111111";
            //Assert
            Assert.Throws<ArgumentException>((() => { patient.Surname = input; }));
        }

        [Test]
        public void Surname_ThrowsArgumentException_EmptyString()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            var input = "";
            //Assert
            Assert.Throws<ArgumentException>((() => { patient.Surname = input; }));
        }

        [Test]
        public void Patronymic_GetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            patient.Patronymic = "TestData";
            var actualPatronymic = patient.Patronymic;

            //Assert
            Assert.AreEqual(patient.Patronymic, actualPatronymic);
        }

        [Test]
        public void Patronymic_SetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            var expectedPatronymic = "TestData";
            patient.Patronymic = expectedPatronymic;

            //Assert
            Assert.AreEqual(expectedPatronymic, patient.Patronymic);
        }

        [Test]
        public void Patronymic_ThrowsArgumentException_IncorrectValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            var input = "11111111111111111111111111" +
                        "111111111111111111111111111111111" +
                        "111111111111111111111111111111111" +
                        "111111111111111111111111111111111";
            //Assert
            Assert.Throws<ArgumentException>((() => { patient.Patronymic = input; }));
        }

        [Test]
        public void Sex_GetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            patient.Sex = SexType.Male;
            var actualSex = patient.Sex;

            //Assert
            Assert.AreEqual(patient.Sex,actualSex);
        }

        [Test]
        public void Sex_SetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            var expectedSex = SexType.Male;
            patient.Sex = expectedSex;

            //Assert
            Assert.AreEqual(expectedSex,patient.Sex);
        }

        [Test]
        public void DateOfBirth_GetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            patient.DateOfBirth=DateTime.Now.Date;
            var actualDate = patient.DateOfBirth;

            //Assert
            Assert.AreEqual(patient.DateOfBirth,actualDate);
        }

        [Test]
        public void DateOfBirth_SetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            var expectedDate = DateTime.Now.Date;
            patient.DateOfBirth = expectedDate;

            //Assert
            Assert.AreEqual(expectedDate,patient.DateOfBirth);
        }

        [Test]
        public void DateOfBirth_ThrowsArhumentException_IncorrectValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            var input = DateTime.Now;

            //Assert
            Assert.Throws<ArgumentException>(() => { patient.DateOfBirth = input; });
        }

        [Test]
        public void DateOfRegistration_GetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            patient.DateOfRegistration=DateTime.Now;
            var actualRegistration = patient.DateOfRegistration;

            //Assert
            Assert.AreEqual(patient.DateOfRegistration,actualRegistration);
        }

        [Test]
        public void DateOfRegistration_SetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            var expectedRegistration = DateTime.Now;
            patient.DateOfRegistration = expectedRegistration;

            //Assert
            Assert.AreEqual(expectedRegistration,patient.DateOfRegistration);
        }

        [Test]
        public void City_GetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            patient.City = "Test Data";
            var actualCity = patient.City;

            //Assert
            Assert.AreEqual(patient.City,actualCity);
        }

        [Test]
        public void City_SetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            var expectedCity = "Test Data";
            patient.City = expectedCity;

            //Assert
            Assert.AreEqual(expectedCity,patient.City);
        }

        [Test]
        public void Street_GetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            patient.Street = "Test Data";
            var actualStreet = patient.Street;

            //Assert
            Assert.AreEqual(patient.Street, actualStreet);
        }

        [Test]
        public void Street_SetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            var expectedStreet = "Test Data";
            patient.Street = expectedStreet;

            //Assert
            Assert.AreEqual(expectedStreet, patient.Street);
        }

        [Test]
        public void House_GetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            patient.House = "Test Data";
            var actualHouse = patient.House;

            //Assert
            Assert.AreEqual(patient.House, actualHouse);
        }

        [Test]
        public void House_SetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            var expectedHouse = "Test Data";
            patient.House = expectedHouse;

            //Assert
            Assert.AreEqual(expectedHouse, patient.House);
        }

        [Test]
        public void Flat_GetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            patient.Flat = "Test Data";
            var actualFlat = patient.Flat;

            //Assert
            Assert.AreEqual(patient.Flat, actualFlat);
        }

        [Test]
        public void Flat_SetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            var expectedFlat = "Test Data";
            patient.Flat = expectedFlat;

            //Assert
            Assert.AreEqual(expectedFlat, patient.Flat);
        }

        [Test]
        public void Porch_GetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            patient.Porch = "Test Data";
            var actualPorch = patient.Porch;

            //Assert
            Assert.AreEqual(patient.Porch, actualPorch);
        }

        [Test]
        public void Porch_SetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            var expectedPorch = "Test Data";
            patient.Porch = expectedPorch;

            //Assert
            Assert.AreEqual(expectedPorch, patient.Porch);
        }

        [Test]
        public void PhoneNumber_GetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            patient.PhoneNumber = "1111111111";
            var actualNumber = patient.PhoneNumber;

            //Assert
            Assert.AreEqual(patient.PhoneNumber,actualNumber);
        }

        [Test]
        public void PhoneNumber_SetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            var expectedNumber = "1111111111";
            patient.PhoneNumber = expectedNumber;

            //Assert
            Assert.AreEqual(expectedNumber,patient.PhoneNumber);
        }

        [Test]
        public void PhoneNumber_ThrowsArgumentException_IncorrectValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            var input = "423535";

            //Assert
            Assert.Throws<ArgumentException>((() => { patient.PhoneNumber = input; }));
        }

        [Test]
        public void Email_GetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            patient.Email = "mail@mail.ru";
            var actualMail = patient.Email;

            //Assert
            Assert.AreEqual(patient.Email,actualMail);
        }

        [Test]
        public void Email_SetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            var expectedMail = "mail@mail.ru";
            patient.Email = expectedMail;

            //Assert
            Assert.AreEqual(expectedMail,patient.Email);
        }

        [Test]
        public void Email_ThrowsArgumentException_IncorrectValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            var input = "TestDataFalse@false";

            //Assert
            Assert.Throws<ArgumentException>(() => { patient.Email = input; });
        }

        [Test]
        public void MiscInformation_GetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            patient.MiscInformation = "Test Data";
            var actualInfo = patient.MiscInformation;

            //Assert
            Assert.AreEqual(patient.MiscInformation,actualInfo);
        }

        [Test]
        public void MiscInformation_SetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            var expectedInfo = "Test Data";
            patient.MiscInformation = expectedInfo;

            //Assert
            Assert.AreEqual(expectedInfo,patient.MiscInformation);
        }

        [Test]
        public void InUse_GetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            patient.InUse = InUseType.InUse;
            var actualUse = patient.InUse;

            //Assert
            Assert.AreEqual(patient.InUse,actualUse);
        }

        [Test]
        public void InUse_SetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();

            //Act
            var expectedInUse = InUseType.InUse;
            patient.InUse = expectedInUse;

            //Assert
            Assert.AreEqual(expectedInUse,patient.InUse);
        }

        [Test]
        public void Appointments_GetSetCorrectValue_ReturnValue()
        {
            //Setup
            var patient = CreatePatient();
            ICollection<Appointment> tempCollection = new List<Appointment>();
            Appointment tempAppointment = new Appointment();
            tempCollection.Add(tempAppointment);

            //Act
            patient.Appointments = tempCollection;


            //Assert
            Assert.AreEqual(true,patient.Appointments.Contains(tempAppointment));
        }

    }
}
