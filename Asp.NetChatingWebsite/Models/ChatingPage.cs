using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetChatingWebsite.Models
{
    public class ChatingPage
    {
        public int Id { get; set; }
        public DateTime SentOn { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
    }
}
