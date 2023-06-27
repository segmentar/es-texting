using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(STContainer) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(TokenList) + ' ' + ". . ." + ' ' + $"[{TokenList.Count}]",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(TokenImmutableList) + ' ' + ". . ." + ' ' + $"[{TokenImmutableList.Count}]",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(TokenList) + ':',
                String.Empty + String.Join('\n'.ToString(), TokenList),
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(TokenImmutableList) + ':',
                String.Empty + String.Join('\n'.ToString(), TokenImmutableList)
            });
        }
    }
}
