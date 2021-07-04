using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principal
{
    class Acciones
    {
        
        private int Top=0; //Arriba /abajo
        private int  Left = 0; //Izquierda / Derecha

        public Acciones() { }

        public void MovArriba(ConsoleKeyInfo tecla)
        {
            try
            {
                if (tecla.Key == ConsoleKey.UpArrow)
                {
                    Console.WriteLine("*");
                    Console.SetCursorPosition(Left, --Top);
                }
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.ActualValue);
                Console.ReadKey();
                Console.Clear();
            }
            
        }
        public void MovAbajo(ConsoleKeyInfo tecla)
        {
            try
            {
                if (tecla.Key == ConsoleKey.DownArrow)
                {
                    Console.WriteLine("*");
                    Console.SetCursorPosition(Left, ++Top);
                }
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.ActualValue);
                Console.ReadKey();
                Console.Clear();
            }
            
        }
        public void MovDerecha(ConsoleKeyInfo tecla)
        {
            try
            {
                if (tecla.Key == ConsoleKey.RightArrow)
                {
                    Console.WriteLine("*");
                    Console.SetCursorPosition(++Left, Top);
                }
            }catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.ActualValue);
                Console.ReadKey();
                Console.Clear(); 
            }
            
        }
        public void MovIzquierda(ConsoleKeyInfo tecla)
        {
            try
            {
                if (tecla.Key == ConsoleKey.LeftArrow)
                {
                    Console.WriteLine("*");
                    Console.SetCursorPosition(--Left, Top);
                }
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.ActualValue);
                Console.ReadKey();
                Console.Clear();
            }
            
        }

        public void Limpiar()
        {
            Console.Clear();
            
            Top = 0; //Arriba /abajo
            Left = 0; //Izquierda / Derecha

    }

        public void ColorConsola(ConsoleKeyInfo tecla)
        {
            if(tecla.Key == ConsoleKey.F1)
            {
                Console.ForegroundColor = ConsoleColor.Red;

            }else if (tecla.Key == ConsoleKey.F2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            
        }
        public void Informacion()
        {
            Console.Write("Info:\n" +
                "Presiona 'SPACEBAR' para cerrar el programa\n" +
                "Presiona 'F1' para Colocar el color de las letras ROJO\n" +
                "Presiona 'F2' para Colocar el color de las letras VERDE\n" +
                "Presiona 'F3' para Colocar el color de las letras BLANCAS\n" +
                "Presiona 'BACKSPACE' para Limpiar la pizarra\n"+
                "\n" +
                " Lo valores en el plano cartesiano empiezan en el 1er cuadrante \n" +
                "por tanto los valores no pueden ser negativos ");

        }
    }
}
  
/*
 Lo valores en el plano cartesiano empiezan en el 1er cuadrante
por tanto los valores no pueden ser negativos

arriba: Valores alejados de 0
abajo: valores mas cercanos a 0

derecha: Valores mas alejados del 0
izquierda: valores mas cercanos a 0
 
 */