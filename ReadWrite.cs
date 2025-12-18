using System;
using System.IO;

namespace NEXT_Tuning_App
{
    public partial class MainForm : Form
    {
        #region Read/Write Data

        private byte ReadByte(long offset)
        {
            fs!.Position = offset;
            return (byte)fs.ReadByte();
        }

        private void WriteByte(long offset, byte value)
        {
            fs!.Position = offset;
            fs.WriteByte(value);
            fs.Flush();
        }

        private sbyte ReadSByte(long offset)
        {
            fs!.Position = offset;
            int b = fs.ReadByte();
            if (b < 0) throw new EndOfStreamException("Unexpected EOF reading SByte.");
            return unchecked((sbyte)b);
        }

        private void WriteSByte(long offset, sbyte value)
        {
            fs!.Position = offset;
            fs.WriteByte(unchecked((byte)value));
            fs.Flush();
        }

        private ushort ReadUInt16LE(long offset)
        {
            fs!.Position = offset;
            int b0 = fs.ReadByte();
            int b1 = fs.ReadByte();
            if (b0 < 0 || b1 < 0) throw new EndOfStreamException("Unexpected EOF reading UInt16.");
            return (ushort)(b0 | (b1 << 8));
        }

        private void WriteUInt16LE(long offset, ushort value)
        {
            fs!.Position = offset;
            fs.WriteByte((byte)(value & 0xFF));        // low
            fs.WriteByte((byte)((value >> 8) & 0xFF)); // high
        }

        /// <summary>
        /// Reads a 32-bit float stored as 16-bit word-swapped: [hiWordLE][loWordLE]
        /// where float bits = (hiWord << 16) | loWord.
        /// </summary>
        private float ReadFloatWordSwapped(long offset)
        {
            ushort hi = ReadUInt16LE(offset);
            ushort lo = ReadUInt16LE(offset + 4);
            uint bits = ((uint)hi << 16) | lo;
            return BitConverter.Int32BitsToSingle((int)bits);
        }

        private void WriteFloatWordSwapped(long offset, float value)
        {
            uint bits = (uint)BitConverter.SingleToInt32Bits(value);
            ushort hi = (ushort)(bits >> 16);
            ushort lo = (ushort)(bits & 0xFFFF);

            WriteUInt16LE(offset, hi);
            WriteUInt16LE(offset + 4, lo);
        }

        /// <summary>
        /// Reads a float where only the high 16 bits are stored (JV case).
        /// low word assumed 0x0000.
        /// </summary>
        private float ReadFloatHighWordOnly(long offset)
        {
            ushort hi = ReadUInt16LE(offset);
            uint bits = ((uint)hi << 16); // lo = 0
            return BitConverter.Int32BitsToSingle((int)bits);
        }

        private void WriteFloatHighWordOnly(long offset, float value)
        {
            uint bits = (uint)BitConverter.SingleToInt32Bits(value);
            ushort hi = (ushort)(bits >> 16);
            WriteUInt16LE(offset, hi);
        }

        #endregion


    }
}