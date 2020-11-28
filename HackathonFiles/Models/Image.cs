using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackathonFiles.Models
{
    public class Image
    {
        public byte[] image { get; set; }
        public Guid id { get; set; } = Guid.NewGuid();
    }
}
