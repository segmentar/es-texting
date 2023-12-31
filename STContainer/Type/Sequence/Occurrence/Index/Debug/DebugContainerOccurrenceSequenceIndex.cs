﻿using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainerOccurrenceSequenceIndex
    {
        public static void Debug(SGSymbol symbol, Int32 rebase, Int32 index, Boolean backward, SGText text, Boolean debug)
        {
            goto descriptor;

            descriptor:
            {
                var message = String.Join('\n'.ToString(), new String[] {
                    String.Empty + nameof(STContainer) + ' ' + "::" + ' ' + nameof(STContainerOccurrenceSequenceIndex) + ' ' + '{',
                    String.Empty + '.' + "debug",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(symbol) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "02" + ' ' + nameof(rebase) + ':' + ' ' + rebase,
                    String.Empty + '\t' + '~' + "03" + ' ' + nameof(index) + ':' + ' ' + index,
                    String.Empty + '\t' + '~' + "04" + ' ' + nameof(backward) + ':' + ' ' + backward,
                    String.Empty + '\t' + '~' + "05" + ' ' + nameof(text) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "06" + ' ' + nameof(debug) + ':' + ' ' + debug,
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(symbol) + ':',
                    String.Empty + symbol,
                    String.Empty,
                    String.Empty + '~' + "20" + ' ' + nameof(text) + ':',
                    String.Empty + text
                });

                SLLogger.Runtime_MakeLoggerNew(message);
            }

            return;
        }
    }
}
