﻿using Core;

namespace Core.Shared
{
    using System;

    public partial class STSearchSequenceBackwardPrimarySecondary
    {
        public static void Debug(Int32 size, Int32 volume, Int32 primary, Int32 secondary, Boolean next, Boolean debug)
        {
            goto descriptor;

            descriptor:
            {
                if (debug is true)
                {
                    var message = String.Join('\n'.ToString(), new String[] {
                        String.Empty + nameof(STSearch) + ' ' + "::" + ' ' + nameof(STSearchSequenceBackwardPrimarySecondary) + ' ' + '{',
                        String.Empty + '.' + "debug",
                        String.Empty + '\t' + '~' + "01" + ' ' + nameof(size) + ':' + ' ' + size,
                        String.Empty + '\t' + '~' + "02" + ' ' + nameof(volume) + ':' + ' ' + volume,
                        String.Empty + '\t' + '~' + "03" + ' ' + nameof(primary) + ':' + ' ' + primary,
                        String.Empty + '\t' + '~' + "04" + ' ' + nameof(secondary) + ':' + ' ' + secondary,
                        String.Empty + '\t' + '~' + "05" + ' ' + nameof(next) + ':' + ' ' + next,
                        String.Empty + '\t' + '~' + "06" + ' ' + nameof(debug) + ':' + ' ' + debug,
                        String.Empty + '}'
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
