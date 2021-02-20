using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AurorAlgorithmAssessment
{
    /*
     * Class contains methods for string interpolation
     */
    public class StringInterpolation
    {
        /// <summary>
        /// Method interpolates the string with the values from dict dictionary
        /// </summary>
        /// <param name="stmt"></param>
        /// <param name="dict"></param>
        /// <returns>new interpolated string</returns>
        public string Interpolate(string stmt, Dictionary<string, string> dict)
        {
            // Regex expression to identify strings inside square brackets
            var pattern = @"\[(.*?)\]";

            // Returns string inside square brackets as MatchCollection type
            var matches = Regex.Matches(stmt, pattern);
            
            stmt = GetManipulatedString(stmt, dict, matches);
            return stmt;
        }

        /// <summary>
        /// Method to replace string inside square brackets with the value corresponding to it from dict
        /// </summary>
        /// <param name="stmt"></param>
        /// <param name="dict"></param>
        /// <param name="matches"></param>
        /// <returns>new stmt string with replaced values</returns>
        private static string GetManipulatedString(string stmt, Dictionary<string, string> dict, MatchCollection matches)
        {
            // loops through the matches to identify the keys and values to replace
            foreach (var (match, replaceString) in from Match match in matches
                                                   let replaceString = match.Groups[1].ToString()
                                                   select (match, replaceString))
            {
                if (dict.ContainsKey(replaceString))
                {
                    stmt = stmt.Replace(match.ToString(), dict[key: replaceString]);
                }
                else
                {
                    var escpaceString = match.ToString();
                    if (escpaceString.Contains("[["))
                    {
                        stmt = stmt.Replace(oldValue: string.Concat(escpaceString, "]"), escpaceString.Remove(0, 1));
                    }

                }
            }
            return stmt;
        }
    }
}
