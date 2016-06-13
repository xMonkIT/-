using System;

namespace lab10.Domain
{
    public enum WindDirection
    {
        N, NW, W, SW, S, SE, E, NE
    }

    public static class WindDirectionExtensions
    {
        public static string GetNameOfDirection(this WindDirection direction)
        {
            switch (direction)
            {
                case WindDirection.N:
                    return "северный";
                case WindDirection.NW:
                    return "северо-западный";
                case WindDirection.W:
                    return "западный";
                case WindDirection.SW:
                    return "юго-западный";
                case WindDirection.S:
                    return "южный";
                case WindDirection.SE:
                    return "юго-восточный";
                case WindDirection.E:
                    return "восточный";
                case WindDirection.NE:
                    return "северо-восточный";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}