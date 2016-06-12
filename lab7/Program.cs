using System;
using System.Xml;
using System.Xml.Serialization;

namespace lab7
{
    static class Program
    {
        static void Main(string[] args)
        {
            TestSerialize();
            TestDeserialize();
        }

        static void TestSerialize()
        {
            Hangar hangar = new Hangar();

            hangar.Tanks.AddRange(new[]
            {
                new Tank("Т-34", 28, 56, 480, 57),
                new Tank("Иосиф Сталин", 45, 34, 600, 122),
                new Tank("Panther", 44.45, 55, 650, 75),
                new Tank("Tiger", 55.5, 40, 650, 88)
            });

            var xmlSerializer = new XmlSerializer(typeof(Hangar));

            using (var xmlWriter = XmlWriter.Create("MyTanks.xml"))
                xmlSerializer.Serialize(xmlWriter, hangar);

            Console.WriteLine("Сериализация завершена");
        }

        static void TestDeserialize()
        {
            Hangar hangar;

            var xmlSerializer = new XmlSerializer(typeof(Hangar));

            using (var xmlReader = XmlReader.Create("MyTanks.xml"))
                hangar = (Hangar)xmlSerializer.Deserialize(xmlReader);

            Console.WriteLine("Десериализация завершена:\n");
            Console.WriteLine(string.Join("\n\n", hangar.Tanks));
        }
    }
}
