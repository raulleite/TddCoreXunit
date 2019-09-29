using System;
using TddCore.Domain.Entities;

namespace TddCore.Domain.Tests.Extensions
{
    public static class EntityExtensions
    {
        public static T WithBuildId<T>(this T entity) where T : EntityBase
        {
            entity.SetId(Guid.NewGuid());

            return entity;
        }
    }
}