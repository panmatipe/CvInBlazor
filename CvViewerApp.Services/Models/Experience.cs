using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvViewerApp.Services.Models
{
    public class Experience
    {
        public string Position { get; set; } = "";
        public string Company { get; set; } = "";
        public string Location { get; set; } = "";
        public string StartDate { get; set; } = "";
        public string EndDate { get; set; } = "";
        public string Description { get; set; } = "";
        public List<string> Responsibilities { get; set; } = new();
    }
}
