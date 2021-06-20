using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using ClinicAppDataBase.Entities;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;

namespace ClinicAppTemplatesLogic
{
    /// <summary>
    /// Класс для построения шаблонов документов.
    /// </summary>
    public class TemplateBuilder
    {
        //Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + @"\ClinicAppTemplatesLogic\Templates";
        private static string FilepathToTemplates = Environment.CurrentDirectory + @"\Templates";
        /// </summary>
        /// <param name="appointment"></param>
        public void OpenAppointmentTemplate(Appointment appointment)
        {
            var filepath = FilepathToTemplates + @"\TemplateAppointment.docx";
            Document document = new Document(filepath);
            Section section = document.Sections[0];
            Paragraph paraAppointmentName = section.Paragraphs[2];
            Paragraph paraAppointmentNumber = section.Paragraphs[3];
            Paragraph paraPatientInfo = section.Paragraphs[5];
            Paragraph paraComplains = section.Paragraphs[8];
            Paragraph paraAnamnesis = section.Paragraphs[10];
            Paragraph paraCondition = section.Paragraphs[12];
            Paragraph paraDiagnosis = section.Paragraphs[14];
            Paragraph paraICD = section.Paragraphs[16];
            Paragraph paraMedicinialTherapy = section.Paragraphs[18];
            Paragraph paraRecommendation = section.Paragraphs[20];
            Paragraph paraDateOfAppointment = section.Paragraphs[21];
            Paragraph paraStaff = section.Paragraphs[23];

            paraAppointmentName.Text = appointment.AppointmentName;
            paraAppointmentNumber.AppendText(" " + appointment.Id);
            paraPatientInfo.AppendText(" " + appointment.Patient.Surname + " " + appointment.Patient.Name + " " +
                                       appointment.Patient.Patronymic);
            paraComplains.AppendText(appointment.Complains);
            paraAnamnesis.AppendText(appointment.Anamnesis);
            paraCondition.AppendText(appointment.Condition);
            paraDiagnosis.AppendText(appointment.Diagnosis);
            paraICD.AppendText(appointment.ICDCode);
            paraMedicinialTherapy.AppendText(appointment.MedicinalTherapy);
            paraRecommendation.AppendText(appointment.Recommendations);
            paraDateOfAppointment.AppendText(" " + appointment.DateOfSchedule.ToString());
            paraStaff.AppendText(" " + appointment.Staff.Surname
                                     + " " + appointment.Staff.Name.Substring(0, 1)
                                     + ". " + appointment.Staff.Patronymic.Substring(0, 1) + ".");
            try
            {
                document.SaveToFile("Прием.docx", FileFormat.Docx);
            }
            catch
            {

            }
            System.Diagnostics.Process.Start("Прием.docx");
        }

        public void OpenServiceFeesTemplate()
        {
            var filepath = FilepathToTemplates + @"\TemplateServiceFees.docx";
            Document document = new Document(filepath);
            try
            {
                document.SaveToFile("ОказаниеПлатныхУслуг.docx", FileFormat.Docx);
            }
            catch
            {

            }
            System.Diagnostics.Process.Start("ОказаниеПлатныхУслуг.docx");
        }

        public void OpenPersonalDataProcessingTemplate()
        {
            var filepath = FilepathToTemplates + @"\TemplatePersonalDataProcessing.docx";
            Document document = new Document(filepath);
            try
            {
                document.SaveToFile("ОбработкаПерсональныхДанных.docx", FileFormat.Docx);
            }
            catch
            {

            }
            System.Diagnostics.Process.Start("ОбработкаПерсональныхДанных.docx");
        }

        public void OpenMedicinalIntervationTemplate()
        {
            var filepath = FilepathToTemplates + @"\TemplateMedicalIntervention.docx";
            Document document = new Document(filepath);
            try
            {
                document.SaveToFile("МедицинскиеВмешательства.docx", FileFormat.Docx);
            }
            catch
            {

            }
            System.Diagnostics.Process.Start("МедицинскиеВмешательства.docx");
        }
    }
}
