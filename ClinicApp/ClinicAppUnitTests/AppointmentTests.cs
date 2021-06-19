using System;
using System.Threading;
using ClinicAppBusinessLogic.Enumerations;
using ClinicAppDataBase.Entities;
using NUnit.Framework;

namespace ClinicAppUnitTests
{
    [TestFixture]
    public class AppointmentTests
    {
        private Appointment CreateAppointment()
        {
            var appointment = new Appointment();
            return appointment;
        }

        [Test]
        public void Id_GetCorrectValue_ReturnValue()
        {
            //Setup
            var appointment = CreateAppointment();

            //Act
            appointment.Id = 1;
            var actualId = appointment.Id;

            //Assert
            Assert.AreEqual(appointment.Id,actualId);

        }

        [Test]
        public void Id_SetCorrectValue_ReturnValue()
        {
            //Setup
            var appointment = CreateAppointment();

            //Act
            var expectedId = 1;
            appointment.Id = expectedId;

            //Assert
            Assert.AreEqual(expectedId,appointment.Id);



        }

        [Test]
        public void AppointmentName_GetCorrectValue_ReturnValue()
        {
            //Setup
            var appointment = CreateAppointment();

            //Act
            appointment.AppointmentName = "Test Data";
            var actualName = appointment.AppointmentName;

            //Assert
            Assert.AreEqual(appointment.AppointmentName,actualName);

        }

        [Test]
        public void AppointmentName_SetCorrectValue_ReturnValue()
        {
            //Setup
            var appointment = CreateAppointment();

            //Act
            var expectedName = "Test Data";
            appointment.AppointmentName = expectedName;

            //Assert
            Assert.AreEqual(expectedName,appointment.AppointmentName);

        }

        [Test]
        public void AppointmentType_GetCorrectValue_ReturnValue()
        {
            //Setup
            var appointment = CreateAppointment();

            //Act
            appointment.AppointmentType = AppointmentType.Second;
            var actualType = appointment.AppointmentType;

            //Assert
            Assert.AreEqual(appointment.AppointmentType,actualType);

        }

        [Test]
        public void AppointmentType_SetCorrectValue_ReturnValue()
        {
            //Setup
            var appointment = CreateAppointment();

            //Act
            var expectedType = AppointmentType.Second;
            appointment.AppointmentType = expectedType;

            //Assert
            Assert.AreEqual(expectedType,appointment.AppointmentType);
        }

        [Test]
        public void Complains_GetCorrectValue_ReturnValue()
        {
            //Setup
            var appointment = CreateAppointment();

            //Act
            appointment.Complains = "Test Data";
            var actualComplains = appointment.Complains;

            //Assert
            Assert.AreEqual(appointment.Complains,actualComplains);

        }

        [Test]
        public void Complains_SetCorrectValue_ReturnValue()
        {
            //Setup
            var appointment = CreateAppointment();

            //Act
            var expectedComplains = "Test Data";
            appointment.Complains = expectedComplains;

            //Assert
            Assert.AreEqual(expectedComplains,appointment.Complains);

        }

        [Test]
        public void Anamnesis_GetCorrectValue_ReturnValue()
        {
            //Setup
            var appointment = CreateAppointment();

            //Act
            appointment.Anamnesis = "Test Data";
            var actualAnamnesis = appointment.Anamnesis;

            //Assert
            Assert.AreEqual(appointment.Anamnesis,actualAnamnesis);

        }

        [Test]
        public void Anamnesis_SetCorrectValue_ReturnValue()
        {
            //Setup
            var appointment = CreateAppointment();

            //Act
            var expectedAnamnesis = "Test Data";
            appointment.Anamnesis = expectedAnamnesis;

            //Assert
            Assert.AreEqual(expectedAnamnesis,appointment.Anamnesis);


        }

        [Test]
        public void Condition_GetCorrectValue_ReturnValue()
        {
            //Setup
            var appointment = CreateAppointment();

            //Act
            appointment.Condition = "Test Data";
            var actualCondition = appointment.Condition;

            //Assert
            Assert.AreEqual(appointment.Condition,actualCondition);

        }

        [Test]
        public void Condition_SetCorrectValue_ReturnValue()
        {
            //Setup
            var appointment = CreateAppointment();

            //Act
            var expectedCondition = "Test Data";
            appointment.Condition = expectedCondition;

            //Assert
            Assert.AreEqual(expectedCondition,appointment.Condition);

        }

        [Test]
        public void Diagnosis_GetCorrectValue_ReturnValue()
        {
            //Setup
            var appointment = CreateAppointment();

            //Act
            appointment.Diagnosis = "Test Data";
            var actualDiagnosis = appointment.Diagnosis;

            //Assert
            Assert.AreEqual(appointment.Diagnosis,actualDiagnosis);

        }

        [Test]
        public void Diagnosis_SetCorrectValue_ReturnValue()
        {
            //Setup
            var appointment = CreateAppointment();

            //Act
            var expectedDiagnosis = "Test Data";
            appointment.Diagnosis = expectedDiagnosis;

            //Assert
            Assert.AreEqual(expectedDiagnosis,appointment.Diagnosis);
        }

