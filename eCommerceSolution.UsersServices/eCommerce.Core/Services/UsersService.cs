﻿using AutoMapper;
using eCommerce.Core.DTOs;
using eCommerce.Core.Entities;
using eCommerce.Core.RepositoryContracts;
using eCommerce.Core.ServiceContracts;

namespace eCommerce.Core.Services;

public class UsersService : IUsersService
{
    private readonly IUsersRepository _usersRepository;
    private readonly IMapper _mapper;

    public UsersService(IUsersRepository usersRepository, IMapper mapper)
    {
        _usersRepository = usersRepository;
        _mapper = mapper;
    }

    public async Task<UserDTO> GetUserByUserID(Guid userID)
    {
        var user = await _usersRepository.GetUserByUserID(userID);
        return _mapper.Map<UserDTO>(user);
    }

    public async Task<AuthenticationResponse> Login(LoginRequest loginRequest)
    {
        var user = await _usersRepository.GetUserByEmailAndPassword(loginRequest.Email, loginRequest.Password);

        if (user == null) 
        {
            return null;
        }

        return _mapper.Map<AuthenticationResponse>(user) with { Success = true, Token = "token" };
    }

    public async Task<AuthenticationResponse> Register(RegisterRequest registerRequest)
    {
        ApplicationUser user = new ApplicationUser()
        {
            PersonName = registerRequest.PersonName,
            Email = registerRequest.Email,
            Password = registerRequest.Password,
            Gender = registerRequest.Gender.ToString()
        };

        var registeredUser = await _usersRepository.AddUser(user);

        if (registeredUser == null)
        {
            return null;
        }

        return _mapper.Map<AuthenticationResponse>(registeredUser) with { Success = true, Token = "token" };
    }
}
