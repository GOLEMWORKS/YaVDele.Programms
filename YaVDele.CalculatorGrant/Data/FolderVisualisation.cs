namespace YaVDele.CalculatorGrant.Data
{
    public class FolderVisualisation
    {
        public string FolderPath { get; set; }
        public string FolderName { get; set; } 
        FolderVisualisation(string folderPath, string folderName)
        {
            FolderPath = folderPath;
            FolderName = folderName;
        }

        public string[] FileNamesInFolder(string folderPath)
        {
            string[] files = new string[Directory.GetFiles(folderPath).Length];
            if(Directory.Exists(folderPath)) files = Directory.GetFiles(folderPath);
            return files;
        }
    }
}
