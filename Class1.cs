using System;
using System.Collections.Generic;
using System.Text;

namespace VutureCodeTest_CJ
{
    class VutureFunctions
    {
        public int countCharOccurence(char character = 'e', string testString = "I have some cheese", bool caseModifier = false )
        {
            if (caseModifier == true)
            {
                testString = testString.ToLower();
            }
            int count = 0;

            foreach (char characterOccurence in testString)
            {
                if (characterOccurence == character)
                {
                    count += 1;
                }
            }
            return count;
        }

        public bool CharOccurence(char character = 'e', string testString = "I have some cheese")
        {
            return testString.Contains(character);
        }

        public bool isPalindrome(string PalindromeCandidate)
        {
            bool isPalin = false;

            PalindromeCandidate = PalindromeCandidate.ToLower();

            char [] palinCharArrayA = PalindromeCandidate.ToCharArray();

            //First and Last elements are not equal, cannot be a palindrome.
            if (palinCharArrayA[0] != palinCharArrayA[palinCharArrayA.GetUpperBound(0)])
            {
                return isPalin = false;
            }

            char [] palinCharArrayB = PalindromeCandidate.ToCharArray();
            Array.Reverse(palinCharArrayB);
            int index = 0;
            for (;  index < palinCharArrayA.GetUpperBound(0); index += 1)
            {
                for (; index < palinCharArrayB.GetUpperBound(0); index += 1)
                {
                    char itemB = palinCharArrayB[index];
                    char itemA = palinCharArrayA[index];
                    if (itemA != itemB)
                    {
                        return isPalin = false;
                    }
                }
            }
            return isPalin = true;
        }

        public Dictionary <string, int> CheckForBannedWord(List<string>bannedWords, string Sentence)
        {
            Dictionary<string, int> bannedWordOccurs = new Dictionary<string, int>();

            foreach (string word in bannedWords)
            {
                string candidate = word;
                //Console.WriteLine(candidate);
                int occurenceCounter = stringOcc(Sentence, candidate);
                //Console.WriteLine(occurenceCounter);
                bannedWordOccurs.Add(candidate, occurenceCounter);
            }
        
            return bannedWordOccurs;
        }


        public int stringOcc(string sentence, string bannedWord)
        {
                int occurrences = 0;
                int startingIndex = 0;

                while ((startingIndex = sentence.IndexOf(bannedWord, startingIndex)) >= 0)
                {
                    ++occurrences;
                    startingIndex += bannedWord.Length;
                }
                return occurrences;
        }

         public string censorWord(string sentence, List<string> bannedWord)
        {
            
            foreach (string word in bannedWord)
            {
                char censorchar = '*';
                
                if (sentence.Contains(word))
                {
                    int startingIndex = sentence.IndexOf(word);
                    
                    for (int i = startingIndex; i < word.Length; ++i)
                    {
                        sentence = word;
                        //Console.WriteLine(sentence[i]);
                        sentence = sentence.Replace(sentence[i], censorchar);
                        //Console.WriteLine(sentence[i]);
                    }
                }
                
            }
            return sentence;
        }

        public string CensorWordWorking(string sentence, List<string> bannedWord)
        {
            
            string[] wordArra = sentence.Split(" ");
            var wordsList = new List<String>(wordArra);
            string censoredSentence = null;
            foreach (string word in wordsList.ToArray())
            {
                foreach(string banWord in bannedWord)
                {
                    if (word.Equals(banWord))
                    {
                        wordsList.Remove(banWord);
                    }

                }
            }
            foreach (string word in wordsList)
            {
                censoredSentence += word + " ";
            }
            return censoredSentence;
        }

        public string censorSingleWordPalindrome(string sentence)
        {
            string censoredString = null;
            string[] wordArray = sentence.Split(' ');
            var wordsList = new List<String>(wordArray);

            List<string> PalinWords = new List<string> ();
            
            foreach (string word in wordArray)
            {
                if (isPalindrome(word))
                {
                    PalinWords.Add(word);
                }
             
            }
            
            //censoredString = censorWord(sentence, palinArray);
            censoredString = CensorWordWorking(sentence, PalinWords);
            return censoredString;
        }


    }
}
