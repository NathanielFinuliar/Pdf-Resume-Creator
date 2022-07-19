using Newtonsoft.Json;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;
using System;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Pdf_Resume_Creator
{
    public partial class Form1 : Form
    {
        private readonly string _fileName = @"C:\Users\nathan\source\repos\Pdf-Resume-Creator\ResumeFile.json";
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

        private void CnvrtrLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
