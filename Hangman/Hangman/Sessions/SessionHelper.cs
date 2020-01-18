﻿using Microsoft.AspNetCore.Http;
using Utf8Json;
using Utf8Json.Resolvers;

namespace Hangman.Sessions
{
    public static class SessionHelper
    {
        public static void Set<T>(this ISession session, string key, T value)
        {
            JsonSerializer.SetDefaultResolver(StandardResolver.AllowPrivateCamelCase);
            session.SetString(key, JsonSerializer.ToJsonString(value));
        }

        public static T Get<T>(this ISession session, string key)
        {
            var value = session.GetString(key);

            return value == null ? default(T) : JsonSerializer.Deserialize<T>(value);
        }
    }
}
