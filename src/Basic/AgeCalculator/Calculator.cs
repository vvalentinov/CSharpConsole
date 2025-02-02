namespace AgeCalculator
{
    public static class Calculator
    {
        public static int CalcUserYears(DateTime date)
        {
            DateTime now = DateTime.Now;

            int years = now.Year - date.Year;

            if (now.Month < date.Month || (now.Month == date.Month && now.Day < date.Day))
            {
                years--;
            }

            return years;
        }

        public static int CalcUserMonths(DateTime date)
        {
            DateTime now = DateTime.Now;

            int months = (now.Year - date.Year) * 12 + (now.Month - date.Month);

            if (now.Day < date.Day)
            {
                months--;
            }

            return months;
        }

        public static int CalcUserDays(DateTime date) => (int)(DateTime.Now - date).TotalDays;

        public static int CalcUserHours(DateTime date) => (int)(DateTime.Now - date).TotalHours;

        public static int CalcUserMinutes(DateTime date) => (int)(DateTime.Now - date).TotalMinutes;

    }
}
