using Newtonsoft.Json;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;

namespace Pdf_Resume_Creator
{
    public partial class Form1 : Form
    {
        private readonly string PathName = @"C:\Users\nathan\source\repos\Pdf-Resume-Creator\ResumeFile.json";
        public Form1()
        {
            InitializeComponent();
        }

        public class Resume
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Current { get; set; }
            public string Objective { get; set; }
            public string Objective1 { get; set; }
            public string Objective2 { get; set; }
            public string Objective3 { get; set; }
            public string Objective4 { get; set; }
            public string Objective5 { get; set; }
            public string Objective6 { get; set; }
            public string CollegeYear { get; set; }
            public string CollegeSchool { get; set; }
            public string CollegeCourse { get; set; }
            public string SeniorYear { get; set; }
            public string SeniorSchool { get; set; }
            public string SeniorStrand { get; set; }
            public string SeniorAward { get; set; }
            public string SeniorAward1 { get; set; }
            public string HSYear { get; set; }
            public string HighSchool { get; set; }
            public string HSAward { get; set; }
            public string ElemYear { get; set; }
            public string ElemSchool { get; set; }
            public string ElemAward1 { get; set; }
            public string GitEmail { get; set; }
            public string PersonalNo { get; set; }
            public string PersonalEmail { get; set; }
            public string PersonalAddress { get; set; }
            public string HardSkills { get; set; }
            public string HSkills1 { get; set; }
            public string HSkills2 { get; set; }
            public string HSkills3 { get; set; }
            public string HSkills4 { get; set; }
            public string HSkills5 { get; set; }
            public string HSkills6 { get; set; }
            public string HSkills7 { get; set; }
            public string HSkills8 { get; set; }
            public string SoftSkills { get; set; }
            public string SSkills1 { get; set; }
            public string SSkills2 { get; set; }
            public string SSkills3 { get; set; }
            public string SSkills4 { get; set; }
            public string SSkills5 { get; set; }
            public string SSkills6 { get; set; }
            public string CharRefName { get; set; }
            public string CharRefJob { get; set; }
            public string CharRefPlace1 { get; set; }
            public string CharRefPlace2 { get; set; }
            public string CharRefNo { get; set; }
            public string CharRefEmail { get; set; }
            public string Certify1 { get; set; }
            public string Certify2 { get; set; }
            public string Certify3 { get; set; }
        }


        private void CnvrtrBttn_Click(object sender, EventArgs e)
        {
            string JsonFile;
            using (var reader = new StreamReader(PathName))
            {
                JsonFile = reader.ReadToEnd();
            }
            var JsonFileResume = JsonConvert.DeserializeObject<Resume>(JsonFile);

            string FirstName = JsonFileResume.FirstName;
            string LastName = JsonFileResume.LastName;
            string Current = JsonFileResume.Current;

            string Objective = JsonFileResume.Objective;
            string Objective1 = JsonFileResume.Objective1;
            string Objective2 = JsonFileResume.Objective2;
            string Objective3 = JsonFileResume.Objective3;
            string Objective4 = JsonFileResume.Objective4;
            string Objective5 = JsonFileResume.Objective5;
            string Objective6 = JsonFileResume.Objective6;

            string CollegeYear = JsonFileResume.CollegeYear;
            string CollegeSchool = JsonFileResume.CollegeSchool;

            string SeniorYear = JsonFileResume.SeniorYear;
            string SeniorSchool = JsonFileResume.SeniorSchool;
            string SeniorStrand = JsonFileResume.SeniorStrand;
            string SeniorAward = JsonFileResume.SeniorAward;
            string SeniorAward1 = JsonFileResume.SeniorAward1;

            string HSYear = JsonFileResume.HSYear;
            string HighSchool = JsonFileResume.HighSchool;
            string HSAward = JsonFileResume.HSAward;
            string ElemYear = JsonFileResume.ElemYear;
            string ElemSchool = JsonFileResume.ElemSchool;
            string ElemAward1 = JsonFileResume.ElemAward1;

            string GitEmail = JsonFileResume.GitEmail;
            string PersonalNo = JsonFileResume.PersonalNo;
            string PersonalEmail = JsonFileResume.PersonalEmail;
            string PersonalAddress = JsonFileResume.PersonalAddress;

            string HardSkills = JsonFileResume.HardSkills;
            string HSkills1 = JsonFileResume.HSkills1;
            string HSkills2 = JsonFileResume.HSkills2;
            string HSkills3 = JsonFileResume.HSkills3;
            string HSkills4 = JsonFileResume.HSkills4;
            string HSkills5 = JsonFileResume.HSkills5;
            string HSkills6 = JsonFileResume.HSkills6;
            string HSkills7 = JsonFileResume.HSkills7;
            string HSkills8 = JsonFileResume.HSkills8;

            string SoftSkills = JsonFileResume.SoftSkills;
            string SSkills1 = JsonFileResume.SSkills1;
            string SSkills2 = JsonFileResume.SSkills2;
            string SSkills3 = JsonFileResume.SSkills3;
            string SSkills4 = JsonFileResume.SSkills4;
            string SSkills5 = JsonFileResume.SSkills5;
            string SSkills6 = JsonFileResume.SSkills6;

            string CharRefName = JsonFileResume.CharRefName;
            string CharRefJob = JsonFileResume.CharRefJob;
            string CharRefPlace1 = JsonFileResume.CharRefPlace1;
            string CharRefPlace2 = JsonFileResume.CharRefPlace2;
            string CharRefNo = JsonFileResume.CharRefNo;
            string CharRefEmail = JsonFileResume.CharRefEmail;
            string Certify1 = JsonFileResume.Certify1;
            string Certify2 = JsonFileResume.Certify2;
            string Certify3 = JsonFileResume.Certify3;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = @"C:\Users\nathan\Pdf Resume";
                saveFileDialog.FileName = LastName + " " + FirstName + ".pdf";
                saveFileDialog.Filter = "PDF|*.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PdfDocument pdf = new PdfDocument();
                    pdf.Info.Title = LastName + "_" + "Resume";
                    PdfPage page = pdf.AddPage();


                    XGraphics graph = XGraphics.FromPdfPage(page);

                    XFont namefont = new XFont("Circular Std Bold", 30, XFontStyle.Bold);
                    XFont titlefont = new XFont("Circular Std Bold", 16, XFontStyle.Bold);
                    XFont infofont = new XFont("Arial", 12, XFontStyle.Regular);

                    XPen shadename = new XPen(XColors.NavajoWhite, 50);
                    XPen lineR = new XPen(XColors.Brown, 2);
                    XPen lineL = new XPen(XColors.Brown, 2);

                    pdf.Save(saveFileDialog.FileName);
                }
                MessageBox.Show("Your Json File is now converted to PDF!");
            }
            Environment.Exit(0);
        }
    }
}
