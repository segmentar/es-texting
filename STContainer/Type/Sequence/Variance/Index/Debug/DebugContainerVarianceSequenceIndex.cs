﻿using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainerVarianceSequenceIndex
    {
        public static void Debug(SGDelimiter delimiter, Int32 rebase, Int32 index, Boolean backward, SGText text, Boolean debug)
        {
            goto descriptor;

            descriptor:
            {
                var message = String.Join('\n'.ToString(), new String[] {
                    String.Empty + nameof(STContainer) + ' ' + "::" + ' ' + nameof(STContainerVarianceSequenceIndex) + ' ' + '{',
                    String.Empty + '.' + "debug",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(delimiter) + ':' + ' ' + ". . .",
                    String.Empty + '\t' + '~' + "02" + ' ' + nameof(rebase) + ':' + ' ' + rebase,
                    String.Empty + '\t' + '~' + "03" + ' ' + nameof(index) + ':' + ' ' + index,
                    String.Empty + '\t' + '~' + "04" + ' ' + nameof(backward) + ':' + ' ' + backward,
                    String.Empty + '\t' + '~' + "05" + ' ' + nameof(text) + ':' + ' ' + ". . .", 
                    String.Empty + '\t' + '~' + "06" + ' ' + nameof(debug) + ':' + ' ' + debug,
                    String.Empty + '}',
                    String.Empty,
                    String.Empty + '~' + "10 " + nameof(delimiter) + ':',
                    String.Empty + delimiter,
                    String.Empty,
                    String.Empty + '~' + "20" + nameof(text) + ':',
                    String.Empty + text
                });

                SLLogger.Runtime_MakeLoggerNew(message);
            }

            return;
        }
    }
}