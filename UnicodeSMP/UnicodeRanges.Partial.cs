using System.Runtime.CompilerServices;
using System.Threading;

namespace UnicodeSMP
{
    public static partial class UnicodeRanges
    {
        [MethodImpl(MethodImplOptions.NoInlining)] // the caller should be inlined, not this method
        private static UnicodeRangeExtended CreateRange(ref UnicodeRangeExtended? range, int first, int last)
        {
            return CreateRange(ref range, (char) first, (char) last);
        }

        [MethodImpl(MethodImplOptions.NoInlining)] // the caller should be inlined, not this method
        private static UnicodeRangeExtended CreateRange(ref UnicodeRangeExtended? range, char first, char last)
        {
            // It's ok if two threads race and one overwrites the other's 'range' value.
            Volatile.Write(ref range, new UnicodeRangeExtended(first, last - first + 1));

#pragma warning disable 8777
            return range!;
#pragma warning restore 8777
        }
    }
}