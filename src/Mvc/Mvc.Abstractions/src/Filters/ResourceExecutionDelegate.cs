// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Mvc.Filters
{
    /// <summary>
    /// A delegate that asynchronously returns a <see cref="ResourceExecutedContext"/> indicating model binding, the
    /// action, the action's result, result filters, and exception filters have executed.
    /// </summary>
    /// <returns>A <see cref="Task"/> that on completion returns a <see cref="ResourceExecutedContext"/>.</returns>
    public delegate Task<ResourceExecutedContext> ResourceExecutionDelegate();
}