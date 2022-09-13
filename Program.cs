//FindEvenNumbers();
//FindExactDivisors();
//ReverseOrderWord();
FindTotalWordsAndLetters();

static void FindEvenNumbers()
{
    //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.
    Console.Write("Bir sayı giriniz : ");

    int number = int.Parse(Console.ReadLine());

    if(number > 0)
    {
        Console.WriteLine($"{number} adet sayı giriniz.");
        int[] enteredNumbers = new int[number];
        for (int i = 0; i < number; i++)
        {
            Console.Write($"{i+1}. sayı : ");
            enteredNumbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("\nÇift Sayılar : ");
        for (int i = 0; i < enteredNumbers.Length; i++)
        {
            if (enteredNumbers[i] % 2 == 0)
            {
                Console.Write(enteredNumbers[i]);
                Console.Write(" ");
            }
        }
    }
    else
    {
        Console.WriteLine("Sıfırdan büyük bir sayı girmelisiniz.");
    }
}

static void FindExactDivisors()
{
    //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
    Console.Write("Birinci sayıyı giriniz : ");
    int n = int.Parse(Console.ReadLine());

    Console.Write("\nİkinci sayıyı giriniz : ");
    int m = int.Parse(Console.ReadLine());

    if (n > 0 && m > 0)
    {
        Console.WriteLine($"\n{n} adet sayı giriniz.");
        int[] enteredNumbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"{i + 1}. sayı : ");
            enteredNumbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("\nm e tam bölünen sayılar : ");
        for (int i = 0; i < enteredNumbers.Length; i++)
        {
            if (enteredNumbers[i]  == m || enteredNumbers[i] % m == 0)
            {
                Console.Write(enteredNumbers[i]);
                Console.Write(" ");
            }
        }
    }
    else
    {
        Console.WriteLine("Sıfırdan büyük sayı girmelisiniz.");
    }
}

static void ReverseOrderWord()
{
    //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
    Console.Write("Bir sayı giriniz : ");

    int number = int.Parse(Console.ReadLine());

    if (number > 0)
    {
        Console.WriteLine($"{number} adet kelime giriniz.");
        string[] enteredWords = new string[number];
        for (int i = 0; i < number; i++)
        {
            Console.Write($"{i + 1}. kelime : ");
            enteredWords[i] = Console.ReadLine();
        }

        Console.Write("\nTersten Sıralama : ");
        for (int i = enteredWords.Length; i > 0; i--)
        {
            Console.Write(enteredWords[i-1]);
            Console.Write(" ");
        }
    }
    else
    {
        Console.WriteLine("Sıfırdan büyük bir sayı girmelisiniz.");
    }
}

static void FindTotalWordsAndLetters()
{
    //Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

    Console.Write("Bir cümle yazınız : ");

    string sentence = Console.ReadLine();
    string[] words =  sentence.Split(' ');
    string newSentence = sentence.Replace(" ", "");

    Console.WriteLine($"Kelime Sayısı : {words.Length}");
    Console.WriteLine($"Harf Sayısı : {newSentence.Length}");
}