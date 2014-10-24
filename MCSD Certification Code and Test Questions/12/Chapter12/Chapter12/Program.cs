using EncryptionSamples.Asymmetric;
using EncryptionSamples.Hashing;
using EncryptionSamples.ProtectingData;
using EncryptionSamples.Symmetric;

namespace EncryptionSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            TripleDESSample.Run();
            AesManagedSample.Run();
            RSASample.Run();
            SHASample.Run();
            ProtectDataSample.Run();

        }
    }
}
