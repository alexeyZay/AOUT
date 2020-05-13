using System;

namespace logAn
{
    public class LogAnalyzer
    {
        public bool IsFileNameValid (string fileName)
        {
            IFileExtentionManager mngr = new FileExtentionManager();
            
            return mngr.IsValid(fileName);
        }
    }
    public class FileExtentionManager : IFileExtentionManager
    {
        public bool IsValid(string fileName)
        {
            if (String.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException("No fileName provided");
            }
            if (!fileName.ToLower().EndsWith(".slf"))
            {
                return false;
            }
            return true;
        }
    }
    public interface IFileExtentionManager
    {
        bool IsValid(string fileName);
    }
}
