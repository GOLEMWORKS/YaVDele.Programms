namespace YaVDele.CalculatorGrant.Data
{
    public class FolderVisualisation
    {
        public string[] FileNamesInFolder(string folderPath)
        {
            string[] files = new string[Directory.GetFiles(folderPath).Length];
            if(Directory.Exists(folderPath)) files = Directory.GetFiles(folderPath);
            return files;
        }

    }
}
