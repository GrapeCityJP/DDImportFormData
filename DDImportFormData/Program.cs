using GrapeCity.Documents.Pdf;
using System;
using System.IO;

namespace DDImportFormData
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DioDocs for PDF. PDF Form Data Import!");

            var doc = new GcPdfDocument();

            // Load the document
            doc.Load(new FileStream("grapecity_order_template.pdf", FileMode.Open, FileAccess.Read));

            // FDF
            // Open the FDF file
            //FileStream stream = new FileStream("FormData_FDF.fdf", FileMode.Open, FileAccess.Read);
            // Import the form data
            //doc.ImportFormDataFromFDF(stream);  

            // XFDF
            // Open the XFDF file
            FileStream stream = new FileStream("FormData_XFDF.xfdf", FileMode.Open, FileAccess.Read);
            // Import the form data 
            doc.ImportFormDataFromXFDF(stream);       

            // XML
            //Open the XML file
            //FileStream stream = new FileStream("FormData_XML.xml", FileMode.Open, FileAccess.Read);
            //Import the form data
            //doc.ImportFormDataFromXML(stream);        

            doc.Save("grapecity_order_embed.pdf"); //Save the document
        }
    }
}
