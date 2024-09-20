using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace task1._4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordapp = new Word.Application();
            wordapp.Visible = true;
            wordapp.WindowState = Word.WdWindowState.wdWindowStateNormal;

            Word.Document wordDoc = wordapp.Documents.Add();

            Word.Paragraph wordPara = wordDoc.Paragraphs.Add();
            wordPara.Range.Text = " \tProgramowanie pod Windows 2019\r\n";

            if(!wordapp.ActiveDocument.Saved)
                wordapp.ActiveDocument.SaveAs(@"C:\Users\user\Desktop\dotnet\ppw.docx");
            
            wordDoc.Close();
            wordapp.Quit();
           
        
        }
    }
}
