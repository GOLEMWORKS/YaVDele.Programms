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
                var allJsonData = DeserializeJSON(file);
                dynamic jsonSpecData = allJsonData[0];

                SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
                var workbook = new ExcelFile();
                var worksheet = workbook.Worksheets.Add(file.FileName);

                //worksheet.Cells.Value = jsonSpecData[0][1][0];

                workbook.Save(Path.Combine(file.FilePath, $"{file.FileName}.xlsx"));
            }
        }
        public dynamic DeserializeJSON(FileObject file)
        {
            dynamic objInfo = JArray.Parse(File.ReadAllText(file.FullPath(file)));
            return objInfo;
        }
    }
}
