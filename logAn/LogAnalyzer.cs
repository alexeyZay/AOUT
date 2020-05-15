using System;

namespace logAn
{
    public class LogAnalyzer
    {
        #region Constractor injection
        //case with constructor injection
        //constructors
        public LogAnalyzer() { }
        public LogAnalyzer(IFileExtentionManager mgr)
        {
            manager = mgr;
        }

        IFileExtentionManager manager;
        public bool IsFileNameValid(string fileName)
        {
            return manager.IsValid(fileName);
        }
        #endregion
        #region method injection
        // method injection
        //public bool IsFileNameValid (string fileName)
        //{
        //    IFileExtentionManager mngr = new FileExtentionManager();

        //    return mngr.IsValid(fileName);
        //}
        #endregion
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
    public class StabFileExtentionManager : IFileExtentionManager
    {
        public bool IsValid (string fileName)
        {
            return true;
        }
    }
    public interface IFileExtentionManager
    {
        bool IsValid(string fileName);
    }
}
