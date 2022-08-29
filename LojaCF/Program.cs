using LojaCF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaCF
{
    internal class Program    {
        static void Main(string[] args)
        {
            Console.Write("criando e inicializando banco de dados ");
            using (var db = new EscolaContext())
            {
                new EscolaInitializer().InitializeDatabase(db);
            }
            Console.WriteLine("concluido");
            Console.ReadKey();

        }
    }
}
