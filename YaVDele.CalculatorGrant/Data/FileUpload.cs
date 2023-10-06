using Microsoft.AspNetCore.Components.Forms;

namespace YaVDele.CalculatorGrant.Data
{

    //Загрузить файл в папку
    //Прочитать его содержимое
    //Десериализовать JSON
    //Работа с массивом, его вывод и т.д.

    public class FileUpload
    {
        public async Task LoadFiles(IReadOnlyList<IBrowserFile> files) {

            foreach (var file in files)
            {
                string mainDir = FileSystem.Current.AppDataDirectory;
                string fileName = file.Name;
                string currentFilePath = Path.Combine(mainDir, fileName);

                Stream stream = file.OpenReadStream();
                FileStream fs = File.Create(currentFilePath);
                await stream.CopyToAsync(fs);
                stream.Close();
                fs.Close();
            }
        }

        public string mainDir()
        {
            string mainDir = FileSystem.Current.AppDataDirectory;
            return mainDir;
        }
    }
}
