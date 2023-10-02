using Microsoft.AspNetCore.Components.Forms;

namespace YaVDele.CalculatorGrant.Data
{

    //Загрузить файл в папку
    //Прочитать его содержимое
    //Десериализовать JSON
    //Работа с массивом, его вывод и т.д.

    public class FileUpload
    {
        public async Task LoadFiles(InputFileChangeEventArgs eventArgs) {  
            string mainDir = FileSystem.Current.AppDataDirectory;
            string fileName = eventArgs.File.Name;
            string currentFilePath = Path.Combine(mainDir, fileName);
        }

        public string mainDir()
        {
            string mainDir = FileSystem.Current.AppDataDirectory;
            return mainDir;
        }
    }
}
