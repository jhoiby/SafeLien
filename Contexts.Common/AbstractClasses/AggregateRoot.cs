﻿using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SSar.Contexts.Common.Notifications;

namespace SSar.Contexts.Common.AbstractClasses
{
    public abstract class AggregateRoot : Entity, IAggregateRoot
    {
        protected AggregateRoot()
        {
        }

        protected AggregateRoot(Guid id) : base(id)
        {
        }
    }
}
