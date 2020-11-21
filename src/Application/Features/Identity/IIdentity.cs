﻿namespace BettingSystem.Application.Features.Identity
{
    using System.Threading.Tasks;
    using Commands;
    using Commands.LoginUser;
    using Common;

    public interface IIdentity
    {
        Task<Result<IUser>> Register(UserRequestModel userRequest);

        Task<Result<LoginResponseModel>> Login(UserRequestModel userRequest);
    }
}
