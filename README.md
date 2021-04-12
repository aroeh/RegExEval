# Introduction 
TODO: Give a short introduction of your project. Let this section explain the objectives or the motivation behind this project. 

# Getting Started
TODO: Guide users through getting your code up and running on their own system. In this section you can talk about:
1.	Installation process
2.	Software dependencies
3.	Latest releases
4.	API references

# Terms
| Acronym | Term                       | Common Format       |
| ------- | -------------------------- | ------------------- |
| SSN     | Social Security Number     | NNN-NN-NNNN         |
| CCN     | Credit Card Number         | NNNN-NNNN-NNNN-NNNN |
| RxCode  | Drug Code                  | NNNNN-NNN-NN        |
| ABA     | UNKNOWN                    | UNKNOWN             |
| MBI     | Medicare Benefit Indicator | NCNN-CNN-CCNN       |


# Test Data Scenarios
SSN
123-45-6789
123 45 6789
123456789

Credit Card Number
1111-2222-3333-4444
1111 2222 3333 4444
1111222233334444

# Research
https://docs.microsoft.com/en-us/dotnet/csharp/how-to/search-strings
https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex.split?view=net-5.0
https://regexlib.com/Search.aspx?k=ssn&AspxAutoDetectCookieSupport=1
https://www.regular-expressions.info/creditcard.html
https://www.cms.gov/medicare/new-medicare-card/understanding-the-mbi-with-format.pdf

SSN RegEx Patterns
^\d{3}-\d{2}-\d{4}$
[/,,/.,/=,\s]([0-6]\d{2}|7[0-6]\d|77[0-2])(\s|\-)?(\d{2})\2(\d{4})[/,,/.,\s]
^((?!000)(?!666)(?:[0-6]\d{2}|7[0-2][0-9]|73[0-3]|7[5-6][0-9]|77[0-2]))-((?!00)\d{2})-((?!0000)\d{4})$


MBI
How does the MBI look on the card?The MBI has letters and numbers. 
Here’s an example: 1EG4-TE5-MK73
The MBI’s 2nd, 5th, 8th, and 9th characters are always letters.
Characters 1, 4, 7, 10, and 11 are always numbers.
The 3rd and 6th characters are letters or numbers.
We don’t use dashes in the MBI. They aren’t part of our computer systems and we don’t use them in file formats.

Position 1 – numeric values 1 thru 9
Position 2 – alphabetic values A thru Z (minus S, L, O, I, B, Z)
Position 3 – alpha-numeric values 0 thru 9 and A thru Z (minus S, L, O, I, B, Z)
Position 4 – numeric values 0 thru 9
Position 5 – alphabetic values A thru Z (minus S, L, O, I, B, Z)
Position 6 – alpha-numeric values 0 thru 9 and A thru Z (minus S, L, O, I, B, Z)
Position 7 – numeric values 0 thru 9
Position 8 – alphabetic values A thru Z (minus S, L, O, I, B, Z)
Position 9 – alphabetic values A thru Z (minus S, L, O, I, B, Z)
Position 10 – numeric values 0 thru 9
Position 11 – numeric values 0 thru 9