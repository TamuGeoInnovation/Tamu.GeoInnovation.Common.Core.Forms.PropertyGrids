using System;
using System.ComponentModel;

namespace USC.GISResearchLab.Common.Forms.PropertyGrids.DateTimePickers
{
    /// <summary>
    /// Summary description for InputTypeList.
    /// </summary>
    public class TimeListConverter : StringConverter
    {
        public TimeListConverter()
        {
        }

        public override bool GetStandardValuesSupported(ITypeDescriptorContext context)
        {
            return true;
        }

        public override StandardValuesCollection GetStandardValues(ITypeDescriptorContext context)
        {
            string[] times = new string[48];
            DateTime dateTime = new DateTime(1, 1, 1, 0, 0, 0);
            for (int i = 0; i < 48; i++)
            {
                DateTime temp = dateTime.AddMinutes(i * 30);
                string s = temp.ToString("hh:mm:ss tt");
                times[i] = s;
            }

            return new StandardValuesCollection(times);
        }
    }
}
