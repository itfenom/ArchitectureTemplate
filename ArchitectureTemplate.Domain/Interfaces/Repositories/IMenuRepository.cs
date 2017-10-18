﻿using ArchitectureTemplate.Domain.DataEntities;
using ArchitectureTemplate.Infraestrutura.CrossCutting.Support.Extensions;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ArchitectureTemplate.Domain.Interfaces.Repositories
{
    public interface IMenuRepository : IRepositoryBase<Menu>
    {
        void AddProfilePorMenu(ProfileForMenu entity, long userId);
        void AddRangeProfilePorMenu(IList<ProfileForMenu> entity, long userId);
        void UpdateList(IList<Menu> entityList, long userId);
        IEnumerable<Menu> GetAllWithDapper();
        IEnumerable<Menu> Get(Pagination pagination);
        Task<IEnumerable<Menu>> GetAsync(Pagination pagination);
        IEnumerable<int> GetIdsPorProfile(int profileId);
        IEnumerable<ProfileForMenu> GetPorProfile(int profileId);
        void Remove(int menuId, long userId);
        void RemoveProfilePorMenu(long profileForMenuId, long userId);
    }
}
