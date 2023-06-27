using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainerTerminatorSequenceDefault
    {
        public static void Debug(SGDelimiter delimiter_VALUE, SGDelimiter delimiter_TERMINATOR, Boolean _front_back_, Int32 rebase, Boolean backward, SGText text, Boolean debug)
        {
            goto descriptor;

            descriptor:
            {
                var message = String.Join('\n'.ToString(), new String[] {
                    String.Empty + nameof(STContainer) + ' ' + "::" + ' ' + nameof(STContainerTerminatorSequenceDefault) + ' ' + '{',
                    String.Empty + '.' + "debug",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(delimiter_VALUE) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "02" + ' ' + nameof(delimiter_TERMINATOR) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "03" + ' ' + nameof(_front_back_) + ':' + ' ' + _front_back_,
                    String.Empty + '\t' + '~' + "04" + ' ' + nameof(rebase) + ':' + ' ' + rebase,
                    String.Empty + '\t' + '~' + "05" + ' ' + nameof(backward) + ':' + ' ' + backward,
                    String.Empty + '\t' + '~' + "06" + ' ' + nameof(text) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "07" + ' ' + nameof(debug) + ':' + ' ' + debug,
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10" + ' ' + nameof(delimiter_VALUE) + ':',
                    String.Empty + delimiter_VALUE,
                    String.Empty,
                    String.Empty + '~' + "20" + ' ' + nameof(delimiter_TERMINATOR) + ':',
                    String.Empty + delimiter_TERMINATOR,
                    String.Empty,
                    String.Empty + '~' + "30" + ' ' + nameof(text) + ':',
                    String.Empty + text
                });

                SLLogger.Runtime_MakeLoggerNew(message);
            }

            return;
        }
    }
}
