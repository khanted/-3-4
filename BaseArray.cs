using System;

namespace Задание3_4
{
    public abstract class BaseArray<T> : IPrintable
    {
        protected T[] data;

        protected BaseArray(int size)
        {
            data = new T[size];
        }

        public abstract void Initialize(bool userFill = false);
        public abstract void Print();
        public abstract object Average();
    }
}
