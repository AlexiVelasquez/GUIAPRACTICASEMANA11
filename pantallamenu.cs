using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUIAPRACTICASEMANA11
{
    public class pantallamenu
    {
        public static string[] numerosescribir = new string[100];
        public static int contador = 0;
        public static int pantallaprincipal()
        {

            String texto = "================================\n" +
                "Casos con arreglos\n" +
                "================================\n" +
                "1: Registrar notas\n" +
                "2: Hallar la nota mayor\n" +
                "3: Hallar la nota menor\n" +
                "4: Encontrar una nota\n" +
                "5: Modificar una nota\n" +
                "6: Ver notas registradas\n" +
                "7: Salir\n" +
                "================================\n";
            Console.Write(texto);
            return Operaciones.getEntero("Ingrese una opcion:",texto );

        }
        public static int ingresarnotas()
        {
            string texto = "================================\n" +
                "Registrar una nota\n" +
                "================================\n";
            Console.Write(texto);
            string numero=Operaciones.getTextoPantalla("Ingresa la nota Nro 1:");

            numerosescribir[contador]= numero;
            contador++;

            string texto2="================================\n" +
                "1: Registrar otra nota\n" +
                "2: Regresar\n";
            Console.Write(texto2);

            int opcion = Operaciones.getEntero("Ingrese una opcion: ", texto);
            if (opcion == 2) return 0;

            return opcion;

        }
        public static int notamayor()
        {
            
            string texto = "================================\n" +
                "La nota mayor\n" +
                "================================\n" +
                "La nota mayor es:8\n"+
                "15 16[18] 10 12 15 13\n" +
                "================================\n" +
                "1: Regresar\n";

            Console.Write(texto);
            int opcion = Operaciones.getEntero("Ingrese una opcion: ", texto);
            if (opcion == 1) return 0;

                return opcion;
            



        }
        public static int notamenor()
        {
            string texto = "================================\n" +
                "La nota menor\n" +
                "================================\n" +
                "La nota menor es: 10\n" +
                "15 16 18 [10] 12 15 13\n" +
                "================================\n" +
                "1: Regresar\n";

            Console.Write(texto);
            int opcion = Operaciones.getEntero("Ingrese una opcion: ", texto);
            if (opcion == 1) return 0;

            return opcion;


        }
        public static int buscarnota()
        {
            string texto = "================================\n" +
                "Buscar nota\n" +
                "================================\n" +
                "Ingrese la nota a buscar: 12\n" +
                "La nota está en la posición 4\n" +
                "0 -> 15\n" +
                "1 -> 16\n" +
                "2 -> 18\n" +
                "3 -> 10\n" +
                "4 -> [12]\n" +
                "5 -> 15\n" +
                "6 -> 13\n" +
                "================================\n" +
                "1: Regresar\n";

            Console.Write(texto);
            int opcion = Operaciones.getEntero("Ingrese una opcion: ", texto);
            if (opcion == 1) return 0;

            return opcion;

        }
        public static int modificarnota()
        {
            string texto = "================================\n" +
                "Modificar nota\n" +
                "================================\n" +
                "Ingrese la posición: 3\n" +
                "Ingrese el nuevo valor: 19\n" +
                "================================\n" +
                "Antes:\n" +
                "15 16 18 [10] 12 15 13\n" +
                "Después:\n" +
                "15 16 18 [19] 12 15 13\n" +
                "================================\n" +
                "1: Regresar\n";

            Console.Write(texto);
            int opcion = Operaciones.getEntero("Ingrese una opcion: ", texto);
            if (opcion == 1) return 0;

            return opcion;


        }
        public static int vernotas()
        {
            string texto = "================================\n" +
                "Notas Registradas\n" +
                "================================\n" +
                "Notas actuales:\n";
            Console.Write(texto);
            for (int i = 0; i < contador; i++)
            {
                Console.Write(numerosescribir[i]+" - ");

            }
            Console.WriteLine();
            string texto2="Siguiente posición será:" +contador+"\n"+
               "================================\n" +
                "1: Regresar\n";

            Console.Write(texto2);
            int opcion = Operaciones.getEntero("Ingrese una opcion:", texto);
            if(opcion == 1)return 0;

            return opcion;

        }
    }   
}
