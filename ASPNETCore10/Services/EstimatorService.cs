using RencherDesign.Domain;

namespace RencherDesign.Services
{
    public class EstimatorService()
    {
        public ProjectProposal GenerateEstimate(ProjectOverview overview)
        {
            return new ProjectProposal(1, 1, 1, Feasibility.Recommended);
        }
    }
}
