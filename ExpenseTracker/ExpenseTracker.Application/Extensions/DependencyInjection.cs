﻿using ExpenseTracker.Application.Hubs;
using ExpenseTracker.Application.Services;
using ExpenseTracker.Application.Services.Interfaces;
using ExpenseTracker.Application.Stores;
using ExpenseTracker.Application.Stores.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ExpenseTracker.Application.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection RegisterApplication(this IServiceCollection services)
    {
        services.AddScoped<ICategoryStore, CategoryStore>();
        services.AddScoped<ITransferStore, TransferStore>();
        services.AddScoped<IWalletStore, WalletStore>();
        services.AddScoped<IUserStore, UserStore>();
        services.AddScoped<ICurrentUserService, CurrentUserService>();

        services.AddSignalR();
        services.AddSingleton<NotificationHub>();

        return services;
    }
}
