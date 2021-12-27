using System;
using System.Collections.Generic;
using System.Text;

namespace DBMS.src
{
    public static class TypesValidator
    {
        public static bool IsValidValue(string customTypeName, string value)
        {
            switch (customTypeName)
            {
                case "Integer":
                    return ValidateInteger(value);

                case "Real":
                    return ValidateReal(value);
                
                case "Char":
                    return ValidateChar(value);

                case "String":
                    return ValidateString(value);

                case "Time":
                    return ValidateTime(value);

                case "TimeInvl":
                    return ValidateTimeInvl(value);

                default:
                    return false;
            }
        }

        private static bool ValidateChar(string value)
        {
            char buf;
            if (char.TryParse(value, out buf))
            {
                return true;
            }
            return false;
        }

        private static bool ValidateInteger(string value)
        {
            int buf;
            if (int.TryParse(value, out buf))
            {
                return true;
            }
            return false;
        }

        private static bool ValidateReal(string value)
        {
            double buf;
            if (double.TryParse(value, out buf))
            {
                return true;
            }
            return false;
        }


        private static bool ValidateString(string value)
        {
            return true;
        }

        private static bool ValidateTimeInvl(string value)
        {
            var sidesOfInterval = value.Split("-");
            if (sidesOfInterval.Length != 2)
            {
                return false;
            }
            if (!ValidateTime(sidesOfInterval[0]) || !ValidateTime(sidesOfInterval[1]))
            {
                return false;
            }
            return true;
        }

        private static bool ValidateTime(string value)
        {
            var sidesOfInterval = value.Split(":");
            if (sidesOfInterval.Length != 3)
            {
                return false;
            }
            long hours;
            long minutes;
            long seconds;
            if (!long.TryParse(sidesOfInterval[0], out hours) ||
                !long.TryParse(sidesOfInterval[1], out minutes) ||
                !long.TryParse(sidesOfInterval[2], out seconds))
            {
                return false;
            }
            if (hours < 0 ||
                minutes > 59 || minutes < 0 ||
                seconds > 59 || seconds < 0)
            {
                return false;
            }

            return true;
        }
    }
}
