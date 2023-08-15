﻿using apiUsers.Modelos;
using apiUsers.Modelos.Dtos;

namespace apiUsers.Repositorio.IRepositorio
{
    public interface IUserRepositorio
    {
        ICollection<User> GetUsers();
        User GetUser(string identificationUser);
        bool IsUniqueUser(string identificationUser);
        Task<UserLoginRespuestaDto> Login(UserLoginDto userLoginDto);
        Task<User> Registro(UserRegistroDto userRegistroDto);
    }
}
