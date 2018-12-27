using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace DependencyInjection
{
    public class PdfFileService : IFileService
    {
        public void print()
        {
            PdfReader reader = new PdfReader(@"C:\Users\prdesh\source\repos\DependencyInjection\DependencyInjection\sample.pdf");
            string text = string.Empty;
            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                text += PdfTextExtractor.GetTextFromPage(reader, page);
            }
            reader.Close();

            System.Console.WriteLine(text);
        }
    }
}
