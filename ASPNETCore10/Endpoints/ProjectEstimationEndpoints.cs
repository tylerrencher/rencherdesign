using RencherDesign.Domain;
using RencherDesign.Services;

namespace RencherDesign.Endpoints
{
    public static class ProjectEstimationEndpoints
    {
        public static void Map(WebApplication app)
        {
            app.MapPost(
                "/Estimation/",
                (ProjectOverview overview, EstimatorService estimator) =>
                    estimator.GenerateEstimate(overview)
            );
        }
    }
}
