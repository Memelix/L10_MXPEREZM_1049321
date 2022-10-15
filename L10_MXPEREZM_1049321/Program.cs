using System;

namespace L10_MXPEREZM_1049321
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES//
            string user = "";
            string password = "";
            int intentos = 1;

            //Instrucciones para el usuario y su cantidad de intentos
            while (intentos <= 3)
            {
                Console.WriteLine("Login: te quedan " + intentos);
                Console.WriteLine("\n Por favor ingrese su Usuario");
                user = Console.ReadLine();
                Console.WriteLine("Por favor ingrese su contraseña");
                password = Console.ReadLine();

                //Si la contraseña es incorrecta//
                if (Login(user, password) == false)
                {
                    intentos++;
                    Console.WriteLine("\n Usuario y/o contraseña puede que sean incorrectos, intentelo nuevamente");
                    Console.ReadLine();
                    Console.Clear();
                }
                //Si la contraseña es correcta//
                else
                {
                    Console.Clear();
                    Console.WriteLine("El usuario y contraseña son correctos");
                    Console.ReadLine();
                    Environment.Exit(0);
                }


            }

            Console.WriteLine("Te has quedado sin intentos");
            Console.ReadLine();

        }
        //Datos correctos para el ingreso//
        public static bool Login(string user, string password)
        {
            if ((user == "usuario1") && (password == "asdasd"))
            {
                return true;
            }
            return false;
        }

    }
}
