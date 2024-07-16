using AutomationTool;
using Gauntlet;

namespace TestScript.Automation
{
	public class WinnerTeamTest : UnrealTestNode<UnrealTestConfiguration>
	{
		public WinnerTeamTest(UnrealTestContext InContext)
			: base(InContext)
		{
		}

		private String ControllerName = "WinnerTeamController";

		public override UnrealTestConfiguration GetConfiguration()
		{
			UnrealTestConfiguration Config = base.GetConfiguration();

			// Get a single client
			UnrealTestRole ClientRole = Config.RequireRole(UnrealTargetRole.Client);

			// Adding custom controller in charge of puppetering the game to test a particular outcome
			ClientRole.Controllers.Add(ControllerName);

			// Maximum timeout time for the test to run
			Config.MaxDuration = 300;

			return Config;
		}
	}
}
