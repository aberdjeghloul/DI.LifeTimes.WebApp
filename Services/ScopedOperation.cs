﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.LifeTimes.WebApp.Services
{
    public class ScopedOperation : IScopedOperation
    {
        public Guid Id { get; }
        public ScopedOperation()
        {
            Id = Guid.NewGuid();
        }
    }
}
