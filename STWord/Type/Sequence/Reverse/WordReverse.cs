using Core;

namespace Core.Shared
{
    using System;

    public partial class STWordReverse : SAInterface.IWordSequence
    {
        public STWord Word { get; set; }

        public STWordReverse(SGText text, Int32 index, Int32 count, Boolean debug)
        {
            Debug(text, index, count, debug);

            var volume = text.Value.Length;

            var total = (index + count);

            var difference = (volume - total);

            var sub_START = text.Value.Substring(0, index);

            var sub_MIDDLE = text.Value.Substring(index, count);

            var sub_END = text.Value.Substring(total, difference);

            goto align_REVERSE;

            align_REVERSE:
            {
                var align_REVERSE = sub_MIDDLE.ToCharArray();

                Array.Reverse(align_REVERSE);

                sub_MIDDLE = new String(align_REVERSE, 0, align_REVERSE.Length);
            }

            var text_BEFORE = text.Value;

            var text_AFTER = (sub_START + sub_MIDDLE + sub_END);

            var word = new STWord(text_BEFORE, text_AFTER, debug);

            this.Word = word;

            return;
        }

        ~STWordReverse()
        {
            return;
        }
    }
}
