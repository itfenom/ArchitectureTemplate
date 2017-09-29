﻿using System.Collections.Generic;
using System.Threading.Tasks;
using ArchitectureTemplate.Business.DataEntities;
using ArchitectureTemplate.Infraestrutura.CrossCutting.Support.Extensions;

namespace ArchitectureTemplate.Business.Interfaces.Services
{
    public interface IPerfilService : IServiceBase<Perfil>
    {
        IDictionary<int, string> GetDictionary();
        Task<IDictionary<int, string>> GetDictionaryAsync();
        IEnumerable<Perfil> Get(Pagination paginar);
        Task<IEnumerable<Perfil>> GetAsync(Pagination paginar);
        void DisableOrEnable(long perfilId, long userId);
    }
}
