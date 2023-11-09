using GemBox.Spreadsheet;
using Newtonsoft.Json;
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
                SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");

                ExcelFile excelFile = new ExcelFile();
                ExcelWorksheet worksheet = excelFile.Worksheets.Add(file.FileName);

                dynamic dyn = JsonConvert.DeserializeObject(File.ReadAllText(path));

                worksheet.CodeName = file.FileName;
                

            }
        }
    }
}
