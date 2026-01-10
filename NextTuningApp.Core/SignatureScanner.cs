using System.IO;

namespace NextTuningApp.Core;

internal static class SignatureScanner
{
    public static bool TryFind(Stream s, byte[] sig, out long offset)
    {
        offset = -1;
        const int bufSize = 1024 * 1024;
        byte[] buffer = new byte[bufSize];
        byte[] overlap = new byte[sig.Length - 1];

        long pos = 0;
        int overlapLen = 0;
        s.Position = 0;

        while (true)
        {
            if (overlapLen > 0)
            {
                overlap.CopyTo(buffer, 0);
            }

            int read = s.Read(buffer, overlapLen, bufSize - overlapLen);
            if (read == 0)
            {
                break;
            }

            int total = overlapLen + read;

            for (int i = 0; i <= total - sig.Length; i++)
            {
                bool match = true;
                for (int j = 0; j < sig.Length; j++)
                {
                    if (buffer[i + j] != sig[j])
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                {
                    offset = pos - overlapLen + i;
                    return true;
                }
            }

            overlapLen = sig.Length - 1;
            Array.Copy(buffer, total - overlapLen, overlap, 0, overlapLen);
            pos += read;
        }

        return false;
    }
}
