using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackathonFiles.Models
{
    public class Url
    {
        public string []uris { get; set; }
        public Guid id { get; set; } = Guid.NewGuid();
    }
}
