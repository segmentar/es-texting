using Core;

namespace Core.Shared
{
    using System;

    public partial class STQuerySequenceBackwardIndexerIndexer
    {
        public static void Debug(SGSymbol symbol, Int32 indexer_START, Int32 indexer_END, Boolean next, SGText text, Boolean debug)
        {
            goto descriptor;

            descriptor:
            {
                if (debug is true)
                {
                    var message = String.Join('\n'.ToString(), new String[] {
                        String.Empty + nameof(STQuery) + ' ' + "::" + ' ' + nameof(STQuerySequenceBackwardIndexerIndexer) + ' ' + '{',
                        String.Empty + '.' + "debug",
                        String.Empty + '\t' + '~' + "01" + ' ' + nameof(symbol) + ':' + ' ' + ". . .",
                        String.Empty + '\t' + '~' + "02" + ' ' + nameof(indexer_START) + ':' + ' ' + indexer_START,
                        String.Empty + '\t' + '~' + "03" + ' ' + nameof(indexer_END) + ':' + ' ' + indexer_END,
                        String.Empty + '\t' + '~' + "04" + ' ' + nameof(next) + ':' + ' ' + next,
                        String.Empty + '\t' + '~' + "05" + ' ' + nameof(text) + ':' + ' ' + ". . .",
                        String.Empty + '\t' + '~' + "06" + ' ' + nameof(debug) + ':' + ' ' + debug,
                        String.Empty + '}',
                        String.Empty,
                        String.Empty + '~' + "10 " + ' ' + nameof(symbol) + ':',
                        String.Empty + symbol,
                        String.Empty,
                        String.Empty + '~' + "20" + ' ' + nameof(text) + ':',
                        String.Empty + text
                    });

                    SLLogger.Runtime_MakeLoggerNew(message);
                }
                else
                    "false".ToString();
            }

            return;
        }
    }
}
