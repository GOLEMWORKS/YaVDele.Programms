using Microsoft.AspNetCore.Components.Forms;

namespace YaVDele.CalculatorGrant.Data
{

    //Загрузить файл в папку
    //Прочитать его содержимое
    //Десериализовать JSON
    //Работа с массивом, его вывод и т.д.

    public class FileUpload
    {
        private long maxFileSize = 1024 * 1024 * 1;
        private int maxAllowedFiles = 3; 
        string rootpath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Uploads"); //берёт неверную директорию
        string currentTimestamp = DateTime.Now.ToString("h-mm-s");
        public async Task LoadFiles(InputFileChangeEventArgs e)
        {
                foreach (var file in e.GetMultipleFiles(maxAllowedFiles))
                {
                    try
                    {
                        string newFileName = Path.ChangeExtension(
                            Path.GetFileNameWithoutExtension(file.Name) + currentTimestamp,
                            Path.GetExtension(file.Name));

                        switch (Path.GetExtension(file.Name))
                        {
                            case ("json"):
                                string Jpath = JSONuploaded(newFileName);
                                FileStream fsJ = new(Jpath, FileMode.Create);
                                await file.OpenReadStream(maxFileSize).CopyToAsync(fsJ);
                            break;

                            default:
                                string Opath = OtherUploaded(newFileName);
                                FileStream fsO = new(Opath, FileMode.Create);
                                await file.OpenReadStream(maxFileSize).CopyToAsync(fsO);
                            break;
                        }
                    }
                        catch (Exception)
                        {
                            Console.WriteLine("Жопа");
                        }
                }
        }

        private string JSONuploaded(string fileName)
        {
            string path = Path.Combine(
                    rootpath,
                    "\\JSONs",
                    fileName);
            return path;
        }

        private string OtherUploaded(string fileName)
        {
            string path = Path.Combine(
                    rootpath,
                    "Other",
                    fileName);
            return path;
        }
    }
}
