using AutoMapper;
using FluentValidation;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AspNetCoreWebApiCleanArchitecture.WebApi.Extensions
{
    public static class StartupExtensions
    {
        #region Configure Services

        public static void AddCoreApplicationLayer(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }

        #endregion

        #region Configure (Application)
        #endregion
    }
}
