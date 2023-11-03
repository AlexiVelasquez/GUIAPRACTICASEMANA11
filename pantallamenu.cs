using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GUIAPRACTICASEMANA11
{
    public class pantallamenu
    {
        public static float[] notas = new float[100];
        public static float[]numerostotales= new float[100];
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
            float notaregistradas=Operaciones.getDecimal("Ingresa la nota N:");

            notas[contador] = notaregistradas;
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
            float mayor = notas[0];
            int posicionmayor = 0;
            for (int i = 0; i < contador; i++)
            {
                if (notas[i] > mayor)
                {
                    
                    mayor = notas[i];
                    posicionmayor =i;
                }
            }
            string texto = "================================\n" +
            "La nota mayor\n" +
            "================================\n";
            Console.Write(texto);
            Console.WriteLine("La nota mayor es: " + mayor + "\n");

            for (int i = 0; i < contador; i++)
            {
                if (i == posicionmayor)
                {

                    Console.Write("[" + notas[i] + "]");



                }
            }
           string texto2 = "================================\n" +
                "1: Regresar\n";

            Console.Write(texto2);
            int opcion = Operaciones.getEntero("Ingrese una opcion: ", texto2);
            if (opcion == 1) return 0;

                return opcion;
            



        }
        public static int notamenor()
        {
            float menor = notas[0];
            int posicionmenor = 0;
            for (int i = 0; i < contador; i++)
            {
                if (notas[i] < menor)
                {

                    menor = notas[i];
                    posicionmenor = i;
                }
            }
            string texto = "================================\n" +
                "La nota menor\n" +
                "================================\n" +
                "La nota menor es:" + menor + "\n";
            Console.Write(texto);
            for (int i = 0;i < contador; i++)
            {
                if(i == posicionmenor)
                {

                    Console.Write("[" + notas[i] + "] \n");



                }
            }
            string texto2 = "================================\n" +
            "1: Regresar\n";
            Console.Write(texto2);
            int opcion = Operaciones.getEntero("Ingrese una opcion: ", texto);
            if (opcion == 1) return 0;

            return opcion;


        }
        public static int buscarnota()
        {

            string texto = "================================\n" +
                "Buscar nota\n" +
                "================================\n";
            Console.Write(texto);

            float valorBuscar = Operaciones.getDecimal("Ingrese la nota a buscar: ");
            int posicionEncontrada = -1;

            for (int i = 0; i < contador; i++)
            {
                if (valorBuscar == notas[i])
                {
                    posicionEncontrada = i;
                    break;
                }
            }
            if (posicionEncontrada != -1)
            {
                Console.WriteLine("La nota esta en la posicion: " + posicionEncontrada); ;
                for (int i = 0; i < contador; i++)
                {
                    if (i == posicionEncontrada)
                    {

                        Console.WriteLine(i + " -> [" + notas[i] + "]");

                    }

                }
            }
            Console.Write(texto);
            string texto3 = "================================\n" +
                "1: Regresar\n";
            Console.Write(texto3);
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
                Console.Write(notas[i]+" - ");

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
