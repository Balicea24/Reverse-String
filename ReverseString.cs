using System;

namespace str {
   class stringReverse {
       static void Main(string[] args){
         string a;
         string newStr = "";
         int x;

         Console.Write("Enter a string: ");
         a = Console.ReadLine();
         
         for (x = 1; x <= a.Length; x++){
            newStr += a[a.Length - x];
         }
         Console.WriteLine(newStr); 
      }
   }
} 