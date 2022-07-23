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
            public string FullName { get; set; }
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
            public string HSkills22 { get; set; }
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
            public string Name { get; set; }
            public string UnderL { get; set; }
            public string Sopn { get; set; }
        }


        private void CnvrtrBttn_Click(object sender, EventArgs e)
        {
            string JsonFile;
            using (var reader = new StreamReader(PathName))
            {
                JsonFile = reader.ReadToEnd();
            }
            var JsonFileResume = JsonConvert.DeserializeObject<Resume>(JsonFile);

            string FullName = JsonFileResume.FullName;
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
            string CollegeCourse = JsonFileResume.CollegeCourse;

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
            string HSkills22 = JsonFileResume.HSkills22;
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
            string Name = JsonFileResume.Name;
            string UnderL = JsonFileResume.UnderL;
            string Sopn = JsonFileResume.Sopn;

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = @"C:\Users\nathan\Pdf Resume";
                saveFileDialog.FileName = FullName + ".pdf";
                saveFileDialog.Filter = "PDF|*.pdf";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PdfDocument pdf = new PdfDocument();
                    pdf.Info.Title = FullName + "_" + "Resume";
                    PdfPage page = pdf.AddPage();


                    XGraphics graph = XGraphics.FromPdfPage(page);

                    XFont namefont = new XFont("Modern Machine", 35, XFontStyle.Bold);
                    XFont titlefont = new XFont("Games", 22, XFontStyle.Regular);
                    XFont headersfont = new XFont ("Games", 16, XFontStyle.Regular);
                    XFont infofont = new XFont("Arial", 12, XFontStyle.Regular);
                    XFont datafont = new XFont("Arial", 10, XFontStyle.Regular);

                    XPen shadename = new XPen(XColors.DarkSeaGreen, 50);
                    XPen lineR = new XPen(XColors.SaddleBrown, 2);
                    XPen lineL = new XPen(XColors.SaddleBrown, 2); //margin



                    XPen pen = new XPen(XColors.DarkSeaGreen, 20);
                    XPen linerleft = new XPen(XColors.Brown, 1); ;
                    XPen linerright = new XPen(XColors.Brown, 1);

                    graph.DrawRoundedRectangle(XBrushes.AntiqueWhite, 0, 0, page.Width.Point, page.Height.Point, 30, 20);
                    //graph.DrawRoundedRectangle(XBrushes.MistyRose, 200, 50, page.Width.Point, page.Height.Point, 100, 100);
                    graph.DrawRectangle(pen, 0, 0, page.Width.Point, page.Height.Point);

                    int marginS = 425;//row movement higher value, right position

                    string jpg = @"C:\Users\nathan\Pdf Resume\ProfessionalPhoto.jpg";
                    XImage image = XImage.FromFile(jpg);
                    graph.DrawImage(image, marginS, 50, 130, 150);
                    //(2) width of the picture


                    int marginright1 = 400; //row movement higher value, nababawasan pakaliwa yung shade
                    int initialright1 = 200; //column movment higher value, bumababa

                                                                               //(1)taas baba  //(2) width from left to right //(3)kapal ng shade from taas to baba
                    graph.DrawRectangle(shadename, marginright1, initialright1 - 110, -600, 50);

                    int marginT = 25; //lowervalue, nasa kaliwa
                    int marginT1 = 200;

                    graph.DrawString(FullName, namefont, XBrushes.Black, new XRect(marginT, marginT1 - 120, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Current, titlefont, XBrushes.Black, new XRect(marginT, marginT1 -80, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    //int marginT3 = 470;
                    //int marginT4 = 200;

                    //graph.DrawString(Current, titlefont, XBrushes.Black, new XRect(marginT3, marginT4 - 90, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);




                    int marginL = 35; //width
                    int marginL1 = 200;//height 


                    graph.DrawString("EXPERTISE SKILLS", headersfont, XBrushes.Black, new XRect(marginL, marginL1 + 5, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawRectangle(lineL, marginL, marginL1 + 25, 190, 2);

                    graph.DrawString(HardSkills, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 30, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(HSkills1, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 45, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(HSkills2, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 60, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(HSkills22, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 75, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(HSkills3, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 90, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(HSkills4, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 105, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(HSkills5, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 120, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(HSkills6, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 135, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(HSkills7, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 150, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(HSkills8, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 165, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(SoftSkills, infofont, XBrushes.Black, new XRect(marginL, marginL1 +190, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(SSkills1, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 205, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(SSkills2, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 220, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(SSkills3, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 235, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(SSkills4, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 250, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(SSkills5, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 265, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(SSkills6, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 280, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    

                    graph.DrawString("CHARACTER REFERENCE", headersfont, XBrushes.Black, new XRect(marginL, marginL1 + 310, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawRectangle(lineL, marginL, marginL1 + 330, 200, 2);

                    graph.DrawString(CharRefName, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 335, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(CharRefJob, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 350, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(CharRefPlace1, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 365, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(CharRefPlace2, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 380, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(CharRefNo, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 395, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(CharRefEmail, infofont, XBrushes.Black, new XRect(marginL, marginL1 + 410, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(Certify1, datafont, XBrushes.Black, new XRect(marginL, marginL1 + 450, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Certify2, datafont, XBrushes.Black, new XRect(marginL, marginL1 + 460, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Certify3, datafont, XBrushes.Black, new XRect(marginL, marginL1 + 470, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(Name, datafont, XBrushes.Black, new XRect(marginL, marginL1 + 510, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(UnderL, datafont, XBrushes.Black, new XRect(marginL, marginL1 + 511, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Sopn, datafont, XBrushes.Black, new XRect(marginL, marginL1 + 523, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);


                    int marginV = +65; //margin from left


                    string png = @"C:\Users\nathan\Pdf Resume\signature.png";
                    XImage imahe = XImage.FromFile(png);
                    graph.DrawImage(imahe, marginV, 680, 65, 50);
                                                    //(1)vertical  //(2) width  //(height)

                    int marginR = 250;
                    int marginR1 = 200;

                    graph.DrawString("OBJECTIVES", headersfont, XBrushes.Black, new XRect(marginR, marginR1 + 5, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawRectangle(lineR, marginR, marginR1 + 25, 350, 2);

                    graph.DrawString(Objective, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 30, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Objective1, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 45, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Objective2, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 60, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Objective3, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 75, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Objective4, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 90, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Objective5, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 105, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(Objective6, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 120, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);


                    marginR1 = marginR1 + 130; //space between objectives to education

                    graph.DrawString("EDUCATION", headersfont, XBrushes.Black, new XRect(marginR, marginR1 + 5, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawRectangle(lineR, marginR, marginR1 + 25, 350, 2);

                    graph.DrawString(CollegeYear, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 30, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(CollegeSchool, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 45, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(CollegeCourse, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 60, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(SeniorYear, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 90, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(SeniorSchool, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 105, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(SeniorStrand, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 120, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(SeniorAward, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 135, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(SeniorAward1, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 150, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(HSYear, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 180, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(HighSchool, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 195, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(HSAward, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 210, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawString(ElemYear, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 240, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(ElemSchool, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 255, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(ElemAward1, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 270, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);


                    marginR1 = marginR1 + 295;

                    graph.DrawString("PERSONAL INFORMATION", headersfont, XBrushes.Black, new XRect(marginR, marginR1 + 5, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    graph.DrawRectangle(lineR, marginR, marginR1 + 25, 350, 2);

                    graph.DrawString(GitEmail, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 30, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(PersonalNo, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 45, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(PersonalEmail, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 60, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);
                    graph.DrawString(PersonalAddress, infofont, XBrushes.Black, new XRect(marginR, marginR1 + 75, page.Width.Point, page.Height.Point), XStringFormats.TopLeft);

                    pdf.Save(saveFileDialog.FileName);
                }
            }
            Environment.Exit(0);
        }
    }
}
