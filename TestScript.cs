using AutomationTool;

namespace TestScript.Automation
{
	// Use [Help()] attributes to document your command and its arguments.
	[Help("Sample script printing the first N terms of the Fibonacci sequence.")]
	[Help("Usage: SampleScript -Terms=<N>")]
	[Help("Terms=<N>", "N (int) the number of terms to compute. Must be greater than or equal to 1.")]

	// BuildCommand is the base class for all commands.
	public class SampleCommand : BuildCommand
	{
		public override void ExecuteBuild()
		{
			// The ParseParamInt() method retrieves a command line argument for this example.
			// ParseParam() retrieves a bool, and ParseParamValue() retrieves a string.
			int NumTerms = ParseParamInt("Terms");
			if (NumTerms < 1)
			{
				throw new ArgumentException("Invalid number of terms specified. Enter -help for syntax.");
			}
			else
			{
				LogInformation("Fibonacci sequence:");

				int TermA = 1;
				int TermB = 1;

				for (int i = 0; i < NumTerms; i++)
				{
					LogInformation(" {0}", TermA);

					int TermC = TermA + TermB;
					TermA = TermB;
					TermB = TermC;
				}
			}
		}
	}
}
