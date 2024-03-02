using AimRobot.Api;
using AimRobot.Api.plugin;
using ar_example_plugin;

namespace robot_kpm
{
    public class Class1 : PluginBase
    {

        public override string GetAuthor()
        {
            return "H4rry217";
        }

        public override string GetDescription()
        {
            return "这是一个示范插件，用于演示如何编写ARL插件";
        }

        public override string GetPluginName()
        {
            return "robot_kpm";
        }

        public override Version GetVersion()
        {
            return new Version(1, 0, 0);
        }

        public override void OnDisable()
        {

        }

        public override void OnEnable()
        {

        }

        public override void OnLoad()
        {
            Robot.GetInstance().GetPluginManager().RegisterListener(this, new LimitPlayerStatsPlugin());
        }

    }
}