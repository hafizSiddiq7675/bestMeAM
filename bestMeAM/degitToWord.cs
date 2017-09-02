using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bestMeAM
{
    class degitToWord
    {
        private string[] _smallNumbers = new string[]
    { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine",
      "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen",
      "Eighteen", "Nineteen"};

        private string[] _tens = new string[] { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        private string[] _scaleNumbers = new string[] { "", "Thousand", "Million", "Billion" };
        //Convert three digit to words
        private string ThreeDigitGroupToWords(int threeDigits)
        {
            // Initialise the return text
            string groupText = "";

            // Determine the hundreds and the remainder
            int hundreds = threeDigits / 100;
            int tensUnits = threeDigits % 100;

            // Hundreds rules
            if (hundreds != 0)
            {
                groupText += _smallNumbers[hundreds] + " Hundred";

                if (tensUnits != 0)
                {
                    groupText += " and ";
                }
            }
            // Determine the tens and units
            int tens = tensUnits / 10;
            int units = tensUnits % 10;

            // Tens rules
            if (tens >= 2)
            {
                groupText += _tens[tens];
                if (units != 0)
                {
                    groupText += " " + _smallNumbers[units];
                }
            }
            else if (tensUnits != 0)
                groupText += _smallNumbers[tensUnits];

            return groupText;
        }
        public string convertNumber(int number)
        {
            if (number == 0)
            {
                return _smallNumbers[0];
            }
            int[] digitGroups = new int[4];
            int positive = Math.Abs(number);//To take Positive Value
            for (int i = 0; i < 4; i++)
            {
                digitGroups[i] = positive % 1000;
                positive /= 1000;
            }
            string[] groupText = new string[4];

            for (int i = 0; i < 4; i++)
            {
                groupText[i] = ThreeDigitGroupToWords(digitGroups[i]);//Calling three digit number method and passing the digit group at ith location
            }
            // Recombine the three-digit groups
            string combined = groupText[0];
            bool appendAnd;

            // Determine whether an 'and' is needed
            appendAnd = (digitGroups[0] > 0) && (digitGroups[0] < 100);

            // Process the remaining groups in turn, smallest to largest
            for (int i = 1; i < 4; i++)
            {
                // Only add non-zero items
                if (digitGroups[i] != 0)
                {
                    // Build the string to add as a prefix
                    string prefix = groupText[i] + " " + _scaleNumbers[i];

                    if (combined.Length != 0)
                    {
                        prefix += appendAnd ? " and " : ", ";
                    }

                    // Opportunity to add 'and' is ended
                    appendAnd = false;

                    // Add the three-digit group to the combined string
                    combined = prefix + combined;
                }
            }
            // Negative rule
            if (number < 0)
                combined = "Negative " + combined;

            return combined;
        }
    }
}
