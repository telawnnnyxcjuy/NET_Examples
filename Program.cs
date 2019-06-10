using System;
using System.Collections.Generic;
namespace VutureCodeTest_CJ
{
    class Program
    {
        static void Main(string[] args)
        {
            VutureFunctions testy = new VutureFunctions();

            Console.WriteLine("Vuture Code Testing");
            Console.WriteLine("Task 1: \n");
            

            //T1    Function to count char occurence in string.
            string testStr = "I am lactose intolerant.";
            char testChar = 'a';

            int counterA = testy.countCharOccurence(testChar, testStr);
            Console.WriteLine("Test String A contains:  " + counterA);
            
            //The default args in use.
            int counterB = testy.countCharOccurence();
            Console.WriteLine("Test String B contains:  " + counterB);

            //T2    Function to test string for palindrome.
            Console.WriteLine("Task 2: \n");
            string palindromeStr = "godsavedevasdog";
            Console.WriteLine(palindromeStr + " Is Palindrome? ");
            Console.WriteLine(testy.isPalindrome(palindromeStr));

            string notpalinStr = "HelloMyNameIsChris";
            Console.WriteLine(notpalinStr + "   Is Palindrome? ");
            Console.WriteLine(testy.isPalindrome(notpalinStr) + "\n");

            //T3    Function to check for banned words
            string bannedWordsSentence = "Hello Hello My Name is Chris";
            string bannedWord = "Hello";

            //T3 A  Count occurence of banned word.   
            Console.WriteLine("T3 A");
            List<string> bannedWords = new List<string>();
            bannedWords.Add(bannedWord);

            Dictionary<string, int> bannedWordOccurs = new Dictionary<string, int>();

            bannedWordOccurs = testy.CheckForBannedWord(bannedWords, bannedWordsSentence);

            foreach (KeyValuePair<string, int> banned in bannedWordOccurs)
            {
                Console.WriteLine("Banned Word = {0}, Occured = {1}" + " Times", banned.Key, banned.Value);
            }


            //T3 B  Censor the sentence.
            Console.WriteLine("T3 B ");
            string censorSentence = testy.CensorWordWorking(bannedWordsSentence, bannedWords);
            Console.WriteLine(censorSentence);


            //T3 C  Censor Single word palindrome.
            Console.WriteLine("T3 C");
            string sentenceToBeCensored = "Anna went to vote in the election to fulfil her civic duty";
            string censoredString = testy.censorSingleWordPalindrome(sentenceToBeCensored);
            Console.WriteLine(censoredString);

            //T3 BONUS
            Console.WriteLine("\n" + "+ Could have provided banned word list as SQL object");
            Console.WriteLine("\n" + "+ Could have provided banned word list as json file");
            Console.WriteLine("\n" + "+ Could have provided banned word list as csv object delimited with ',', 'tab' etc.");
        }
    }
}
