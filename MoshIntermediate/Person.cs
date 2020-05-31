using System;

namespace MoshIntermediate
{
    public class Person
    {
        public DateTime BirthDate { get; private set; }

        public Person(DateTime birthadate)
        {
            BirthDate = birthadate;
        }
        public int Age 
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                Console.WriteLine(timeSpan);
                var years = timeSpan.Days / 365;

                return years;
            }
        }
    }
}
