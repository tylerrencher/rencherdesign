using RencherDesign.Domain;

namespace RencherDesign.Services
{
    public class EstimatorService()
    {
        public ProjectProposal GenerateEstimate(ProjectOverview overview)
        {
            // Get climate data
            // Get solar data from pvwatts
            return new ProjectProposal(1, 1, 1, Feasibility.Recommended);
        }
    }
}
