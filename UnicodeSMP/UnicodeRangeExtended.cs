using System;

namespace UnicodeSMP
{
    public class UnicodeRangeExtended
    {
        public const int LastCharacter = 0x0F_FFFF;

        public UnicodeRangeExtended(int firstCodePoint, int length)
        {
            if ((firstCodePoint < 0) || (firstCodePoint > LastCharacter))
                throw new ArgumentOutOfRangeException(nameof(firstCodePoint));
            this.FirstCodePoint = ((length >= 0) && (firstCodePoint + length <= LastCharacter))
                ? firstCodePoint
                : throw new ArgumentOutOfRangeException(nameof(length));
            this.Length = length;
            LastCodePoint = firstCodePoint + length - 1;
        }

        /// <summary>Gets the first code point in the range represented by this <see cref="T:System.Text.Unicode.UnicodeRange" /> instance.</summary>
        /// <returns>The first code point in the range.</returns>
        public int FirstCodePoint { get; }

        /// <summary>Gets the number of code points in the range represented by this <see cref="T:System.Text.Unicode.UnicodeRange" /> instance.</summary>
        /// <returns>The number of code points in the range.</returns>
        public int Length { get; }

        public int LastCodePoint { get; }
    }
}