        [Test]
        public void ICDCode_GetCorrectValue_ReturnValue()
        {
            //Setup
            var appointment = CreateAppointment();

            //Act
            appointment.ICDCode = "Test Data";
            var actualICDCode = appointment.ICDCode;

            //Assert
            Assert.AreEqual(appointment.ICDCode,actualICDCode);

        }

        [Test]
        public void ICD_SetCorrectValue_ReturnValue()
        {
            //Setup
            var appointment = CreateAppointment();

            //Act
            var expectedICDCode = "Test Data";
            appointment.ICDCode = expectedICDCode;

            //Assert
            Assert.AreEqual(expectedICDCode,appointment.ICDCode);


        }

        [Test]
        public void Recommendations_GetCorrectValue_ReturnValue()
        {
            //Setup
            var appointment = CreateAppointment();

            //Act
            appointment.Recommendations = "Test Data";
            var actualRecommendations = appointment.Recommendations;

            //Assert
            Assert.AreEqual(appointment.Recommendations,actualRecommendations);

        }

        [Test]
        public void Recommendations_SetCorrectValue_ReturnValue()
        {
            //Setup
            var appointment = CreateAppointment();

            //Act
            var exptectedRecommendations = "Test Data";
            appointment.Recommendations = exptectedRecommendations;

            //Assert
            Assert.AreEqual(exptectedRecommendations,appointment.Recommendations);


        }

        [Test]
        public void MedicinalTherapy_GetCorrectValue_ReturnValue()
        {
            //Setup
            var appointment = CreateAppointment();

            //Act
            appointment.MedicinalTherapy = "Test Data";
            var actualTherapy = appointment.MedicinalTherapy;

            //Assert
            Assert.AreEqual(appointment.MedicinalTherapy,actualTherapy);

        }

        [Test]
        public void MedicinalTherapy_SetCorrectValue_ReturnValue()
        {
            //Setup
            var appointment = CreateAppointment();

            //Act
            var expectedTherapy = "Test Data";
            appointment.MedicinalTherapy = expectedTherapy;

            //Assert
            Assert.AreEqual(expectedTherapy,appointment.MedicinalTherapy);
        }

        [Test]
        public void DateOfSchedule_GetCorrectValue_ReturnValue()
        {
            //Setup
            var appointment = CreateAppointment();

            //Act
            appointment.DateOfSchedule=DateTime.Now;
            var actualDateOfSchedule = appointment.DateOfSchedule;


            //Assert
            Assert.AreEqual(appointment.DateOfSchedule,actualDateOfSchedule);

        }

        [Test]
        public void DateOfSchedule_SetCorrectValue_ReturnValue()
        {
            //Setup
            var appointment = CreateAppointment();

            //Act
            var expectedDateOfSchedule = DateTime.Now;
            appointment.DateOfSchedule = expectedDateOfSchedule;


            //Assert
            Assert.AreEqual(expectedDateOfSchedule, appointment.DateOfSchedule);
        }

        [Test]
        public void IsComplete_GetCorrectValue_ReturnValue()
        {
            //Setup
            var appointment = CreateAppointment();

            //Act
            appointment.IsComplete = ComplitionType.Closed;
            var actualStatus = appointment.IsComplete;

            //Assert
            Assert.AreEqual(appointment.IsComplete,actualStatus);

        }

        [Test]
        public void IsComplete_SetCorrectValue_ReturnValue()
        {
            //Setup
            var appointment = CreateAppointment();

            //Act
            var expectedStatus = ComplitionType.Closed;
            appointment.IsComplete = expectedStatus;

            //Assert
            Assert.AreEqual(expectedStatus,appointment.IsComplete);

        }

        [Test]
        public void Patient_GetSetCorrectValue_ReturnValue()
        {
            //Setup
            var appointment = CreateAppointment();
            Patient tempPatient = new Patient();
            tempPatient.Id = 5;

            //Act
            appointment.Patient = tempPatient;
            appointment.PatientId = tempPatient.Id;
            tempPatient.Id = (int)appointment.PatientId;

            //Assert
            Assert.AreEqual(tempPatient,appointment.Patient);
        }

        [Test]
        public void Staff_GetSetCorrectValue_ReturnValue()
        {
            //Setup
            var appointment = CreateAppointment();
            Staff tempStaff = new Staff();
            tempStaff.Id = 5;

            //Act
            appointment.Staff = tempStaff;
            appointment.StaffId = tempStaff.Id;
            tempStaff.Id = (int)appointment.StaffId;

            //Assert
            Assert.AreEqual(tempStaff, appointment.Staff);
        }

        [Test]
        public void Receipt_GetSetCorrectValue_ReturnValue()
        {
            //Setup
            var appointment = CreateAppointment();
            Receipt tempReceipt = new Receipt();
            tempReceipt.Id = 5;

            //Act
            appointment.Receipt = tempReceipt;

            //Assert
            Assert.AreEqual(tempReceipt, appointment.Receipt);
        }

    }
}
