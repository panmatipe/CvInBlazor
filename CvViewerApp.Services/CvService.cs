using CvViewerApp.Services.Api;
using CvViewerApp.Services.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CvViewerApp.Services
{
    public class CvService : ICvService
    {
        public async Task<CvData> GetCvDataAsync()
        {
            var cvResult = new CvData();
            try
            {
                // Simulate an asynchronous operation
                var result = await Task.FromResult(GetMockedCv());
                cvResult = JsonConvert.DeserializeObject<CvData>(result);
            }
            catch (JsonException ex)
            {
                // TODO: Handle JSON deserialization errors
                Console.WriteLine($"JSON Deserialization Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                // TODO: Handle other potential errors
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return cvResult;
        }

        private string GetMockedCv()
        {
            return @"
                {
                  ""name"": ""Bill Gates"",
                  ""title"": "".Net Developer"",
                  ""contact"": {
                    ""location"": ""Seattle / Remote"",
                    ""phone"": ""917 719 179"",
                    ""email"": ""bill.gates@microsoft.com"",
                    ""linkedin"": ""https://www.linkedin.com/in/williamhgates/""
                  },
                  ""profile"": ""I am a software developer with 26 years of experience in the .NET platform and JavaScript frameworks such as Vue and Angular. As a member of multinational teams, I follow best practices and I use Git for version control. Enthusiastic about new technologies, I am eager to learn and apply innovative solutions to software development challenges."",
                  ""experience"": [
                    {
                      ""position"": "".NET Developer"",
                      ""company"": ""CDI - Conseils et Développements Informatiques SA"",
                      ""location"": ""Remote"",
                      ""startDate"": ""December 2021"",
                      ""endDate"": ""March 2025"",
                      ""description"": ""Maintained and enhanced a web platform for managing medical data, ensuring security and performance."",
                      ""responsibilities"": [
                        ""Built UI components with ASP.NET WebForms and Vue.js."",
                        ""Utilized Hangfire for background job processing."",
                        ""Ensured secure authentication and authorization using Identity Server."",
                        ""Integrated ElasticSearch to improve query performance and provide robust speed for data retrieval.""
                      ]
                    },
                    {
                      ""position"": ""Full-stack Developer"",
                      ""company"": ""Idealogic"",
                      ""location"": ""Kraków"",
                      ""startDate"": ""August 2018"",
                      ""endDate"": ""November 2021"",
                      ""description"": ""Worked on engineering tools for structural calculations and planning."",
                      ""responsibilities"": [
                        ""Optimized test model calculations by integrating external engines for improved performance."",
                        ""Designed a user-friendly UI with Angular controls."",
                        ""Migrated legacy .NET Framework API solutions to .NET Core API, improving performance and maintainability.""
                      ]
                    }
                  ],
                  ""skills"": [
                    ""C#"",
                    "".NET Framework"",
                    "".NET Core"",
                    ""Entity Framework"",
                    ""ASP.NET WebForms"",
                    ""Web API"",
                    ""WCF"",
                    ""JavaScript / TypeScript (Vue)"",
                    ""SQL"",
                    ""Git"",
                    ""SOLID"",
                    ""Unit Testing"",
                    ""Design Patterns"",
                    ""Azure""
                  ],
                  ""languages"": {
                    ""English"": ""Native"",
                    ""Polish"": ""B2""
                  },
                }
            ";
        }
    }
}
