using System;

namespace FastBlazor
{
    internal interface IFastGrid
    {
        internal void AddColumn(FastGridColumn column);

        internal Type Type { get; }
    }
}