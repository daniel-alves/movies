﻿using Movies.Framework.Entities;
using Movies.Infra.Data.Contexts;

namespace Movies.Infra.Repositories.Common
{
    public class CommonRepository<TEntity> : Repository<TEntity, MovieContext>, ICommonRepository<TEntity>
        where TEntity : Entity
    {
        public CommonRepository(MovieContext context) : base(context)
        {
        }
    }
}
