﻿using Core;

namespace Core.Shared
{
    using System;

    public partial class STWordIsolate : SAInterface.IWordSequence
    {
        public STWord Word { get; set; }

        public STWordIsolate(SGText text, Int32 index, Int32 count, Boolean debug)
        {
            Debug(text, index, count, debug);

            var volume = text.Value.Length;

            var total = (index + count);

            var difference = (volume - total);

            var sub_START = String.Empty.PadRight(index);

            var sub_MIDDLE = text.Value.Substring(index, count);

            var sub_END = String.Empty.PadRight(difference);

            var text_BEFORE = text.Value;

            var text_AFTER = (sub_START + sub_MIDDLE + sub_END);

            var word = new STWord(text_BEFORE, text_AFTER, debug);

            this.Word = word;

            return;
        }

        ~STWordIsolate()
        {
            return;
        }
    }
}
