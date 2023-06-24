using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord MakeWordReplaceBase(SGDelimiter delimiter, SGSymbol symbol, Int32 index, Int32 count, SGText text, Boolean debug)
        {
            STWord wordResult = default;

            Debug_WordReplaceBase(delimiter, text, index, count, debug);

            var volume_EXCLUSIVE_NORMALIZED_ORDINAL__NUMBER_INTEGER_BIT_32__thirty_two = text.Value.Length;

            var start_index_INCLUSIVE_NULLABLE_INDEXER__NUMBER_INTEGER_BIT_32__thirty_two = index;

            var count_counter_EXCLUSIVE_NORMALIZED_ORDINAL__NUMBER_INTEGER_BIT_32__thirty_two = count;

            var volume = volume_EXCLUSIVE_NORMALIZED_ORDINAL__NUMBER_INTEGER_BIT_32__thirty_two;

            var start = start_index_INCLUSIVE_NULLABLE_INDEXER__NUMBER_INTEGER_BIT_32__thirty_two;

            var length = count_counter_EXCLUSIVE_NORMALIZED_ORDINAL__NUMBER_INTEGER_BIT_32__thirty_two;

            var total = (start + length);

            var difference = (volume - total);

            var sub_START = text.Value.Substring(0, start);

            var sub_MIDDLE = text.Value.Substring(start, length);

            var sub_END = text.Value.Substring(total, difference);

            var formatted = sub_MIDDLE;

            foreach (SGSymbol symbol_DELIMITER in delimiter.DelimiterList)
            {
                formatted = formatted.Replace(symbol_DELIMITER.Value, symbol.Value);

                continue;
            }

            var text_BEFORE = text.Value;

            var text_AFTER = (sub_START + formatted + sub_END);

            wordResult = new STWord(text_BEFORE, text_AFTER, debug);

            return wordResult;
        }
    }
}
