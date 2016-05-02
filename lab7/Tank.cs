using System.Xml.Serialization;

namespace lab7
{
    [XmlType("Tank")]
    public class Tank
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double MaxSpeed { get; set; }
        public int Horses { get; set; }
        public double GunCaliber { get; set; }

        // конструктор без параметров необходим для сериализации!
        public Tank()
        {

        }

        public Tank(string name, double weight, double maxSpeed, int horses, double gunCaliber)
        {
            Name = name;
            Weight = weight;
            MaxSpeed = maxSpeed;
            Horses = horses;
            GunCaliber = gunCaliber;
        }

        public double HorsesPerTonn()
        {
            return Horses / Weight;
        }

        public override string ToString() =>
            $"Танк:          {Name}\n" +
            $"Вес:           {Weight:##.###} тонн\n" +
            $"Скорость:      {MaxSpeed:##.###} км/ч\n" +
            $"Мощность:      {Horses} лошадинных сил\n" +
            $"Калибр орудия: {GunCaliber:##.###} мм";
    }
}
