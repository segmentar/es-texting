﻿using Core;

namespace Core.Shared
{
    using System;

    public partial class STWord
    {
        public static STWord MakeWordIsolatePrimarySecondary(SGText text, Int32 primary, Int32 secondary, Boolean debug)
        {
            STWord wordResult = default;

            var search = STSearch.MakeSearchForwardPrimarySecondary(SAConstantVoid.SearchSizeDefault, text.Value.Length, primary, secondary, SAConstantDisagreement.SearchNextDefault, debug);

            var start = search.Index;

            var length = search.Count;

            Info_WordIsolatePrimarySecondary(search, start, length, debug);

            wordResult = MakeWordIsolateIndexCount(text, start, length, debug);

            return wordResult;
        }
    }
}