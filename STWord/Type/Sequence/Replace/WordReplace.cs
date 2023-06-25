using Core;

namespace Core.Shared
{
    using System;

    public partial class STWordReplace : SAInterface.IWordSequence
    {
        public STWord Word { get; set; }

        public STWordReplace(SGDelimiter delimiter, SGSymbol symbol, Int32 index, Int32 count, SGText text, Boolean debug)
        {
            Debug(delimiter, text, index, count, debug);

            var volume = text.Value.Length;

            var total = (index + count);

            var difference = (volume - total);

            var sub_START = text.Value.Substring(0, index);

            var sub_MIDDLE = text.Value.Substring(index, count);

            var sub_END = text.Value.Substring(total, difference);

            goto align_FORMAT;

            align_FORMAT:
            {
                var sub_MIDDLE__ALIGN_FORMAT = sub_MIDDLE;

                foreach (SGSymbol symbol_DELIMITER in delimiter.DelimiterList)
                {
                    sub_MIDDLE__ALIGN_FORMAT = sub_MIDDLE__ALIGN_FORMAT.Replace(symbol_DELIMITER.Value, symbol.Value);

                    continue;
                }

                sub_MIDDLE = sub_MIDDLE__ALIGN_FORMAT;
            }

            var text_BEFORE = text.Value;

            var text_AFTER = (sub_START + sub_MIDDLE + sub_END);

            var word = new STWord(text_BEFORE, text_AFTER, debug);

            this.Word = word;

            return;
        }

        ~STWordReplace()
        {
            return;
        }
    }
}
