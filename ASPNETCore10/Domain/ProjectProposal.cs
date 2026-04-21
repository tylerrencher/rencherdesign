namespace RencherDesign.Domain
{
    public struct ProjectProposal(
        int kwSolar,
        int kwBattery,
        int costEstimate,
        Feasibility feasibility
    )
    {
        public int KWSolar { get; } = kwSolar;
        public int KWBattery { get; } = kwBattery;
        public int CostEstimate { get; } = costEstimate;
        public Feasibility Feasibility { get; } = feasibility;
    }

    public enum Feasibility : int
    {
        TooExpensive = 1,
        Possible = 2,
        Recommended = 3,
    }
}
