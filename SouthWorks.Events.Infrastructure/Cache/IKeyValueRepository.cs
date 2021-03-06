﻿using System;

namespace SouthWorks.Events.Infrastructure.Cache
{
    public interface IKeyValueRepository
    {
        void Add(string key, object data);

        void Set(string key, object data);

        object Get(string key);

        void Remove(string key);
    }
}
