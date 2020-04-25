using System;
using System.Collections.Generic;

namespace CSharpFundamentals.ExerciseOnText
{
    class ExerciseOnText
    {
        public static string ConsequtiveCheck(List<int> numbers)//exercise 1
        {
            var consequtiveAscending = true; //"5-6-7-8-9"
            var consequtiveDescending = true;//"20-19-18-17-16",
            for (var i = 1; i < numbers.Count; i++)
            {

                if (numbers[i] != numbers[i - 1] + 1)
                    consequtiveAscending = false;
                break;
            }
            for (var i = 1; i < numbers.Count; i++)
            {

                if (numbers[i] != numbers[i + 1] + 1)
                    consequtiveDescending = false;
                break;
            }
            var isconsequtive = consequtiveAscending || consequtiveDescending;
            var message = isconsequtive ? "numbers are consequtive" : "numbers are not consequtive";
            return message;
        }

        public static string DuplicateCheck(List<int> numbers)//exercise 2
        {
            var isDuplicate = false;
            foreach (var number in numbers)
            {
                if (numbers.IndexOf(number) != numbers.LastIndexOf(number))
                    isDuplicate = true;
            }
            var message1 = isDuplicate ? "duplicate exists" : "no duplicate exists";
            return message1;
        }

        public static void TimeCheck(string input) //exercise 3
        {
            try
            {
                DateTime.Parse(input);
                Console.WriteLine("valid time");
            }
            catch (Exception)
            {
                Console.WriteLine("invalid time");
            }
        }

        public static void PascalsCase(string words) //exercise 4
        {
            if (String.IsNullOrWhiteSpace(words))
            {
                Console.WriteLine("Error");
                return;
            }
            var variabeName = "";

            foreach (var word in words.Split(' '))
            {
                var varWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variabeName += varWithPascalCase;
            }
            Console.WriteLine(variabeName);


        }

        public static int VowelCount(string word) //exercise 5
        {
            var vowelCount = 0;
            var vowels = new List<char>(new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' });
            foreach (var letter in word)
                if (vowels.Contains(letter))
                    vowelCount += 1;

            return vowelCount;
        }
    }

}

