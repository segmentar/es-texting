using Core;

namespace Core.Shared
{
    using System;

    public partial class STWordInsert : SAInterface.IWordSequence
    {
        public STWord Word { get; set; }

        public STWordInsert(SGSymbol symbol, Int32 index, Int32 count, SGText text, Boolean debug)
        {
            Debug(symbol, index, count, text, debug);

            var volume = text.Value.Length;

            var total = (index + count);

            var difference = (volume - total);

            var sub_START = text.Value.Substring(0, index);

            var sub_MIDDLE = symbol.Value.Substring(0, count);

            var sub_END = text.Value.Substring(total, difference);

            var text_BEFORE = text.Value;

            var text_AFTER = (sub_START + sub_MIDDLE + sub_END);

            var word = new STWord(text_BEFORE, text_AFTER, debug);

            this.Word = word;

            return;
        }

        ~STWordInsert()
        {
            return;
        }
    }
}
