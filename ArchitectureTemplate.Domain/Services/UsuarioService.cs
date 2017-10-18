﻿using ArchitectureTemplate.Domain.DataEntities;
using ArchitectureTemplate.Domain.Interfaces.Repositories;
using ArchitectureTemplate.Domain.Interfaces.Services;
using ArchitectureTemplate.Infraestrutura.CrossCutting.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureTemplate.Domain.Services
{
    public class UserService : ServiceBase<User>, IUserService
    {
        #region Fields

        private readonly IUserRepository _userRepository;

        #endregion

        #region Constructors

        public UserService(IUserRepository userRepository)
            : base(userRepository)
        {
            _userRepository = userRepository;
        }

        #endregion

        #region Methods

        public IEnumerable<User> Get(Pagination paginar)
        {
            return _userRepository.Get(paginar);
        }

        public async Task<IEnumerable<User>> GetAsync(Pagination paginar)
        {
            return await _userRepository.GetAsync(paginar);
        }

        public void DisableOrEnable(long userId, long userAutenticationId)
        {
            var ativo = _userRepository.GetId(userId).Ativo;
            _userRepository.DisableOrEnable(userId, userAutenticationId, !ativo);
        }

        public User Login(string user, string password)
        {
            return _userRepository.Login(user, CriptografarSenha(password), password);
        }

        public User RecuperarSenha(string email)
        {
            return _userRepository.RecuperarSenha(email, GetCodigoRecover(), CriptografarSenha(GetCodigoRecover()));
        }

        public void ResetSenha(string login, string codRecover, string newPassword)
        {
            _userRepository.ResetSenha(login, codRecover, CriptografarSenha(newPassword));
        }

        public void EditSenha(long userId, string password, string newPassword)
        {
            _userRepository.EditSenha(userId, CriptografarSenha(password), CriptografarSenha(newPassword));
        }

        public string GetSenha(long userId)
        {
            return _userRepository.GetSenha(userId);
        }

        public string GetCodigoRecover()
        {
            var chars = "ABCDEF0123456789GHIJKL0123456789MNOPQR0123456789STUVWXYZ0123456789";
            var random = new Random();
            var codigoRecover = new string(Enumerable.Repeat(chars, 10)
                .Select(s => s[random.Next(s.Length)]).ToArray());

            return codigoRecover;
        }

        public string GenerateToken(long userId)
        {
            var token = GetCodigoRecover();

            _userRepository.InsertToken(userId, token);

            return token;
        }

        public void CleanToken(long userId)
        {
            _userRepository.InsertToken(userId, null);
        }

        #endregion

        #region Private Methods

        private string CriptografarSenha(string senha)
        {
            return Convert.ToBase64String(new MD5CryptoServiceProvider().ComputeHash(new UTF32Encoding().GetBytes(senha)));
        }

        #endregion
    }
}