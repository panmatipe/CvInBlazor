using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvViewerApp.Services.Models
{
    public class CvData
    {
        public string Name { get; set; } = "";
        public string Title { get; set; } = "";
        public ContactInfo Contact { get; set; } = new();
        public string Profile { get; set; } = "";
        public List<Experience> Experience { get; set; } = new();
        public List<string> Skills { get; set; } = new();
        public Dictionary<string, string> Languages { get; set; } = new();
        public string Consent { get; set; } = "";
    }
}
