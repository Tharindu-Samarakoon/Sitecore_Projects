using PalindromeTask;

Console.WriteLine("=====Difficulty 1======");
Console.WriteLine(PalindromeCheck.CheckPalindromeDiff1("racecar", "")); //True
Console.WriteLine(PalindromeCheck.CheckPalindromeDiff1("ra%%$$$$$$c#ec$ar@", "%#$@")); //True
Console.WriteLine(PalindromeCheck.CheckPalindromeDiff1("$$aabccbaA%%", "%$")); //True
Console.WriteLine(PalindromeCheck.CheckPalindromeDiff1("lakal", "%#$@")); //True
Console.WriteLine(PalindromeCheck.CheckPalindromeDiff1("ra%%$$$$$$c#ec$ar@1", "%#$@")); //False
Console.WriteLine(PalindromeCheck.CheckPalindromeDiff1("ra%%^&ar", "%#$@")); //False

Console.WriteLine("=====Difficulty 2======");
Console.WriteLine(PalindromeCheck.CheckPalindromeDiff2("racecar", ""));
Console.WriteLine(PalindromeCheck.CheckPalindromeDiff2("ra%%$$$$$$c#ec$ar@", "%#$@"));
Console.WriteLine(PalindromeCheck.CheckPalindromeDiff2("$$aabccbaA%%", "%$"));
Console.WriteLine(PalindromeCheck.CheckPalindromeDiff2("lakal", "%#$@"));
Console.WriteLine(PalindromeCheck.CheckPalindromeDiff2("ra%%$$$$$$c#ec$ar@1", "%#$@"));
Console.WriteLine(PalindromeCheck.CheckPalindromeDiff2("ra%%^&ar", "%#$@"));

Console.WriteLine("=====Difficulty 3======");
Console.WriteLine(PalindromeCheck.CheckPalindromeDiff3("racecar", ""));
Console.WriteLine(PalindromeCheck.CheckPalindromeDiff3("ra%%$$$$$$c#ec$ar@", "%#$@"));
Console.WriteLine(PalindromeCheck.CheckPalindromeDiff3("$$aabccbaA%%", "%$"));
Console.WriteLine(PalindromeCheck.CheckPalindromeDiff3("lakal", "%#$@"));
Console.WriteLine(PalindromeCheck.CheckPalindromeDiff3("ra%%$$$$$$c#ec$ar@1", "%#$@"));
Console.WriteLine(PalindromeCheck.CheckPalindromeDiff3("ra%%^&ar", "%#$@"));




