using System;
using System.Collections.Generic;
using System.Linq;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            List<string> firstnames  = new List<string>();
            List<string> lastnames  = new List<string>();

            for (int i=0; i<2; i++) { 
                Console.WriteLine("Enter first name");
                firstnames.Add(Console.ReadLine());  
                Console.WriteLine("Enter last name");
                lastnames.Add(Console.ReadLine());


            }
            string[] finalNames = program.getName(firstnames, lastnames);
            foreach (string name in finalNames)
            {
                Console.WriteLine(name + "\n");
            }


        }
        public string[] getName(List<string>firstname , List<string>lastname)
        {
     
            List<string> fullname = firstname.Concat(lastname).ToList();
            string[]infoarray = fullname.ToArray();
            string[] fullName = new string[2];
            fullName[0] = infoarray[0] + " " + infoarray[2];
            fullName[1] = infoarray[1] + " " + infoarray[3];
            return fullName;
        }
        
    }
}
