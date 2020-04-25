using System;
using System.Collections.Generic;
using System.IO;


namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            //exercises on text program solutions 1 and 2

            Console.WriteLine("exrecise 1 and 2");
            Console.WriteLine("Enter numbers saperated by hifens for eg 1-2-3-4-5-6");
            var num = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(num))
                return;
            List<int> numbers = new List<int>();
            foreach (var number in num.Split('-'))
                numbers.Add(Convert.ToInt32(number));
            Console.WriteLine(ExerciseOnText.ExerciseOnText.ConsequtiveCheck(numbers));
            Console.WriteLine(ExerciseOnText.ExerciseOnText.DuplicateCheck(numbers));
            Console.WriteLine();

            //exercises on text program solutions 3 4 and 5
           
            Console.WriteLine("exercise 3: TimeCheck ");
            Console.WriteLine("Enter the time in hh:mm format");// 3
            var input = Console.ReadLine();
            ExerciseOnText.ExerciseOnText.TimeCheck(input);
            Console.WriteLine();

            Console.WriteLine("exercise 4: Pascal Case");
            Console.WriteLine("Enter some words saperated by spaces");// 4
            var words = Console.ReadLine();
            ExerciseOnText.ExerciseOnText.PascalsCase(words);
            Console.WriteLine();

            Console.WriteLine("exercise 5:vowel counter");
            Console.WriteLine("Enter a word"); // 5
            var word = Console.ReadLine();
            var numberOfVowels = ExerciseOnText.ExerciseOnText.VowelCount(word);
            Console.WriteLine("The word you entered has " + numberOfVowels + " vowels");
            Console.WriteLine();

            //exercise on files program solutions
            var FileName = "check.txt";
            ExerciseOnFiles.ExerciseOnFiles.WordCount(FileName);
            Console.WriteLine("The text the file contains is:" + File.ReadAllText(FileName));
            Console.WriteLine("Exercise 1: wordCount ");
            Console.WriteLine("The text file contains " + ExerciseOnFiles.ExerciseOnFiles.WordCount(FileName) + " words");
            Console.WriteLine("Exercise 2: LetterCount");
            Console.WriteLine("The text file contains " + ExerciseOnFiles.ExerciseOnFiles.LetterCount(FileName) + " letters");
        }
    }
}
