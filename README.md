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
| MBI     | Medicare Benefit Indicator | UNKNOWN             |

# Rules to Cover:


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

SSN RegEx Patterns
^\d{3}-\d{2}-\d{4}$
[/,,/.,/=,\s]([0-6]\d{2}|7[0-6]\d|77[0-2])(\s|\-)?(\d{2})\2(\d{4})[/,,/.,\s]
^((?!000)(?!666)(?:[0-6]\d{2}|7[0-2][0-9]|73[0-3]|7[5-6][0-9]|77[0-2]))-((?!00)\d{2})-((?!0000)\d{4})$


If you want to learn more about creating good readme files then refer the following [guidelines](https://docs.microsoft.com/en-us/azure/devops/repos/git/create-a-readme?view=azure-devops). You can also seek inspiration from the below readme files:
- [ASP.NET Core](https://github.com/aspnet/Home)
- [Visual Studio Code](https://github.com/Microsoft/vscode)
- [Chakra Core](https://github.com/Microsoft/ChakraCore)