﻿using CleanDemoProject.Core.Entities;
using System.Collections.Generic;

namespace CleanDemoProject.Infrastructure.Gateways
{
    public class InMemoryHouseRepository : IRepository<int, House>
    {
        private static readonly Dictionary<int, House> Store = new Dictionary<int, House>();

        House IRepository<int, House>.Get(int id)
        {
            return Store[id];
        }

        public House Save(House entity)
        {

            if (entity.Id.HasValue == false)
                entity.Id = Store.Count;

            Store[entity.Id.Value] = entity;

            return entity;
        }
    }
}
