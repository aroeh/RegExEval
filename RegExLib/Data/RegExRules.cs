using RegExLib.Models;

namespace RegExLib.Data
{
    public static class RegExRules
    {
        public const string NumbericSplitPattern = @"[a-z]+";
        public const string RemoveSpecialCharacters = @"[^0-9a-zA-Z]+";

        public static RegExRule[] DlpRules = new[]
        {
            new RegExRule
            {
                RuleType = RuleTypes.SocialSecurityNumber,
                Pattern = @"\b\d{9}\b",
                Description = "Does a simple 9 digit pattern on SSN"
            },
            new RegExRule
            {
                RuleType = RuleTypes.SocialSecurityNumber,
                Pattern = @"\b(?:\d[ -]*?){9}\b",
                Description = "Finds any sequence of 9 digits including spaces or dashes"
            },
            new RegExRule
            {
                RuleType = RuleTypes.SocialSecurityNumber,
                Pattern = @"\d{3}-\d{2}-\d{4}",
                Description = "Does an exact match using basic SSN validation in the format of NNN-NN-NNNN"
            },
            //new RegExRule
            //{
            //    RuleType = RuleTypes.SocialSecurityNumber,
            //    Pattern = @"\d{3}\s\d{2}\s\d{4}",
            //    Description = "Does an exact match using basic SSN validation in the format of NNN-NN-NNNN"
            //},
            new RegExRule
            {
                RuleType = RuleTypes.SocialSecurityNumber,
                Pattern = @"[/,,/.,/=,\s]([0-6]\d{2}|7[0-6]\d|77[0-2])(\s|\-)?(\d{2})\2(\d{4})[/,,/.,\s]",
                Description = "Does an exact match using basic SSN validation in the format of NNN-NN-NNNN"
            },
            new RegExRule
            {
                RuleType = RuleTypes.SocialSecurityNumber,
                Pattern = @"((?!000)(?!666)(?:[0-6]\d{2}|7[0-2][0-9]|73[0-3]|7[5-6][0-9]|77[0-2]))-((?!00)\d{2})-((?!0000)\d{4})",
                Description = "Does an exact match using basic SSN validation in the format of NNN-NN-NNNN"
            },
            new RegExRule
            {
                RuleType = RuleTypes.CreditCard,
                Pattern = @"\b4[0-9]{12}(?:[0-9]{3})?\b",
                Description = "Finds Credit Card Numbers in larger documents"
            },
            new RegExRule
            {
                RuleType = RuleTypes.CreditCard,
                Pattern = @"\b\d{13,16}\b",
                Description = "Finds any sequence of 13 and 16 digits"
            },
            new RegExRule
            {
                RuleType = RuleTypes.CreditCard,
                Pattern = @"\b(?:\d[ -]*?){13,16}\b",
                Description = "Finds any sequence of 13 and 16 digits including spaces or dashes"
            },
            new RegExRule
            {
                RuleType = RuleTypes.DrugCode,
                Pattern = @"\b\d{4}-\d{4}-\d{2}|\d{5}-\d{3}-\d{2}|\d{5}-\d{4}-\d{1}|\d{5}-\*\d{3}-\d{2}\b",
                Description = "Matches a 10 digit National Drug Code sequences of 4-4-2, 5-3-2, or 5-4-1"
            },
            new RegExRule
            {
                RuleType = RuleTypes.DrugCode,
                Pattern = @"\b\d{4,5}-\d{3,4}-\d{1,2}\b",
                Description = "Matches a 10 digit National Drug Code sequences of 4-4-2, 5-3-2, or 5-4-1"
            },
            new RegExRule
            {
                RuleType = RuleTypes.AbaRoutingNumber,
                Pattern = @"\b((0[0-9])|(1[0-2])|(2[1-9])|(3[0-2])|(6[1-9])|(7[0-2])|80)([0-9]{7})\b",
                Description = "Matches a 9 digit Bank Routing Number"
            },
            new RegExRule
            {
                RuleType = RuleTypes.AbaRoutingNumber,
                Pattern = @"\b[0-9]{7,14}\b",
                Description = "Matches a 7-14 digit Bank Account Number"
            }
        };
    }
}
