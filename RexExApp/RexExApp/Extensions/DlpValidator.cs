using RexExApp.Data;
using RexExApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RexExApp.Extensions
{
    public class DlpValidator
    {
        public string InputText { get; private set; }

        public string NumericText
        {
            get
            {
                if(string.IsNullOrWhiteSpace(InputText))
                {
                    return null;
                }

                var split = Regex.Split(Regex.Replace(InputText.Replace("\n", ""), RegExRules.RemoveSpecialCharacters, " "), RegExRules.NumbericSplitPattern, RegexOptions.IgnoreCase);
                var builder = new StringBuilder();
                if(split != null && split.Length > 0)
                {
                    for(int i = 0; i < split.Length; i++)
                    {
                        builder.Append(split[i]);
                    }
                }
                return builder.ToString().Trim();
            }
        }

        public bool SsnViolation => RuleViolations.Count > 0 && RuleViolations.Any(r => r.RuleType == RuleTypes.SocialSecurityNumber);
        public bool CcnViolation => RuleViolations.Count > 0 && RuleViolations.Any(r => r.RuleType == RuleTypes.CreditCard);

        public bool DataValid => RuleViolations == null || RuleViolations.Count == 0;

        public List<RegExRule> RuleViolations { get; private set; }

        public DlpValidator(string text)
        {
            InputText = text;
            RuleViolations = new List<RegExRule>();
        }

        public void RunDlpRules()
        {
            //loop through all basic regex rules to check the text matching patterns
            foreach (var rule in RegExRules.DlpRules)
            {
                if ((!string.IsNullOrWhiteSpace(InputText) && Regex.IsMatch(InputText, rule.Pattern))
                    || (!string.IsNullOrWhiteSpace(NumericText) && Regex.IsMatch(NumericText, rule.Pattern))
                   )
                {
                    RuleViolations.Add(rule);
                }
            }
        }
    }
}
