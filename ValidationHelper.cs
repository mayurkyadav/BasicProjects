using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Assignment_3_PC_
{/// <summary>
/// This class is mainly responsible for adding validations of all the vitals
/// </summary>
    internal class ValidationHelper
    {
        public static List<string> ExtractVitals(string text)
        {
            List<string> vitals = new List<string>();

            // Define regular expressions for each type of vital measurement
            string bpPattern = @"BP\s?:?\s?(\d{2,3})\/(\d{2,3})(?:\smmHg)?";
            string hrPattern = @"HR\s?:?\s?(\d{2,3})(?:\sbpm)?";
            string rrPattern = @"RR\s?:?\s?(\d{2,3})(?:\sbpm)?";
            string tPattern = @"T\s?:?\s?(\d{2}(\.\d)?)";

            // Match vital measurements in the text using regular expressions
            MatchCollection bpMatches = Regex.Matches(text, bpPattern, RegexOptions.IgnoreCase);
            MatchCollection hrMatches = Regex.Matches(text, hrPattern, RegexOptions.IgnoreCase);
            MatchCollection rrMatches = Regex.Matches(text, rrPattern, RegexOptions.IgnoreCase);
            MatchCollection tMatches = Regex.Matches(text, tPattern, RegexOptions.IgnoreCase);

            // Add matched vital measurements to the list
            foreach (Match match in bpMatches)
            {
                int systolic = int.Parse(match.Groups[1].Value);
                int diastolic = int.Parse(match.Groups[2].Value);
                string status = GetBPStatus(systolic, diastolic);
                vitals.Add($"BP: {systolic}/{diastolic} mmHg ({status})");
            }
            foreach (Match match in hrMatches)
            {
                int heartRate = int.Parse(match.Groups[1].Value);
                string status = GetHRStatus(heartRate);
                vitals.Add($"HR: {heartRate} bpm ({status})");
            }
            foreach (Match match in rrMatches)
            {
                int respiratoryRate = int.Parse(match.Groups[1].Value);
                string status = GetRRStatus(respiratoryRate);
                vitals.Add($"RR: {respiratoryRate} bpm ({status})");
            }
            foreach (Match match in tMatches)
            {
                double temperature = double.Parse(match.Groups[1].Value);
                string status = GetTStatus(temperature);
                vitals.Add($"T: {temperature} °C ({status})");
            }

            return vitals;
        }

        private static string GetBPStatus(int systolic, int diastolic)
        {
            if (systolic < 90 || diastolic < 60)
            {
                return "Low";
            }
            else if (systolic > 130 || diastolic > 80)
            {
                return "High";
            }
            else
            {
                return "";
            }
        }

        private static string GetHRStatus(int heartRate)
        {
            if (heartRate < 60 /*|| heartRate > 100*/)
            {
                return "Low";
            }
            else if (heartRate > 100)
            {
                return "High";
            }
            else
            {
                return "";
            }
        }

        private static string GetRRStatus(int respiratoryRate)
        {
            if (respiratoryRate < 12 /*|| respiratoryRate > 16*/)
            {
                return "Low";
            }
            else if(respiratoryRate > 16)
            {
                return "High";

            }
            else
            {
                return "";
            }
        }

        private static string GetTStatus(double temperature)
        {
            if (temperature < 36.5 /*|| temperature > 37.2*/)
            {
                return "Low";
            }
            else if(temperature > 37.2)
            {
                return "High";
            }
            else
            {
                return "Normal";
            }
        }

    } 
}
