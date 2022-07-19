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

        }

        private void CnvrtrLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
