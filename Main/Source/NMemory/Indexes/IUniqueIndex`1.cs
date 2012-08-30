﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NMemory.Indexes
{
    public interface IUniqueIndex<TEntity> :
        IIndex<TEntity>,
        IUniqueIndex

        where TEntity : class
    {
    }
}