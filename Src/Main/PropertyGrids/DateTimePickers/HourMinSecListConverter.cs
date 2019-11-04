using System.ComponentModel;

namespace USC.GISResearchLab.Common.Forms.PropertyGrids.DateTimePickers
{
    /// <summary>
    /// Summary description for InputTypeList.
    /// </summary>
    public class HourMinSecListConverter : StringConverter
    {
        public HourMinSecListConverter()
        {
        }

        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            string[] values = new string[4];
            values[0] = "Hours";
            values[1] = "Minutes";
            values[2] = "Seconds";
            values[3] = "Milliseconds";

            return new StandardValuesCollection(values);
        }
    }
}
