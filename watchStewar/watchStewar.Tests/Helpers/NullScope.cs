﻿using System;

namespace watchStewar.Tests.Helpers
{
    public class NullScope : IDisposable
    {
        public static NullScope Instance { get; } = new NullScope();

        public void Dispose() { }

        private NullScope() { }
    }
}
