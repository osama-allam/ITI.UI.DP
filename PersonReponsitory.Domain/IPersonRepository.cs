﻿using System;
using System.Collections.Generic;

namespace PersonReponsitory.Domain
{
    public interface IPersonRepository
    {
        
        IEnumerable<Person> GetPeople();

        Person GetPerson(string lastName);

        void AddPerson(Person newPerson);

        void UpdatePerson(string lastName, Person updatedPerson);

        void DeletePerson(string lastName);

        void UpdatePeople(IEnumerable<Person> updatedPeople);
    }
}