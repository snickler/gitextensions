using System;
using System.Drawing;
using System.Globalization;

namespace GitUIPluginInterfaces
{
    public static class FontParser
    {

        private static readonly string InvariantCultureId = "_IC_";
        public static string AsString(this Font value)
        {
            return String.Format(CultureInfo.InvariantCulture,
                "{0};{1};{2}", value.FontFamily.Name, value.Size, InvariantCultureId);
        }

        public static Font Parse(this string value, Font defaultValue)
        {
            if (value == null)
                return defaultValue;

            string[] parts = value.Split(';');

            if (parts.Length < 2)
                return defaultValue;

            try
            {
                string fontSize;
                if (parts.Length == 3 && InvariantCultureId.Equals(parts[2]))
                    fontSize = parts[1];
                else
                {
                    fontSize = parts[1].Replace(",", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator);
                    fontSize = fontSize.Replace(".", CultureInfo.InvariantCulture.NumberFormat.NumberDecimalSeparator);
                }

                return new Font(parts[0], Single.Parse(fontSize, CultureInfo.InvariantCulture));
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }
    }
}