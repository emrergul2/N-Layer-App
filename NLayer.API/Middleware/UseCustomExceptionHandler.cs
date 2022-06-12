using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using NLayer.Core.DTOs;
using NLayer.Service.Exceptions;
namespace NLayer.API.Middleware
{
    public static class UseCustomExceptionHandler
    {
        public static void UseCustomException(this IApplicationBuilder app)
        {
            app.UseExceptionHandler(config =>
            {
                config.Run(async context =>
                {
                    context.Response.ContentType = "application/json";
                    var exceptionFuture = context.Features.Get<IExceptionHandlerFeature>();
                    var statusCode = exceptionFuture.Error switch
                    {
                        ClientSideException => 400,
                        _ => 500
                    };
                    var response = CustomResponseDto<NoContentDto>.Fail(statusCode, exceptionFuture.Error.Message);
                    await context.Response.WriteAsJsonAsync(JsonSerializer.Serialize(response));
                });
            });
        }
    }
}