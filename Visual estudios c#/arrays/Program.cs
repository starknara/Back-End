using System;

namespace nuevo_proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            int lector;
            bool estado = false;
            do
            {
                Console.WriteLine(@"
                _                     _        ______    _____   _____    ____    _   _ 
               | |          /\       | |      |  ____|  / ____| |_   _|  / __ \  | \ | |
               | |         /  \      | |      | |__    | |  __    | |   | |  | | |  \| |
               | |        / /\ \     | |      |  __|   | | |_ |   | |   | |  | | | . ` |
               | |____   / ____ \    | |____  | |____  | |__| |  _| |_  | |__| | | |\  |
               |______| /_/    \_\   |______| |______|  \_____| |_____|  \____/  |_| \_|
                                                                                                                         
                                                                       ");
                Console.WriteLine("                              ===== Ingrese la pregunta a resolver ====");
                Console.WriteLine("________________________________________________________________________________________________");
                Console.WriteLine("1.- Ingresera un numero y se imprimira si es primo");
                Console.WriteLine("2.- Ingresera un numero y se imprimira si es par o impar");
                Console.WriteLine("3.- Ingresera un numero del 1 al 7 y se imprimira el dia de la semana correspondiente");
                Console.WriteLine("4.- Ingresera un numero y se imprimira el nombre del mes correspondite");
                Console.WriteLine("5.- Ingresera 3 numeros y se imprimira de menor a mayor");
                Console.WriteLine("6.- Ingresera un numero y se imprimira si es positivo o negativo");
                Console.WriteLine("7.- Ingresera una letra y se imprimira si es vocal");
                Console.WriteLine("8.- Ingresera 10 numeros y se imprimira cual es mayor y menor");
                Console.WriteLine("9.- Ingresera 3 numeros y se indicara si el tercero es = a la suma del primero y el segundo");
                Console.WriteLine("10.-Aplicacion que calcula el aumento de sueldo de un trabajador en base a diversos criterios");
                Console.WriteLine("11.-Una Calculadora pedira una operacion (+,-,*,/,³) y luego dos numeros para dicaha operacion");
                Console.WriteLine("                                                                                                ");
                Console.WriteLine("__________________________CODIGO TECSUP ALEX JONATHAN LIÑAN ALPACA _____________________________");
                Console.WriteLine("________________________________________________________________________________________________");
                int op = Int32.Parse(Console.ReadLine());

                if (op == 1)
                {
                    PrimeraPregunta();
                }
                if (op == 2)
                {
                    SegundaPregunta();
                }
                if (op == 3)
                {
                    TerceraPregunta();
                }
                if (op == 4)
                {
                    CuartaPregunta();
                }
                if (op == 5)
                {
                    QuintaPregunta();
                }
                if (op == 6)
                {
                    SextaPregunta();
                }
                if (op == 7)
                {
                    SeptimaPregunta();
                }
                if (op == 8)
                {
                    OctabaPregunta();
                }
                if (op == 9)
                {
                    NovenaPregunta();
                }
                if (op == 10)
                {
                    DecimaPregunta();
                }
                if (op == 11)
                {
                    OnceavaPregunta();
                }
                Console.WriteLine("________________________________________________________________________________________________");
                Console.WriteLine(" Presione ( 1 ) para otra accion o ( 2 ) para salir porfavor");
                lector = int.Parse(Console.ReadLine());
                if (lector == 1) { estado = false; }
                else if (lector == 2) { estado = true; }
                System.Console.Clear();
            } while (estado == false);
        }
        static void PrimeraPregunta()
        {
            Console.WriteLine("Ingrese un numero Porfavor");
            int valor = Int32.Parse(Console.ReadLine());
            int a = 0;
            if (valor >= 1 && valor <= 999000000)
            {
                for (int i = 1; i < (valor + 1); i++)
                {
                    if (valor % i == 0)
                    {
                        a++;
                    }
                }
                if (a != 2)
                {
                    Console.WriteLine("No es Primo");
                }
                else
                {
                    Console.WriteLine("Si es Primo");
                }
            }
        }
        static void SegundaPregunta()
        {
            Console.WriteLine("Ingrese un numero Porfavor");
            int valor = Int32.Parse(Console.ReadLine());

            if ((valor % 2) == 0)
                Console.WriteLine("Es Par");
            else
                Console.WriteLine("Es Impar");

        }
        static void TerceraPregunta()
        {
            Console.WriteLine("Ingrese un numero del 1 al 7 Porfavor");
            int valor = Int32.Parse(Console.ReadLine());

            if (valor >= 1 && valor <= 7) ;
            else Console.WriteLine("No Ingreso un numero valido Intentelo de Nuevo :p");
            if (valor == 1)
            {
                Console.WriteLine("Lunes");
            }
            if (valor == 2)
            {
                Console.WriteLine("Martes");
            }
            if (valor == 3)
            {
                Console.WriteLine("Miercoles");
            }
            if (valor == 4)
            {
                Console.WriteLine("Jueves");
            }
            if (valor == 5)
            {
                Console.WriteLine("Viernes");
            }
            if (valor == 6)
            {
                Console.WriteLine("Sabado");
            }
            if (valor == 7)
            {
                Console.WriteLine("Domingo");
            }
        }
        static void CuartaPregunta()
        {
            Console.WriteLine("Ingrese un numero del 1 al 12 Porfavor");
            int valor = Int32.Parse(Console.ReadLine());
            if (valor >= 1 && valor <= 12) ;
            else Console.WriteLine("No Ingreso un numero valido Intentelo de Nuevo :p");

            if (valor == 1)
                {
                    Console.WriteLine("Enero");
                }
            if (valor == 2)
            {
                Console.WriteLine("Febrero");
            }
            if (valor == 3)
            {
                Console.WriteLine("Marzo");
            }
            if (valor == 4)
            {
                Console.WriteLine("Abril");
            }
            if (valor == 5)
            {
                Console.WriteLine("Mayo");
            }
            if (valor == 6)
            {
                Console.WriteLine("Junio");
            }
            if (valor == 7)
            {
                Console.WriteLine("Julio");
            }
            if (valor == 8)
            {
                Console.WriteLine("Agosto");
            }
            if (valor == 9)
            {
                Console.WriteLine("Septiembre");
            }
            if (valor == 10)
            {
                Console.WriteLine("Octubre");
            }
            if (valor == 11)
            {
                Console.WriteLine("Noviembre");
            }
            if (valor == 12)
            {
                Console.WriteLine("Dicimbre");
            }
        }
        static void QuintaPregunta()
        {


            int[] numeros = new int[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese el numero Porfavor");
                numeros[i] = Int32.Parse(Console.ReadLine());
            }
            Array.Sort(numeros);
            Console.WriteLine("Los Numeros ordenados son:");
            Console.WriteLine("--------------------------");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(numeros[i]);
            }
        }
        static void SextaPregunta()
        {
            Console.WriteLine("Ingrese un numero al azar Porfavor");
            int valor = Int32.Parse(Console.ReadLine());

            if (valor >= 0)
                Console.WriteLine("Es Positivo");
            else
                Console.WriteLine("Es Negativo" +
                    "");
        }
        static void SeptimaPregunta()
        {
            Console.WriteLine("Ingrese una Letra Porfavor");
            string letra = Console.ReadLine();
            if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
            {
                Console.WriteLine("Es una vocal");
            }
            else
            {
                Console.WriteLine("No es Vocal");
            }
        }
        static void OctabaPregunta()
        {
            Console.WriteLine("Ingrese 10 numeros Porfavor");
            int[] numeros = new int[10];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Ingrese el numero" + " " + (i + 1));
                numeros[i] = int.Parse(Console.ReadLine());
            }

            void MetodoBurbuja()
            {
                int temporal;
                for (int a = 1; a < numeros.Length; a++)
                    for (int b = numeros.Length - 1; b >= a; b--)
                    {
                        if (numeros[b - 1] > numeros[b])
                        {
                            temporal = numeros[b - 1];
                            numeros[b - 1] = numeros[b];
                            numeros[b] = temporal;
                        }
                    }
            }
            MetodoBurbuja();

            void Imprimir()
            {
                Console.WriteLine("El número mayor es " + numeros[9]);
                Console.WriteLine("El número menor es " + numeros[0]);
                Console.ReadLine();
            }
            Imprimir();
        }
        static void NovenaPregunta()
        {
            int suma = 0;
            int[] numeros = new int[3];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Ingrese el número " + (i + 1));
                numeros[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < (numeros.Length - 1); i++)
            {
                suma = suma + numeros[i];
            }
            if (suma == numeros[numeros.Length - 1]) { Console.WriteLine("El tercer número es igual a la suma de los dos anteriores \n"); }
            else if (suma < numeros[numeros.Length - 1]) { Console.WriteLine("El tercer número no es igual a la suma de los dos anteriores, ES MAYOR \n"); }
            else if (suma > numeros[numeros.Length - 1]) { Console.WriteLine("El tercer número no es igual a la suma de los dos anteriores, ES MENOR \n"); }
        }
        static void DecimaPregunta()
        {
            int total = 0; ;
            int cantidad;
            Console.WriteLine("Ingrese la catidad de años que ha trabajado en la empresa");
            cantidad = int.Parse(Console.ReadLine());
            if (cantidad > 10) { total = (50000 * 10) / 100; }
            else if (cantidad > 5 && cantidad < 10) { total = (50000 * 7) / 100; }
            else if (cantidad > 3 && cantidad < 5) { total = (50000 * 5) / 100; }
            else if (cantidad < 3 && cantidad > 0) { total = (50000 * 3) / 100; }
            else if (cantidad == 0 || cantidad < 0) { Console.WriteLine("Usted no tiene aumento"); }
            Console.WriteLine("Su aumento es de " + total);
        }
        static void OnceavaPregunta()
        {
            {
                int opcion;
                int n1;
                int n2;
                int rpta = 0;
                Console.WriteLine("¿Qué desea hacer? \n 1:Suma \n 2:Resta \n 3:Multiplicación \n 4:Division \n 5:Potencia ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el primer número");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        n2 = int.Parse(Console.ReadLine());
                        rpta = n1 + n2;
                        Console.WriteLine("La suma de " + n1 + "+ " + n2 + " es igual a " + rpta);
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el primer número");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        n2 = int.Parse(Console.ReadLine());
                        rpta = n1 - n2;
                        Console.WriteLine("La resta de " + n1 + " - " + n2 + " es igual a " + rpta);
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el primer número");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        n2 = int.Parse(Console.ReadLine());
                        rpta = n1 * n2;
                        Console.WriteLine("La multiplicación de " + n1 + "*" + n2 + " es igual a " + rpta);
                        break;
                    case 4:
                        Console.WriteLine("Ingrese el primer número");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        n2 = int.Parse(Console.ReadLine());
                        rpta = n1 / n2;
                        Console.WriteLine("La división de " + n1 + "/ " + n2 + " es igual a " + rpta);
                        break;
                    case 5:
                        double n3;
                        double n4;
                        Console.WriteLine("Ingrese el primer número");
                        n1 = int.Parse(Console.ReadLine());
                        n3 = (double)n1;
                        Console.WriteLine("Ingrese el segundo número");
                        n2 = int.Parse(Console.ReadLine());
                        n4 = (double)n2;
                        double respuesta;
                        respuesta = (double)rpta;
                        respuesta = Math.Pow(n3, n4);
                        Console.WriteLine("La potencia de " + n1 + "elevado " + n2 + " es igual a " + respuesta);
                        break;
                }
            }

        }
    }
}
