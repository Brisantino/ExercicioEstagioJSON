using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;
using Newtonsoft.Json;
using ExercicioEstagioJSON.Serialization;
using System.Net;

namespace ExercicioEstagioJSON
{

    class Program
    {
        static void Main(string[] args)
        {
            //variavel utilizada no exercicio 3
            int totalSul = 0;

            Console.WriteLine("Baixando JSON...");
            //acesso ao json local
            //var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\users.json");

            //acesso ao json atravez da URL
            var json = new WebClient().DownloadString("https://jsonplaceholder.typicode.com/users");

            //passando o arquivo json para uma lista de classes user
            var user = JsonConvert.DeserializeObject<List<User>>(json);

            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine("=====  1- Todos os e-mails  =====");
            Console.WriteLine("");
            //Para cada usuario na lista, escrever o seu e-mail
            foreach (User usuario in user)
            {
                Console.WriteLine(" - " + usuario.email);
            }
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("=====  2- O e-mail de Samantha  ===== ");
            Console.WriteLine("");
            //Se ouver um username = Samantha na lista, escreva o seu e-mail
            foreach (User usuario in user)
            {
                if (usuario.userName == "Samantha")
                {
                    Console.WriteLine(" - " + usuario.email);
                    break;
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("===== 3- Total de usuários do hemisfério sul =====");
            Console.WriteLine("");
            //Para cada latitude menor que zero, aumente o totalSul
            foreach (User usuario in user)
            {
                if (usuario.address.geo.lat < 0)
                    totalSul++;
            }
            Console.WriteLine(" - " + totalSul + " usuários são do hemisferio sul.");
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
