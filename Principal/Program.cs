using System;

namespace Principal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Pizarra";
            
            ConsoleKeyInfo tecla;
            bool opc = false;

            //Mov = movimiento.
            Acciones Mov = new Acciones();

            Mov.Informacion();
            Console.WriteLine("Pulse cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();


            while (opc == false)
            {
                tecla = Console.ReadKey();

                Mov.MovArriba(tecla);

                Mov.MovAbajo(tecla);
                
                Mov.MovDerecha(tecla);
                
                Mov.MovIzquierda(tecla);

                if(tecla.Key == ConsoleKey.Spacebar)
                {
                    opc = true;

                }else if(tecla.Key == ConsoleKey.F1 || tecla.Key == ConsoleKey.F2 || tecla.Key == ConsoleKey.F3)
                {
                    Mov.ColorConsola(tecla);

                }else if(tecla.Key == ConsoleKey.Backspace)
                {
                    Mov.Limpiar();
                }

            }
        }
    }
}
