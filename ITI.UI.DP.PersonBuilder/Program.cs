using System;
using System.Diagnostics;
using System.Dynamic;
using System.Reflection.Metadata;

namespace ITI.UI.DP.PersonBuilder
{
    class Person
    {
        //personal data
        public string Name { get; set; }
        public int Age { get; set; }
        //address
        public string StreetAddress { get; set; }
        public string PostalCode { get; set; }
        //employment data
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public override string ToString()
        {
            return $"Personal Data\nName: {Name},Age: {Age}\n " +
                   $"Address:\n Street: {StreetAddress},PostalCode: {PostalCode}\n" +
                   $"Employment Data: Works at {CompanyName}, As a: {Position}";
        }
    }

    class PersonBuilder
    {
        protected Person Person = new Person();
        public PersonDataBuilder PersonalData => new PersonDataBuilder(Person);
        public PersonAddressBuilder Lives => new PersonAddressBuilder(Person);
        public PersonJobBuilder Works => new PersonJobBuilder(Person);
        
        public static implicit operator Person(PersonBuilder pb)
        {
            return pb.Person;
        }
    }

    class PersonDataBuilder : PersonBuilder
    {
        public PersonDataBuilder(Person person)
        {
            this.Person = person;
        }

        public PersonDataBuilder Name(string name)
        {
            Person.Name = name;
            return this;
        }
        public PersonDataBuilder Age(int age)
        {
            Person.Age = age;
            return this;
        }
    }
    class PersonAddressBuilder : PersonBuilder
    {
        public PersonAddressBuilder(Person person)
        {
            this.Person = person;
        }

        public PersonAddressBuilder Street(string streetAddress)
        {
            Person.StreetAddress = streetAddress;
            return this;
        }
        public PersonAddressBuilder Postal(string postalCode)
        {
            Person.PostalCode = postalCode;
            return this;
        }

    }

    class PersonJobBuilder : PersonBuilder
    {
        public PersonJobBuilder(Person person)
        {
            Person = person;
        }

        public PersonJobBuilder InA(string companyName)
        {
            Person.CompanyName = companyName;
            return this;
        }
        public PersonJobBuilder AsA(string position)
        {
            Person.Position = position;
            return this;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Person.Lives.At().Postal().WorksAt().AsA()
            PersonBuilder pb = new PersonBuilder();
            Person person = pb
                            .PersonalData
                                .Name("Hamada")
                                .Age(100)
                            .Lives
                                .Street("Cairo")
                                .Postal("12345")
                           .Works
                                .InA("IBM")
                                .AsA("Developer");
            Debug.WriteLine(person.ToString());
        }
    }
}
