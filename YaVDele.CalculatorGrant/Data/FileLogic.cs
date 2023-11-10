using GemBox.Spreadsheet;
using Newtonsoft.Json.Linq;
using YaVDele.CalculatorGrant.Data.Objects;

namespace YaVDele.CalculatorGrant.Data
{
    public class FileLogic : FileUpload
    {
        public void FileDelete(FileObject file)
        {
            string pathToDelete = Path.Combine(file.FilePath, file.FileName);
            if (File.Exists(pathToDelete)) File.Delete(pathToDelete);
        }
        public void FileReadAsTable(FileObject file)    
        {
            string path = Path.Combine(file.FilePath, file.FileName);
            if (file.FileExtension == ".json")
            {
                //var jObject = DeserializeJSON(file);
                
                SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
                var workbook = new ExcelFile();
                var worksheet = workbook.Worksheets.Add(file.FileName);

                worksheet.Cells["A1"].Value = "solevaya bebra";

                workbook.Save(Path.Combine(file.FilePath, $"{file.FileName}.xlsx"));
            }
        }
        //public JObject DeserializeJSON(FileObject file)
        //{
        //    string json = File.ReadAllText(file.FullPath(file));

        //}
    }
}
