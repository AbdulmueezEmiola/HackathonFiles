using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HackathonFiles.Servics
{
    public static class ExtensionMethods
    {
        public static Stream ReadAllBytes(this Stream instream)
        {
            if (instream is MemoryStream)
                return ((MemoryStream)instream);
            using (var memoryStream = new MemoryStream())
            {
                instream.Position = 0;
                instream.CopyTo(memoryStream);
                return memoryStream;
            }
        }
    }
}
