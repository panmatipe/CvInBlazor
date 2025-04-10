using CvViewerApp.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvViewerApp.Services.Api
{
    public interface ICvService
    {
        Task<CvData> GetCvDataAsync();
    }
}
