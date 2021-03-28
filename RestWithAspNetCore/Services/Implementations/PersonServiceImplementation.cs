using RestWithAspNetCore.Models;
using System.Collections.Generic;
using System;
using System.Threading;

namespace RestWithAspNetCore.Services.Implementations
{
    public class PersonServiceImplementation : IPersonService
    {
        private volatile int count;
        public Person Create(Person person)
        {
            return person;
        }

        public Person FindById(long id)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Albert",
                LastName = "Lemos",
                Address = "Porto Portugal",
                Gender = "Male"
            };
        }

        public List<Person> FindAll()
        {
            List<Person> people = new List<Person>();
            for (int i = 0; i < 8; i++)
            {
                Person person = MockPerson(i);
                people.Add(person);
            }

            return people;
        }

        public Person Update(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                Id = IncrementAndGet(),
                FirstName = "Albert",
                LastName = "Lemos",
                Address = "Porto Portugal",
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}