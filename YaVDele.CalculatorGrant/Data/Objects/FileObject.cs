namespace YaVDele.CalculatorGrant.Data.Objects
{
    public class FileObject
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FileExtension { get; set; }

        public string FullPath(FileObject fileObject)
        {
            string fullPath = Path.Combine(fileObject.FilePath, fileObject.FileName);
            return fullPath;
        }
    }
}
