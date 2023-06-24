﻿using Core;

namespace Core.Shared
{
    using System;

    public partial class STSearchSequenceBackwardIndexCount : SAInterface.ISearchSequence
    {
        public STSearchComplex Complex { get; set; }

        public STSearchSequenceBackwardIndexCount(Int32 size, Int32 volume, Int32 index, Int32 count, Boolean next, Boolean debug)
        {
            Debug(size, volume, index, count, next, debug);

            var start = index;

            var length = count;

            this.Complex = new STSearchComplex(start, length);

            return;
        }

        ~STSearchSequenceBackwardIndexCount()
        {
            return;
        }
    }
}
