using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ClinicAppDataBase.Entities;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
using Spire.Doc.Formatting;

namespace ClinicAppTemplatesLogic
{
    public class TemplateBuilder
    {
        public void OpenAppointmentTemplate(Appointment appointment)
        {
            //var filepath = System.AppDomain.CurrentDomain.BaseDirectory + @"\Templates\TemplateMain.docs";
            var filepath =
                @"C:\Users\Nikita\Source\Repos\ComAladar\ClinicApp\ClinicApp\ClinicAppTemplatesLogic\Templates\TemplateMain.docx";
            Document document = new Document(filepath);
            Section section = document.Sections[0];
            Paragraph paraAppointmentType = section.Paragraphs[0];
            Paragraph paraPatientInfo = section.Paragraphs[1];
            Paragraph paraComplains = section.Paragraphs[2];
            Paragraph paraAnamnesis = section.Paragraphs[3];
            Paragraph paraCondition = section.Paragraphs[4];
            Paragraph paraDiagnosis = section.Paragraphs[5];
            Paragraph paraICD = section.Paragraphs[6];
            Paragraph paraMedicinialTherapy = section.Paragraphs[7];
            Paragraph paraRecommendation = section.Paragraphs[8];
            paraAppointmentType.Text = appointment.AppointmentType.ToString();
            paraPatientInfo.AppendText(appointment.Patient.Surname + " " + appointment.Patient.Name + " " +
                                           appointment.Patient.Patronymic);
            paraComplains.AppendText(appointment.Complains);
            paraAnamnesis.AppendText(appointment.Anamnesis);
            paraCondition.AppendText(appointment.Condition);
            paraDiagnosis.AppendText(appointment.Diagnosis);
            paraICD.AppendText(appointment.ICDCode);
            paraMedicinialTherapy.AppendText(appointment.MedicinalTherapy);
            paraRecommendation.AppendText(appointment.Recommendations);
            document.SaveToFile("firsttext.docx",FileFormat.Docx);
            System.Diagnostics.Process.Start("firsttext.docx");
        }

        public void OpenPatientTemplate()
        {

        }

        //ДОБАВЛЕНИЕ НОВОГО ТЕКСТА\ПАРАГРАФА
        //Section sec = document.AddSection();
        //Paragraph par = sec.AddParagraph();
        //CharacterFormat format = new CharacterFormat(document);
        //format.FontName = "Calibri";
        //format.FontSize = 15;
        //format.Bold = true;
        //par.AppendText("TESTTEXTFROMPROG").ApplyCharacterFormat(format);

        //Если аппендом без отступов
        //Paragraph paraAppointmentType = section.Paragraphs[0];
        //Paragraph paraPatientInfo = section.Paragraphs[1];
        //Paragraph paraComplains = section.Paragraphs[2];
        //Paragraph paraAnamnesis = section.Paragraphs[3];
        //Paragraph paraCondition = section.Paragraphs[4];
        //Paragraph paraDiagnosis = section.Paragraphs[5];
        //Paragraph paraICD = section.Paragraphs[6];
        //Paragraph paraMedicinialTherapy = section.Paragraphs[7];
        //Paragraph paraRecommendation = section.Paragraphs[8];
        //paraAppointmentType.Text = appointment.AppointmentType.ToString();
        //paraPatientInfo.AppendText(appointment.Patient.Surname + " " + appointment.Patient.Name + " " +
        //                           appointment.Patient.Patronymic);
        //paraComplains.AppendText(appointment.Complains);
        //paraAnamnesis.AppendText(appointment.Anamnesis);
        //paraCondition.AppendText(appointment.Condition);
        //paraDiagnosis.AppendText(appointment.Diagnosis);
        //paraICD.AppendText(appointment.ICDCode);
        //paraMedicinialTherapy.AppendText(appointment.MedicinalTherapy);
        //paraRecommendation.AppendText(appointment.Recommendations);

        //Через замещение текста параграфа
        
        //Paragraph paraAppointmentType = section.Paragraphs[0];
        //Paragraph paraPatientInfo = section.Paragraphs[2];
        //Paragraph paraComplains = section.Paragraphs[3];
        //Paragraph paraAnamnesis = section.Paragraphs[4];
        //Paragraph paraCondition = section.Paragraphs[5];
        //Paragraph paraDiagnosis = section.Paragraphs[6];
        //Paragraph paraICD = section.Paragraphs[7];
        //Paragraph paraMedicinialTherapy = section.Paragraphs[8];
        //Paragraph paraRecommendation = section.AddParagraph();
        //paraAppointmentType.Text = appointment.AppointmentType.ToString();
        //paraPatientInfo.Text=(appointment.Patient.Surname + " " + appointment.Patient.Name + " " +
        //                           appointment.Patient.Patronymic);
        //paraComplains.Text=(appointment.Complains);
        //paraAnamnesis.Text=(appointment.Anamnesis);
        //paraCondition.Text=(appointment.Condition);
        //paraDiagnosis.Text=(appointment.Diagnosis);
        //paraICD.Text=(appointment.ICDCode);
        //paraMedicinialTherapy.Text=(appointment.MedicinalTherapy);
        //paraRecommendation.Text=(appointment.Recommendations);
    }
}
