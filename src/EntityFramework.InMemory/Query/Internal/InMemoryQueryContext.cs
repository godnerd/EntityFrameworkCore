// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using JetBrains.Annotations;
using Microsoft.Data.Entity.Storage.Internal;
using Microsoft.Data.Entity.Utilities;

namespace Microsoft.Data.Entity.Query.Internal
{
    public class InMemoryQueryContext : QueryContext
    {
        public InMemoryQueryContext([NotNull] Func<IQueryBuffer> queryBufferFactory, [NotNull] IInMemoryStore store)
            : base(Check.NotNull(queryBufferFactory, nameof(queryBufferFactory)))
        {
            Store = store;
        }

        public virtual IInMemoryStore Store { get; }
    }
}
