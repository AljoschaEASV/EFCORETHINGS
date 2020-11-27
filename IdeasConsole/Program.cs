using System;
using System.Collections.Generic;
using System.Linq;
using IdeasApp.Data;
using IdeasApp.Domain;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace IdeasConsole
{
    class Program
    {
        private static DatabaseContext context = new DatabaseContext();

        static void Main(string[] args)
        {
            var query = context.Ideas.ToList();
            foreach (var ideas in query)
            {
                Console.WriteLine(ideas);
            }
            Console.WriteLine(context.Ideas.ToList());
                
            Console.WriteLine("Press some");
            Console.ReadKey();

        }

        //private static void AddID()
        //{
        //    var Idea = new Idea() {CompanyID = "Gr8AmerikaComp"};
        //    context.Ideas.Add(Idea);
        //    context.SaveChanges(); 
        //}

    }
}
