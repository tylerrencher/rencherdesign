namespace RencherDesign.Domain
{
    public struct ProjectOverview(
        double latitude,
        double longitude,
        int sqft,
        Complexity complexity,
        bool basement,
        int stories,
        Insulation insulation,
        Tightness tightness,
        int roofPitch,
        int occupants
    )
    {
        public double Latitude { get; } = latitude;
        public double Longitude { get; } = longitude;
        public int Sqft { get; } = sqft;
        public Complexity Complexity { get; } = complexity;
        public bool Basement { get; } = basement;
        public int Stories { get; } = stories;
        public Insulation Insulation { get; } = insulation;
        public Tightness Tightness { get; } = tightness;
        public int RoofPitch { get; } = roofPitch;
        public int Occupants { get; } = occupants;
    }

    public enum Tightness : int
    {
        HighPerformance = 1,
        Standard = 5,
        Loose = 10,
    }

    public enum Complexity : int
    {
        Low = 1,
        Standard = 2,
        High = 3,
    }

    public enum Insulation : int
    {
        BelowAverage = 1,
        Average = 2,
        AboveAverage = 3,
    }
}
