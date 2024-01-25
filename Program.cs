using System;

namespace TPFinal_Muise
{
    class Program
    {
        static void Main(string[] args)
        {
        // Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero.
        // A partir de dichos datos informar:

        //  a. El mayor de los números pares.
        //  b. La cantidad de números impares.
        //  c. El menor de los números primos.

        //Nota: evaluar el uso de una función que analice si un número dado es primo o no 
        //y que devuelva true o false según corresponda.

         int n;
         int contadorImp;
         bool banPar = false;
         int maxPar = 0;
         bool banPrimo = false;
         int minPrimo = 0;
        
         Console.WriteLine("ingrese un número: ");
         n = int.Parse(Console.ReadLine());

         contadorImp = 0;
         while ( n != 0)
        {
          if (par(n))
          {
            if (!banPar)
            {
                maxPar = n;
                banPar = true;
            }else if (n > maxPar)
            {
                maxPar = n;
            }
          }else
           contadorImp++;
          //termina if de 'pares'.

          if (primo(n))
          {
            if (!banPrimo)
            {
                minPrimo = n;
                banPrimo = true;                
            }else if (n < minPrimo)
            {
                minPrimo = n;
            }
          } 
          // termina if  de 'primos'
         
         Console.WriteLine("ingrese un número: ");
         n = int.Parse(Console.ReadLine());
        }
         Console.WriteLine("El mayor de los numeros pares es: " + maxPar);
         Console.WriteLine("La cantidad de numeros impares es de: " + contadorImp);
         Console.WriteLine("El menor de los numeros primos es: " + minPrimo);

        }
        static bool par(int num){
            if (num % 2 == 0)
            
             return true;   
            
            else
            
                return false;
        }
        static bool primo(int nro){
            int contador = 0;
            for (int x = 1; x <= nro; x++)
            {
                if ( nro % x == 0)
                    contador++;
                               
            }
            if (contador ==2)
            
                return true;
            
            else
            
                return false;
            

        }
    }
}
