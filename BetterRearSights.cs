using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;
using SPTarkov.Server.Core.Models.Logging;
using SPTarkov.Server.Core.Utils.Logger;

namespace SPTBetterRearSights
{
    [Injectable(InjectionType.Singleton, TypePriority = OnLoadOrder.PostDBModLoader)]
    public class BetterRearSights(SptLogger<BetterRearSights> logger) : IOnLoad
    {
        public Task OnLoad()
        {
            logger.LogWithColor("Successfully loaded Better Rear Sights! Good luck!", LogTextColor.Cyan);
            return Task.CompletedTask;
        }
    }
}
