﻿using Jwt.Api.Resolvers;
using Jwt.Business;
using Jwt.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Unity;

namespace Jwt.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Configuration et services API Web


            // DI:
            UnityContainer unityContainer = new UnityContainer();
            SetDependencies(unityContainer);
            config.DependencyResolver = new UnityResolver(unityContainer);

            // Itinéraires de l'API Web
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }

        private static void SetDependencies(UnityContainer container)
        {
            container.RegisterType<EntityRepository<Users>, UsersRepository>();
            container.RegisterType<EntityRepository<Roles>, RolesRepository>();
        }
    }
}
