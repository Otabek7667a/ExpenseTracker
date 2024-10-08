﻿using ExpenseTracker.Application.Requests.Wallet;
using ExpenseTracker.Application.ViewModels.Wallet;
using ExpenseTracker.Domain.Entities;

namespace ExpenseTracker.Application.Mappings;

public static class WalletMappings
{
    public static WalletViewModel ToViewModel(this Wallet wallet)
    {
        return new WalletViewModel
        {
            Id = wallet.Id,
            Name = wallet.Name,
            Description = wallet.Description,
            Balance = wallet.Balance,
            IsMain = wallet.IsMain,
            UserId = wallet.OwnerId,
            UserName = wallet.Owner.UserName
        };
    }

    public static Wallet ToEntity(this CreateWalletRequest request) => new()
    {
        Name = request.Name,
        Description = request.Description,
        IsMain = request.IsMain,
        Balance = request.Balance,
        Owner = null!,
        OwnerId = request.UserId,
    };
}
