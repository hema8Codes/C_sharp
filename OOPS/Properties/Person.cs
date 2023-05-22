using System.Reflection;

namespace MyCSLearning
{
    public class Person
    {
        // Put all the Auto implemented properties in the top 
        // All the calculated properties in the bottom
        private DateTime _birthdate;
        public string Name { get; set; } // name of the person

        // Auto Implemented Properties
        //public DateTime Birthdate { get; set; }

        // Propertires  -> Pascal case
        public DateTime Birthdate // hance this property is readonly
        {
            get { return _birthdate; }
            private set { _birthdate = value; }  // In Auto implemented properties or other than that if we want that the
            // birthdate should be set once and it cannot be changed, then we put private access modifier before a set method
            // we set the birthdate using a constructor
        }

        // constructor
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;  
        }


        // this cannot be an auto implemented property
        // -> why ? age will be based on the birthdate of the person  
        public int Age
        {
            get
            {
                var timespan = DateTime.Today - Birthdate; // duration
                var years = timespan.Days / 365;

                return years;

            }
            // In Age property there is no set method as age is being calculated via DateTime. So if we do not want 
            // the property to be settable then we don't write the set method.
        }


    }
}
