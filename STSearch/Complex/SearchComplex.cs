using Core;

namespace Core.Shared
{
    using System;
    
    public partial struct STSearchComplex
    {
        public Int32 Index;

        public Int32 Count;

        public STSearchComplex(Int32 index, Int32 count)
        {
            this.Index = index;

            this.Count = count;

            return;
        }
    }
}
