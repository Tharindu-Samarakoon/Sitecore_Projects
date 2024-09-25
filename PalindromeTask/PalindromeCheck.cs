namespace PalindromeTask
{
    internal class PalindromeCheck
    {

        //DIFFICULTY - 1
        public static bool CheckPalindromeDiff1(string InputString, string TrashSymbolString)
        {
            string palindrome = "";
            string inputString = "";

            //Loop through the entire string and
            //reverse the string by string concatenation while ignoring the Trash Symbols
            foreach(char c in InputString)
            {
                if (!TrashSymbolString.Contains(c))
                {
                    palindrome = c + palindrome;
                    inputString = inputString + c;
                }
            }

            //Compare the 2 strings and check if they match.
            //If yes - Palindrome | No - Not Palindrome
            if (palindrome.ToLower().Equals(inputString.ToLower()))
            {
                return true;
            } else
            {
                return false;
            }
        }

        //DIFFICULTY - 2
        public static bool CheckPalindromeDiff2(string InputString, string TrashSymbolString)
        {
            //Create stack to add char and retrieve in FILO order
            Stack<char> letters = new();

            //Loop through the char in the string and add to the stack if char is not a Trash Symbol
            foreach(char c in InputString)
            {
                if (!TrashSymbolString.Contains(c))
                {
                    letters.Push(c);
                }
            }

            //Loop through the InputString again and if the char is not a Trash Symbol, pop a char from the stack and compare.
            //IF char not equal then not a palindrome
            foreach (char c in InputString)
            {
                if (!TrashSymbolString.Contains(c))
                {
                    char letter = char.ToLower(letters.Pop());
                    if (letter != char.ToLower(c)) return false;
                }
            }

            //Confirm that stack is empty and return true
            if(letters.Count == 0)
            {
                return true;
            }else
            {
                return false;
            }

        }

        //DIFFICULTY - 3
        public static bool CheckPalindromeDiff3(string InputString, string TrashSymbolString)
        {
            //Obtain pointers for start and end of string.
            int x = InputString.Length - 1;
            int i = 0;

            //Iterate through the string while pointers are not met
            while(i < x)
            {
                //If start pointer is a trash symbol increment
                if (TrashSymbolString.Contains(InputString[i]))
                {
                    i++;
                    continue;
                }

                //If end pointer is a trash symbol decrement
                if (TrashSymbolString.Contains(InputString[x]))
                {
                    x--;
                    continue;
                }

                //If the values of the 2 pointers are not equal, not a palindrome
                if (char.ToLower(InputString[i]) != char.ToLower(InputString[x]))
                {
                    return false;
                }

                //Increase and decrease the 2 pointers if the compared char are equal
                i++;
                x--;

            }
            return true;
        }

    }
}
