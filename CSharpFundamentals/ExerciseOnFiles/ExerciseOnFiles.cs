using System.IO;

namespace CSharpFundamentals.ExerciseOnFiles
{
    class ExerciseOnFiles
    {
        public static int WordCount(string FileNames)
        {
            var WordsCount = 0;
            var data = File.ReadAllText(FileNames);
            foreach (var word in data.Split(' '))
            {
                WordsCount += 1;
            }
            return WordsCount;
        }
        public static int LetterCount(string FileNames)
        {
            var LettersCount = 0;
            var data = File.ReadAllText(FileNames);
            foreach (var word in data.Split(' '))
            {
                if (word.Contains(".") || word.Contains(","))
                    LettersCount += word.Length - 1;
                else
                    LettersCount += word.Length;
            }
            return LettersCount;

        }
    }
}
