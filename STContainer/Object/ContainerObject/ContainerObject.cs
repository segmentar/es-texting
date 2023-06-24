using Core;

namespace Core.Shared
{
    using System;

    public partial class STContainer
    {
        public override String ToString()
        {
            var solid_TOKEN__LIST = String.Empty;

            foreach(STToken token in TokenList)
            {
                solid_TOKEN__LIST = solid_TOKEN__LIST + $"> [{token.Symbol.Value}] [{token.Position}] [{token.Quantity}] [{token.Found}] [{token.IsDebug}]";

                solid_TOKEN__LIST = solid_TOKEN__LIST + '\n';

                continue;
            }

            SolidTokenList = SGSymbol.Runtime_MakeSymbolNew(solid_TOKEN__LIST);

            return String.Join('\n'.ToString(), new String[] {
                String.Empty + nameof(STContainer) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(TokenList) + ' ' + ". . ." + ' ' + $"[{TokenList.Count}]",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(SolidTokenList) + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(TokenList) + ':',
                String.Empty + String.Join('\n'.ToString(), TokenList),
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(SolidTokenList) + ':',
                String.Empty + SolidTokenList.Value
            });
        }
    }
}
