﻿using Entity.Model.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IPersonData
    {
        Task Delete(int id);
        Task<Person> GetById(int id);
        Task<Person> Save(Person entity);
        Task Update(Person entity);
        Task<Person> GetByName(string name);
        Task<IEnumerable<Person>> GetAll();
    }
}
