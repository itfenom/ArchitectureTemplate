﻿using System.Collections.Generic;
using System.Threading.Tasks;
using ArchitectureTemplate.Domain.DataEntities;
using ArchitectureTemplate.Infraestrutura.CrossCutting.Support.Extensions;

namespace ArchitectureTemplate.Domain.Interfaces.Repositories
{
    public interface IProfileRepository : IRepositoryBase<Profile>
    {
        IDictionary<int, string> GetDictionary();
        Task<IDictionary<int, string>> GetDictionaryAsync();
        IEnumerable<Profile> Get(Pagination paginar);
        Task<IEnumerable<Profile>> GetAsync(Pagination paginar);
    }
}
