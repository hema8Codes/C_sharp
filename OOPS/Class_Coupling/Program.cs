using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSLearning
{
    class Program
    {
        public static void Main(string[] args)
        {

            // Types of relationships
            // Inheritance
            // Composition

            // What is composition?
            // A kind of relationship between two classes that allows one to contain the other
            // Has-a relationship
            // Example: Car has an Engine

            //Benefits
            // Code re-use
            // Flexibilty
            // A means to loose-coupling

            //eg -> DbMigrator requires logging
            // Installer requires logging

            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();

        }

    }
}
