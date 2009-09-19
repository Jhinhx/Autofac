﻿// This software is part of the Autofac IoC container
// Copyright (c) 2007 - 2008 Autofac Contributors
// http://autofac.org
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.

using System;
using Autofac.Util;

namespace Autofac
{
    /// <summary>
    /// Fired when the activation process for a new instance is complete.
    /// </summary>
    public class ActivatingEventArgs<T> : EventArgs
    {
        readonly IComponentContext _context;
        readonly IComponentRegistration _component;
        readonly T _instance;

        /// <summary>
        /// Initializes a new instance of the <see cref="ActivatedEventArgs{T}"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="component">The component.</param>
        /// <param name="instance">The instance.</param>
        public ActivatingEventArgs(IComponentContext context, IComponentRegistration component, T instance)
        {
            _context = Enforce.ArgumentNotNull(context, "context");
            _component = Enforce.ArgumentNotNull(component, "component");
            Enforce.ArgumentNotNull((object)instance, "instance");
            _instance = instance;
        }

        /// <summary>
        /// The context in which the activation occurred.
        /// </summary>
        public IComponentContext Context { get { return _context; } }

        /// <summary>
        /// The component providing the instance.
        /// </summary>
        public IComponentRegistration Component { get { return _component; } }

        /// <summary>
        /// The instance that will be used to satisfy the request.
        /// </summary>
        public T Instance { get { return _instance; } }
    }
}
