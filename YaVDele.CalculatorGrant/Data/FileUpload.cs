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

            if (files.Count != 0)
            {
                foreach (var file in files)
                    {
                        string MainDir = FileSystem.Current.AppDataDirectory;
                        string uploadDir = Path.Combine(MainDir, "Uploads");   

                        CheckDirectoryForExistence(uploadDir);

                        string fileName = file.Name;
                        string currentFilePath = Path.Combine(uploadDir, fileName);

                        Stream stream = file.OpenReadStream();
                        FileStream fs = File.Create(currentFilePath);
                        await stream.CopyToAsync(fs);
                        stream.Close();
                        fs.Close();
                    }
            }
            
        }

        public string MainDirOut()
        {
            string MainDir = FileSystem.Current.AppDataDirectory;
            return MainDir;
        }

        public int fileCountInFoleder()
        {
            string uploadDir = Path.Combine(MainDirOut(), "Uploads");
            int filesInFolder = Directory.GetFiles(uploadDir).Length; 
            return filesInFolder;
        }

        private void CheckDirectoryForExistence(string directory)
        {
            if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
        }
    }
}
