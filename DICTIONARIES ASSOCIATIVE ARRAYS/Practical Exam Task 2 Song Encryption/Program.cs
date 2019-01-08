using System;
using System.Linq;
using System.Text;


namespace Exam_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] playlist = input.Split(":").ToArray();
                var performer = playlist[0];
                var song = playlist[1];

                if (IsName(performer) == true && CapitalLetter(performer) == true && IsSong(song))
                {
                    var encryptionKey = performer.Length;


                    var artistBuilder = new StringBuilder();
                    var songBuilder = new StringBuilder();

                    foreach (var symbol in performer)
                    {
                        var decoded = Convert.ToChar(symbol + encryptionKey);

                        if (decoded > 'z')
                        {
                            var adjustedLength = encryptionKey - ('z' - symbol) - 1; ;
                            decoded = Convert.ToChar('a' + adjustedLength);
                        }

                        if (symbol == performer[0])
                        {
                            if (decoded > 'Z')
                            {
                                var adjustedLength = encryptionKey - ('Z' - symbol) - 1; ;
                                decoded = Convert.ToChar('A' + adjustedLength);
                            }
                        }

                        if (symbol == ' ' || symbol == '\'')
                        {
                            decoded = symbol;
                        };

                        artistBuilder.Append(decoded);
                    }

                    foreach (var symbol in song)
                    {
                        var decoded = Convert.ToChar(symbol + encryptionKey);

                        if (decoded > 'Z')
                        {
                            var adjustedLength = encryptionKey - ('Z' - symbol) - 1;
                            decoded = Convert.ToChar('A' + adjustedLength);
                        }

                        if (symbol == ' ')
                        {
                            decoded = symbol;
                        };

                        songBuilder.Append(decoded);
                    }

                    var artistDecoded = artistBuilder.ToString();
                    var songDecoded = songBuilder.ToString();
                    var finalEncryption = artistDecoded + "@" + songDecoded;

                    Console.WriteLine($"Successful encryption: {finalEncryption}");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                input = Console.ReadLine();
            }
        }

        public static bool Istrue(string foundPerformer)
        {
            bool isTrue = true;

            for (int i = 1; i < foundPerformer.Length; i++)
            {
                if (foundPerformer[i] >= 65 && foundPerformer[i] <= 90)
                {
                    isTrue = false;
                }
            }

            return isTrue;
        }
        public static bool IsName(string performer)
        {
            bool isTrue = true;

            for (int i = 1; i < performer.Length; i++)
            {
                if (performer[i] >= 'a' && performer[i] <= 'z'
                    || performer[i] == ' ' || performer[i] == '\'')
                {
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
                }
            }

            return isTrue;
        }
        public static bool CapitalLetter(string performer)
        {
            bool isTrue = true;

            if (performer[0] >= 'A' && performer[0] <= 'Z')
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }

            return isTrue;
        }
        public static bool IsSong(string song)
        {
            bool isTrue = true;

            for (int i = 0; i < song.Length; i++)
            {
                if (song[i] >= 'A' && song[i] <= 'Z'
                    || song[i] == ' ')
                {
                    isTrue = true;
                }
                else
                {
                    isTrue = false;
                }
            }

            return isTrue;
        }    
    }
}
