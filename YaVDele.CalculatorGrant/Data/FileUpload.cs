﻿using Microsoft.AspNetCore.Components.Forms;
using YaVDele.CalculatorGrant.Data.Objects;

namespace YaVDele.CalculatorGrant.Data
{
    public class FileUpload
    {
        public async Task LoadFiles(IReadOnlyList<IBrowserFile> files) {

            if (files.Count != 0)
            {
                foreach (var file in files)
                {
                    string uploadDir = MainDirInit();   
                    CheckDirectoryForExistence(uploadDir);

                    string fileName = file.Name;
                    string currentFilePath = Path.Combine(uploadDir, fileName);

                    await FileStreamCreation(file, currentFilePath);
                }
            }
        }

        public async Task FileStreamCreation(IBrowserFile file, string currentFilePath)
        {
            Stream stream = file.OpenReadStream();
            FileStream fs = File.Create(currentFilePath);
            await stream.CopyToAsync(fs);
            stream.Close();
            fs.Close();
        }

        public string MainDirInit() => Path.Combine(FileSystem.Current.AppDataDirectory, "Uploads");

        public string MainDirOut() => FileSystem.Current.AppDataDirectory;

        public string FileCountInFoleder()
        {
            string uploadDir = MainDirInit();
            if (Directory.Exists(uploadDir))
            {
                int filesInFolder = Directory.GetFiles(uploadDir).Length;
                return $"{filesInFolder}";
            }
            return "Директории не существует";
        }

        public void CheckDirectoryForExistence(string directory) 
        {
            if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
        }

        public List<FileObject> GetFilesList()
        {
            string uploadDir = MainDirInit();
            var filesInFolder = Directory.EnumerateFiles(uploadDir);

            var fileObjectList = new List<FileObject>();

            foreach ( var file in filesInFolder)
            {
                fileObjectList.Add(new FileObject()
                {
                    FileName = Path.GetFileName(file),
                    FilePath = Path.GetDirectoryName(file)
                });
            }  
            
            return fileObjectList;
        }
    }
}
