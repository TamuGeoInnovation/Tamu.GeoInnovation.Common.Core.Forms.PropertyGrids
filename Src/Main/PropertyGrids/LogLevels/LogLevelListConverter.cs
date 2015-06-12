using System.ComponentModel;

namespace USC.GISResearchLab.Common.Forms.PropertyGrids.LogLevels
{
	/// <summary>
	/// Summary description for LogLevelList.
	/// </summary>
	public class LogLevelListConverter : Int32Converter
	{
        public LogLevelListConverter()
		{
		}

		public override bool GetStandardValuesSupported( ITypeDescriptorContext context) 
		{ 
			return true; 
		}

		public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context) 
		{
            return new StandardValuesCollection(USC.GISResearchLab.Common.Logs.LogLevels.Levels); 
		}
	}
}
