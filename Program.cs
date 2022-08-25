

using System.Globalization;
using System;

internal class Program 
{
		static void Main(string[] args)  
        {
         
         string memb;
         string res;
         int precio;
         double des1;
         double des2;
         double des3;
         double total1;
         double total2;
         double total3;

         Console.WriteLine("Ingrese el precio de su helado: ");
         precio = Convert.ToInt32(Console.ReadLine());

         Console.WriteLine("Cuenta con alguna membrecia?");
			   res = Console.ReadLine();


        if (res.Equals("si")) {
				Console.WriteLine("Ingrese su tipo de membrecia: ");
				Console.WriteLine("membrecia tipo A su descuento es del 10%: ");
				Console.WriteLine("membrecia tipo B su descuento es del 15%: ");
				Console.WriteLine("membrecia tipo C su descuento es del 20%: ");
				memb = Console.ReadLine();

         switch (memb) {

    case "A":
				des1 = precio*0.10;
				Console.WriteLine("Su descuento es de: Q"+des1);
				total1 = precio-des1;
				Console.WriteLine("su total a pagar es de: Q"+total1); break;
		case "B":
				des2 = precio*0.15;
				Console.WriteLine("Su descuento es de: Q"+des2);
				total2 = precio-des2;
				Console.WriteLine("su total a pagar es de: Q"+total2); break;
		case "C":
				des3 = precio*0.20;
				Console.WriteLine("Su descuento es de: Q"+des3);
				total3 = precio-des3;
				Console.WriteLine("su total a pagar es de: Q"+total3); break;
			default:
				Console.WriteLine("Su total a pagar es de: Q"+precio); break;

         }

         } else {
				Console.WriteLine("Su total a pagar es de: Q"+precio); 
         }


         }
      }
  

