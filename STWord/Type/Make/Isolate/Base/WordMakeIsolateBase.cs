using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord MakeWordIsolateBase(SGText text, Int32 index, Int32 count, Boolean debug)
        {
            STWord wordResult = default;

            Debug_WordIsolateBase(text, index, count, debug);

            var volume_EXCLUSIVE_NORMALIZED_ORDINAL__NUMBER_INTEGER_BIT_32__thirty_two = text.Value.Length;

            var start_index_INCLUSIVE_NULLABLE_INDEXER__NUMBER_INTEGER_BIT_32__thirty_two = index;

            var count_counter_EXCLUSIVE_NORMALIZED_ORDINAL__NUMBER_INTEGER_BIT_32__thirty_two = count;

            var volume = volume_EXCLUSIVE_NORMALIZED_ORDINAL__NUMBER_INTEGER_BIT_32__thirty_two;

            var start = start_index_INCLUSIVE_NULLABLE_INDEXER__NUMBER_INTEGER_BIT_32__thirty_two;

            var length = count_counter_EXCLUSIVE_NORMALIZED_ORDINAL__NUMBER_INTEGER_BIT_32__thirty_two;

            var total = (start + length);

            var difference = (volume - total);

            var sub_START = String.Empty.PadRight(start);

            var sub_MIDDLE = text.Value.Substring(start, length);

            var sub_END = String.Empty.PadRight(difference);

            var text_BEFORE = text.Value;

            var text_AFTER = (sub_START + sub_MIDDLE + sub_END);

            wordResult = new STWord(text_BEFORE, text_AFTER, debug);

            return wordResult;
        }
    }
}
