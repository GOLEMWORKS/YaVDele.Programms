namespace YaVDele.CalculatorGrant.Data
{
    public class FolderVisualisation
    {
        public IEnumerable<string> FileNamesInFolder(string folderPath)
        {
            IEnumerable<string> files;
            if(Directory.Exists(folderPath)) return files = Directory.GetFiles(folderPath).Select(x=> Path.GetFileName(x));
            return null;
        }

    }
}
