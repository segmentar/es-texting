using Core;

namespace Core.Shared
{
    using System;

    public partial class STQuerySequenceBackwardDefault
    {
        public static void Debug(SGSymbol symbol, Boolean next, SGText text, Boolean debug)
        {
            goto descriptor;

            descriptor:
            {
                if (debug is true)
                {
                    var message = String.Join('\n'.ToString(), new String[] {
                        String.Empty + nameof(STSearch) + ' ' + "::" + ' ' + nameof(STQuerySequenceForwardDefault) + ' ' + '{',
                        String.Empty + '.' + "debug",
                        String.Empty + '\t' + '~' + "01" + ' ' + nameof(symbol) + ':' + ' ' + symbol,
                        String.Empty + '\t' + '~' + "02" + ' ' + nameof(next) + ':' + ' ' + next,
                        String.Empty + '\t' + '~' + "03" + ' ' + nameof(text) + ':' + ' ' + text,
                        String.Empty + '\t' + '~' + "04" + ' ' + nameof(debug) + ':' + ' ' + debug,
                        String.Empty + '}',
                        String.Empty,
                        String.Empty + '~' + "10" + ' ' + nameof(text) + ':',
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
