using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MusicAnalysis
{
    static class TESTAREA
    {
        public static void TestMethod()
        {
            Stream fileStream = new FileStream(@"C:\Users\melde\Downloads\Lamb of God - Redneck.wav", FileMode.Open);
            BinaryReader binaryRead = new BinaryReader(fileStream);
            fileStream.Position = 0;

            byte[] chunkDescriptor = binaryRead.ReadBytes(4);

            binaryRead.Close();
            fileStream.Close();
        }
    }
}
