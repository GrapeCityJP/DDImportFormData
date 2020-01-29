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

            // PDFを読み込み
            doc.Load(new FileStream("grapecity_order_template.pdf", FileMode.Open, FileAccess.Read));

            // FDFファイルからデータを入力
            //FileStream stream = new FileStream("FormData_FDF.fdf", FileMode.Open, FileAccess.Read);
            //doc.ImportFormDataFromFDF(stream);  

            // XFDFファイルからデータを入力
            FileStream stream = new FileStream("FormData_XFDF.xfdf", FileMode.Open, FileAccess.Read);
            doc.ImportFormDataFromXFDF(stream);

            // XMLファイルからデータを入力
            //FileStream stream = new FileStream("FormData_XML.xml", FileMode.Open, FileAccess.Read);
            //doc.ImportFormDataFromXML(stream);        

            // PDFを保存
            doc.Save("grapecity_order_embed.pdf");
        }
    }
}
