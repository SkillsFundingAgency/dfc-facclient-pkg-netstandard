﻿using Autofac;
using AutoMapper;
using DFC.FindACourseClient.Contracts;
using DFC.FindACourseClient.Contracts.CosmosDb;
using DFC.FindACourseClient.Models.Configuration;
using DFC.FindACourseClient.Models.CosmosDb;
using DFC.FindACourseClient.Repositories;
using DFC.FindACourseClient.Services;
using Microsoft.Azure.Documents.Client;
using Microsoft.Extensions.DependencyInjection;

namespace DFC.FindACourseClient
{
    public static class DIExtensions
    {
        public static ContainerBuilder RegisterFindACourse(this ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(DIExtensions).Assembly)
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            return builder;
        }

        public static IServiceCollection AddFindACourseServices(this IServiceCollection services, CourseSearchClientSettings courseSearchClientSettings)
        {
            if (courseSearchClientSettings?.CourseSearchAuditCosmosDbSettings?.DatabaseId != null)
            {
                services.AddSingleton<ICosmosRepository<ApiAuditRecordCourse>, CosmosRepository<ApiAuditRecordCourse>>(s =>
                {
                    var cosmosDbAuditConnection = courseSearchClientSettings.CourseSearchAuditCosmosDbSettings;
                    var documentClient = new DocumentClient(cosmosDbAuditConnection.EndpointUrl, cosmosDbAuditConnection.AccessKey);
                    var isDevelopmentEnvironment = courseSearchClientSettings.CourseSearchAuditCosmosDbSettings.Environment?.ToLowerInvariant().Contains("development");
                    var repository = new CosmosRepository<ApiAuditRecordCourse>(cosmosDbAuditConnection, documentClient);
                    repository.InitialiseDatabaseAsync(isDevelopmentEnvironment.GetValueOrDefault()).GetAwaiter().GetResult();
                    return repository;
                });
            }

            services.AddScoped<IFindACourseClient, FindACourseClient>();
            services.AddScoped<IAuditService, AuditService>();
            services.AddScoped<IHttpClientService, HttpClientService>();
            services.AddAutoMapper(typeof(DIExtensions).Assembly);

            return services;
        }
    }
}