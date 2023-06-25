using Core;

namespace Core.Shared
{
    using System;

    public partial class STWordRemove : SAInterface.IWordSequence
    {
        public STWord Word { get; set; }

        public STWordRemove(SGText text, Int32 index, Int32 count, Boolean debug)
        {
            Debug(text, index, count, debug);

            var volume = text.Value.Length;

            var total = (index + count);

            var difference = (volume - total);

            var sub_START = text.Value.Substring(0, index);

            var sub_MIDDLE = String.Empty.PadRight(count);

            var sub_END = text.Value.Substring(total, difference);

            var text_BEFORE = text.Value;

            var text_AFTER = (sub_START + sub_MIDDLE + sub_END);

            this.Word = new STWord(text_BEFORE, text_AFTER, debug);

            return;
        }

        ~STWordRemove()
        {
            return;
        }
    }
}
