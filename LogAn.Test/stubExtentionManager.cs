using logAn;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogAn.Test
{
    class stubExtentionManager:IFileExtentionManager
    {
        public bool ShouldExtensionBeValid;
        public bool IsValid(string FileName)
        {
            return ShouldExtensionBeValid;
        }
    }
}
