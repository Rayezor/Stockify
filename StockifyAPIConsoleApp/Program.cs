// See https://aka.ms/new-console-template for more information
using StockifyAPIConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Net.Http.Formatting;
using System.Threading.Tasks;
using System.Net.Http.Json;
using Newtonsoft.Json;

namespace StockifyAPIConsoleApp
{
    class Program
    {
        private static HttpClient theAPI;

        private static void Main(string[] args)
        {
            theAPI = new HttpClient();
            theAPI.BaseAddress = new Uri("http://localhost:5233/");
            theAPI.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
           GetCompanyByID("1").Wait();
           GetAllCompanies().Wait();
            
        }

        private static async Task GetCompanyByID(string id)
        {
            Console.WriteLine("");
            Console.WriteLine("***GetCompanyByID***");
            Console.WriteLine("");
            HttpResponseMessage response = await theAPI.GetAsync("api/Company");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("GetAllEmails - Error: " + response.StatusCode + response.ReasonPhrase);
            }
        }

        private static async Task GetAllCompanies()
        {
            Console.WriteLine("");
            Console.WriteLine("***GetAllCompanies***");
            Console.WriteLine("");
            HttpResponseMessage response = await theAPI.GetAsync("/GetAll");
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                Console.WriteLine(result);
              
            }
            else
            {
                Console.WriteLine("GetAllEmails - Error: " + response.StatusCode + response.ReasonPhrase);
            }
        }
    }
}