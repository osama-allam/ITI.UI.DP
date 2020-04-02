using System;
using PersonReponsitory.CSV;
using PersonReponsitory.Domain;
using PersonRepository.Service;
using PersonRepository.SQL;

namespace Factory.PeopleFactory
{
    public enum RepositoryType
    {
        Undefined,
        Local,
        File,
        ExternalSever
    }
    public static class RepositoryFactory 
    {
        public static IPersonRepository GetRepository(RepositoryType repositoryFactory)
        {
            IPersonRepository repo = null;
            switch (repositoryFactory)
            {
                case RepositoryType.Local:
                    repo = new SQLRepository();
                    break;
                case RepositoryType.File:
                    repo = new CSVRepository();
                    break;
                case RepositoryType.ExternalSever:
                    repo = new ServiceRepository();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(repositoryFactory), repositoryFactory, null);
            }

            return repo;
        }
    }
}
