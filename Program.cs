using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace Serialization_Deserialization {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Data");

            Mobile mobile = new Mobile(17, 10, "Mobile", 54);
            PC pc = new PC(17, 15, "PC", 17.7);

            OutputObject(mobile);
            OutputObject(pc);


            Console.WriteLine("\n Serialization ");

            byte[] mobileByte = Serialize(mobile);
            byte[] pcByte = Serialize(pc);

            Console.WriteLine("Mobile: ");
            OutputByte(mobileByte);

            Console.WriteLine("PC: ");
            OutputByte(pcByte);


            Console.WriteLine("\n Deserialization");

            Game sameMobile = Deserialize(mobileByte);
            Game samePC = Deserialize(pcByte);

            OutputObject(sameMobile);
            OutputObject(samePC);
        }

        static byte[] Serialize(Object _game) {
            BinaryFormatter bf = new BinaryFormatter();
            using (var ms = new MemoryStream()) {
                bf.Serialize(ms, _game);
                return ms.ToArray();
            }
        }

        static Game Deserialize(byte[] _byteGame) {
            using (var memStream = new MemoryStream()) {
                var binForm = new BinaryFormatter();
                memStream.Write(_byteGame, 0, _byteGame.Length);
                memStream.Seek(0, SeekOrigin.Begin);

                var obj = binForm.Deserialize(memStream);
                return (Game)obj;
            }
        }

        static void OutputObject(Game _game) {
            _game.Run();
        }

        static void OutputByte(byte[] _gameByte) {
            Console.WriteLine("new byte[] { " + string.Join(", ", _gameByte) + " }");
        }
    }
}
