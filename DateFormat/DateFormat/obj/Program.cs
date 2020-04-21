using System;

namespace DateFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("La fecha en el nuevo formato es:" + " " + DateFormat("10/11/1977"));
        }

        static string DateFormat (String fecha)
        {
            
            return  fecha.Substring(6,4) + "-" + fecha.Substring(3,2) + "-" + fecha.Substring(0,2);  
            
        }
    }
}
