using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MainAsync().Wait();

        }

        static async Task MainAsync()
        {
            HttpClient cons = new HttpClient();
            cons.BaseAddress = new Uri("http://localhost:56993/");
            cons.DefaultRequestHeaders.Accept.Clear();
            cons.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            await MyAPIGet(cons);
        }

        static async Task MyAPIGet(HttpClient cons)
        {
            using (cons)
            {
                HttpResponseMessage res = await cons.GetAsync("api/hello");
                string message = await res.Content.ReadAsStringAsync();
                res.EnsureSuccessStatusCode();
                if (res.IsSuccessStatusCode)
                {
                    Console.WriteLine(message);
                    WaitForEsc();
                }
            }
        }

        static void WaitForEsc()
        {
            Console.WriteLine("Press ESC to Exit");
            do {} while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

    }

}
