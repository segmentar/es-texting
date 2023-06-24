using Core;

namespace Core.Shared
{
    using System;

    public partial class STSearchSequenceBackwardIndexCount
    {
        public static void Debug(Int32 size, Int32 volume, Int32 index, Int32 count, Boolean next, Boolean debug)
        {
            goto descriptor;

            descriptor:
            {
                if (debug is true)
                {
                    var message = String.Join('\n'.ToString(), new String[] {
                        String.Empty + nameof(STSearch) + ' ' + "::" + ' ' + nameof(STSearchSequenceBackwardIndexCount) + ' ' + '{',
                        String.Empty + '.' + "debug",
                        String.Empty + '\t' + '~' + "01" + ' ' + nameof(size) + ':' + ' ' + size,
                        String.Empty + '\t' + '~' + "02" + ' ' + nameof(volume) + ':' + ' ' + volume,
                        String.Empty + '\t' + '~' + "03" + ' ' + nameof(index) + ':' + ' ' + index,
                        String.Empty + '\t' + '~' + "04" + ' ' + nameof(count) + ':' + ' ' + count,
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
