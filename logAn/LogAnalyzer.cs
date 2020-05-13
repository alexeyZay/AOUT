using System;

namespace logAn
{
    public class LogAnalyzer
    {
        public bool IsFileNameValid (string fileName)
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
}
