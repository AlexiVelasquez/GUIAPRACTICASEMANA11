using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace GUIAPRACTICASEMANA11
{
    internal class Program
    {
       static void Main(string[] args)
       {
            int opcion= pantallamenu.pantallaprincipal();

            do
            {
                Console.Clear();
                switch (opcion)
                {

                    case 6:
                        Console.Clear();
                        opcion = pantallamenu.vernotas();
                        break;
                    case 5:
                        Console.Clear();
                        opcion = pantallamenu.modificarnota();
                        break;
                    case 4:
                        Console.Clear();
                        opcion = pantallamenu.buscarnota();
                        break;
                    case 3:
                        Console.Clear();
                        opcion = pantallamenu.notamenor();
                        break;
                    case 2:
                        Console.Clear();
                        opcion = pantallamenu.notamayor();
                        break;
                    case 1:
                        Console.Clear();
                        opcion = pantallamenu.ingresarnotas();
                        break;
                    case 0:
                    default:
                        opcion = pantallamenu.pantallaprincipal();
                        break;

                }
            } while (opcion != 7);
            Console.ReadLine();
       }
    }
}
