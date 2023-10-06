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
                string uploadDir = Path.Combine(mainDir, "Uploads");   

                if (!Directory.Exists(uploadDir))
                {
                    //создать папку uploads
                    Directory.CreateDirectory(uploadDir);
                }

                string fileName = file.Name;
                string currentFilePath = Path.Combine(uploadDir, fileName);

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

        public int fileCountInFoleder()
        {
            string uploadDir = Path.Combine(mainDir(), "Uploads");
            int filesInFolder = Directory.GetFiles(uploadDir).Length; 
            return filesInFolder;
        }
    }
}
