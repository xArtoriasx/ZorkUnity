﻿namespace Zork.Common
{
    public interface IOutputService
    {
        void Write(object value);

        void WriteLine(object value);

        void Clear();
    }
}
