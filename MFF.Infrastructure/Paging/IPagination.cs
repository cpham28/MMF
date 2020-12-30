﻿using System.Collections.Generic;

namespace  MFF.Infrastructure.Paging
{
    public interface IPagination<T>
    {
        int From { get; }
        int? Index { get; }
        int? Size { get; }
        int Count { get; }
        int Pages { get; }
        IList<T> Items { get; }
        bool HasPrevious { get; }
        bool HasNext { get; }
    }
}
