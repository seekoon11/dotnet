// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.AspNetCore.Mvc.Filters
{
    /// <summary>
    /// A filter that runs after an action has thrown an <see cref="System.Exception"/>.
    /// </summary>
    public interface IExceptionFilter : IFilterMetadata
    {
        /// <summary>
        /// Called after an action has thrown an <see cref="System.Exception"/>.
        /// </summary>
        /// <param name="context">The <see cref="ExceptionContext"/>.</param>
        void OnException(ExceptionContext context);
    }
}
