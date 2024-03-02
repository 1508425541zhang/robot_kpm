using AimRobot.Api;
using AimRobot.Api.events;
using AimRobot.Api.game;
namespace ar_example_plugin
{
    public class LimitPlayerStatsPlugin : IEventListener
    {
        private const double MAX_KPM = 1.0;  // 允许的每分钟最大击杀数
        private const int MAX_RANK = 10;     // 所需的最GAO等级
        private const int MAX_KILLS = 100;   // 允许的最大击杀数
        [AimRobot.Api.events.EventHandler]
        public void OnPlayerStatsReceived(PlayerStatInfo playerStats)
        {

            // 检查玩家状态是否超出限制
            if (playerStats.killsPerMinute > MAX_KPM || playerStats.rank < MAX_RANK || playerStats.kills > MAX_KILLS)
            {
                string message = "你已经超出kpm或击杀限制";
                Robot.GetInstance().SendChat(message);
                Robot.GetInstance().BanPlayer(playerStats.id);

            }
        }
    }
}