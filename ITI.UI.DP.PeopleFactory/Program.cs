using System;
using System.Collections.Generic;
using System.Linq;
using Factory.PeopleFactory;
using PersonReponsitory.Domain;
using PersonRepository.SQL;

namespace ITI.UI.DP.PeopleViewer
{
    class Program
    {
        static void Main(string[] args)
        {
            var repoType = GetUserInput();
            IPersonRepository repo = RepositoryFactory.GetRepository(repoType);
            PrintSourceType(repo);
            PrintPeople(repo.GetPeople().ToList());
            Console.ReadKey();
        }
        
        static RepositoryType GetUserInput()
        {
            
            Console.WriteLine("Choose repository type:");
            Console.WriteLine("1. File");
            Console.WriteLine("2. Local");
            Console.WriteLine("3. External Server");
            var input = Console.ReadKey().Key;
            RepositoryType repositoryType = RepositoryType.Undefined;
            Console.WriteLine();
            switch (input)
            {
                case ConsoleKey.D1:
                    repositoryType = RepositoryType.File;
                    break;
                case ConsoleKey.D2:
                    repositoryType = RepositoryType.Local;
                    break;
                case ConsoleKey.D3:
                    repositoryType = RepositoryType.ExternalSever;
                    break;
            }

            return repositoryType;
        }

        static void PrintSourceType(IPersonRepository repo)
        {
            Console.WriteLine($"----------Repository Type:{repo.GetType().ToString()}----------");
        }
        private static void PrintPeople(List<Person> peopleList)
        {
            foreach (var person in peopleList)
            {
                Console.WriteLine($"FirstName: {person.FirstName}");
                Console.WriteLine($"LastName: {person.LastName}");
                Console.WriteLine($"Rating: {person.Rating}");
                Console.WriteLine($"StartDate: {person.StartDate}");
            }
            Console.WriteLine("===============================================");
        }
    }
}
