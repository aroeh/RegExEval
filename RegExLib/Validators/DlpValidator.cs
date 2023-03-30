using RegExLib.Data;
using RegExLib.Models;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;

namespace RegExLib.Validators
{
    public class DlpValidator
    {
        public string InputText { get; private set; }

        public string NumericText
        {
            get
            {
                if (string.IsNullOrWhiteSpace(InputText))
                {
                    return null;
                }

                var split = Regex.Split(Regex.Replace(InputText.Replace("\n", ""), RegExRules.RemoveSpecialCharacters, " "), RegExRules.NumbericSplitPattern, RegexOptions.IgnoreCase);
                var builder = new StringBuilder();
                if (split != null && split.Length > 0)
                {
                    for (int i = 0; i < split.Length; i++)
                    {
                        builder.Append(split[i]);
                    }
                }
                return builder.ToString().Trim();
            }
        }

        public bool SsnViolation => RuleViolations.Any() && RuleViolations.Any(r => r.RuleType == RuleTypes.SocialSecurityNumber);
        public bool CcnViolation => RuleViolations.Any() && RuleViolations.Any(r => r.RuleType == RuleTypes.CreditCard);

        public bool DataValid => RuleViolations == null || !RuleViolations.Any();

        public List<RegExRule> RuleViolations { get; private set; } = new();

        public DlpValidator(string text)
        {
            InputText = text;
        }

        public void RunDlpRules()
        {
            //loop through all basic regex rules to check the text matching patterns
            Span<RegExRule> ruleSpan = RegExRules.DlpRules;
            for (var i = 0; i < ruleSpan.Length; i++)
            {
                var rule = ruleSpan[i];

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
