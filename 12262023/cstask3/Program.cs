using System;
using System.Security.Cryptography;
using System.Threading;

namespace cstask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Verilmiş yazının sonundaki boşluqları silinmiş yeni bir yazı düzəldən proqram
            //Console.Write("Metni daxil edin : ");
            //string text = Console.ReadLine();

            //string newText = "";
            //int endIndex = -1;


            //for (int i = text.Length - 1; i >= 0; i--)
            //{
            //    if (text[i] != ' ')
            //    {
            //        endIndex = i;
            //        break;
            //    }
            //}

            //for (int i = 0; i<text.Length; i++)
            //{
            //    if (text[i] == ' ' && i > endIndex)
            //    {
            //        continue;
            //    }
            //    else
            //        newText+= text[i];  
            //}



            //Console.WriteLine($"Original text: '{text}'");
            //Console.WriteLine($"Sondaki bosluqlari silinmis text: '{newText}'");

            #endregion

            #region DAY 8 - Tasks
            //1.Verilmiş 3 ədəddən hansının ən böyük olduğunu tapan proqram
            //Console.WriteLine("M ededini daxil edin:");
            //string mNum = Console.ReadLine();
            //int m = int.Parse(mNum);

            //Console.WriteLine("N ededini daxil edin:");
            //string nNum = Console.ReadLine();
            //int n = int.Parse(nNum);

            //Console.WriteLine("K ededini daxil edin:");
            //string kNum = Console.ReadLine();
            //int k = Convert.ToInt32(kNum);

            //if (m > n && m > k)
            //{
            //    Console.WriteLine($"En boyuk eded: {m}");
            //}
            //else if (n > m && n > k)
            //{
            //    Console.WriteLine($"En boyuk eded: {n}");

            //}
            //else if (m == n && n == k)
            //{
            //    Console.WriteLine("Butun ededler beraberdir");
            //}

            //else
            //{
            //    Console.WriteLine($"En boyuk eded: {k}");
            //}

            //2.Verilmiş yazının içində A hərfinin olub olmadığını tapan proqram
            //Console.Write("Yazini daxil edin - ");
            //string yazi = Console.ReadLine();

            //bool hasA = false;

            //for(int i = 0; i < yazi.Length; i++)
            //{
            //    if (yazi[i] == 'a' || yazi[i] == 'A')
            //    {
            //        hasA = true;
            //        break;
            //    }
            //}

            //if (hasA)
            //    Console.WriteLine("Yazida a herfi var");
            //else Console.WriteLine("Yazida a herfi yoxdur");


            //3.Verilmiş yazıda neçə A hərfinin olduğunu tapan proqram
            //Console.Write("Yazini daxil edin - ");
            //string yazi = Console.ReadLine();

            //int count = 0;

            //for(int i = 0; i < yazi.Length; i++)
            //{
            //    if (yazi[i] == 'a'|| yazi[i]=='A')
            //        count++;    
            //}

            //Console.WriteLine($"Yazida {count} a var.");   


            //4.Verilmiş müsbət cüt ədədi kradtarına yüksəldən proqram. Daxil edilən ədə musbət və cüt olmadıqca yenidən daxil edilməlidir

            //int eded;

            //do
            //{
            //    Console.WriteLine("Musbet ve cut eded daxil edin - ");
            //    string ededStr = Console.ReadLine();
            //    eded = int.Parse(ededStr);

            //    if (eded % 2 == 0 && eded > 0)
            //    {
            //        eded *= eded;
            //        break;
            //    }
            //    else
            //        Console.WriteLine("Ededi duzgun daxil edin!");


            //} while (true);


            //Console.WriteLine(eded);


            //5.Verilmiş 5 uzunluqlu ədədlər siyahısındaki ədədlərin cəmini tapan proqram
            //int[] nums = new int[5];
            //int Sum = 0;

            //Console.WriteLine("5 eded daxil edin:");

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.Write($"Eded {i + 1}: ");
            //    string input = Console.ReadLine();
            //    int inp = Convert.ToInt32(input);

            //    nums[i] = inp;
            //}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Sum += nums[i];
            //}
            //Console.Write($"Daxil etdiyiniz ededlerin cemi - {Sum}");


            /*6.Verilmiş təhsil növü dəyərinə əsasən o təhsilin saatını göstərən proqram.
            Əgər verilmiş dəyər "programming"dirsə console-da 400 saat, "design"dırsa 250 saat,
            "system"dirsə 200 saat,heç biri deyilsə "təhsil novu yanlisdir" yazılmalıdır console-da.*/


            //Console.WriteLine("Derslerin saatini gormek ucun tehsil novunu daxil edin(programming,design,system):");
            //string tehsil = Console.ReadLine();

            //switch(tehsil)
            //{
            //    case "programming":
            //        Console.WriteLine("400 saat");
            //        break;
            //    case "design":
            //        Console.WriteLine("250 saat");
            //        break;
            //    case "system":
            //        Console.WriteLine("200 saat");
            //        break;
            //    default: Console.WriteLine("Tehsil novu yanlisdir !");
            //        break;
            //}


            #endregion

            #region DAY 8 - Tasks 2
            //1.Verilmiş yazıdan içində boşluqlar olmayan yeni bir yazı düzəltmək 

            //Console.Write("Yazini daxil edin:");
            //string yazi = Console.ReadLine();
            //string newyazi = "";

            //for (int i = 0; i < yazi.Length; i++)
            //{
            //    if (yazi[i] != ' ')
            //    {
            //        newyazi += yazi[i];
            //    }
            //}

            //Console.Write($"Bosluqsuz yazi - {newyazi}");


            //2.Verilmiş ədədlər siyahısındaki verilmiş n ədədinin yerləşdiyi indexi tapan proqram
            //Console.WriteLine("Siyahinin uzunlugunu daxil edin:");
            //string sayStr = Console.ReadLine();
            //int say = int.Parse(sayStr);
            //string[] uzunluq = new string[say];

            //int wantedIndex = -1;

            //for (int i = 0; i < uzunluq.Length; i++)
            //{
            //    Console.Write($"{i + 1}. ededi daxil edin: ");
            //    uzunluq[i] = Console.ReadLine();
            //}

            //Console.Write("Axtarilan ededi daxil edin - ");
            //string eded = Console.ReadLine();    


            //for (int i = 0; i < uzunluq.Length; i++)
            //{
            //    if (uzunluq[i] == eded)
            //    {
            //        wantedIndex = i;
            //        break;
            //    }
            //}
            //Console.WriteLine(wantedIndex);


            //3.Verilmiş yazılar siyahısında verilmiş hərfdən neçə ədəd olduğunu tapan proqram

            //Console.WriteLine("Siyahinin uzunlugu:");
            //string lengthStr = Console.ReadLine();
            //int length = Convert.ToInt32(lengthStr);
            //string[] yaziArr = new string[length];

            //for (int i = 0; i < yaziArr.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}Yazini daxil edin:");
            //    yaziArr[i] = Console.ReadLine();
            //}

            //Console.WriteLine("Axtarilan herfi daxil edin:");
            //string letterStr = Console.ReadLine();
            //char letter = Convert.ToChar(letterStr);

            //int count = 0;

            //for (int i = 0; i < yaziArr.Length; i++)
            //{
            //    string str = yaziArr[i];

            //    for (int k = 0; k < str.Length; k++)
            //    {
            //        if (str[k] == letter) count++;
            //    }
            //}

            //Console.WriteLine(count);

            //4.Verilmiş yazının əvvəlindəki boşluqlar silinmiş bir string düzəldən proqram (Misalçün verilmiş yazı "   salam necesen?   "-dirsə yeni düzələcək string "salam necəsən?   " olmalıdır.


            //Console.Write("Verilmis yazinin evvelindaki bosluqlarin silinmesi ucun yazini daxil edin - ");
            //string text = Console.ReadLine();

            //string newText = "";
            //int startIndex = 0;

            //for (int i = 0; i < text.Length; i++)
            //{
            //    if (text[i] != ' ')
            //    {
            //        startIndex = i;
            //        break;
            //    }
            //}

            //for (int i = startIndex; i < text.Length; i++)
            //{
            //    newText += text[i];
            //}

            //Console.WriteLine($"Bosluqlar silindikden sonra yazi - { newText}.");


            //6.Verilmiş 2 ədəd üzərində verilmiş simvola uyğun əməliyyat edən proqram.
            //Simvol +,-,* və ya / olmalıdır, əks halda simvolu yenidən daxil edilməsi istənilməlidir.
            //(Misaçün simvol * olarsa verilmiş 2 ədəd vurulacaq və nəticəsi göstəriləcək)


            //Console.Write("1. ededi daxil edin - ");
            //string eded1 = Console.ReadLine();
            //double bir = double.Parse(eded1);

            //Console.Write("2. ededi daxil edin - ");
            //string eded2 = Console.ReadLine();
            //double iki = double.Parse(eded2);

            //bool check = true;
            //double result = 0;
            //do
            //{
            //    Console.WriteLine("operatoru daxil et:");
            //    string optStr = Console.ReadLine();
            //    char opt = Convert.ToChar(optStr);
            //    check = true;

            //    switch (opt)
            //    {
            //        case '+':
            //            result = bir + iki;
            //            break;
            //        case '-':
            //            result = bir - iki;
            //            break;
            //        case '*':
            //            result = bir * iki;
            //            break;
            //        case '/':
            //            if (iki == 0)
            //            {
            //                Console.WriteLine("Bolen 0 ola bilmez");
            //                break;
            //            }
            //            result = bir / iki;
            //            break;
            //        default:
            //            Console.WriteLine("Simvol yanlisdir!");
            //            check = false;
            //            break;
            //    }
            //} while (!check);

            //Console.WriteLine(result);





            #endregion

            #region Calculator

            do
            {
                Console.WriteLine("Emeliyyat secin:");
                Console.WriteLine("1. Toplama");
                Console.WriteLine("2. Çıxma");
                Console.WriteLine("3. Vurma");
                Console.WriteLine("4. Bölmə");
                Console.WriteLine("5. Proqramı bitir");

                int secim = int.Parse(Console.ReadLine());

                if (secim == 5)
                {
                    Console.WriteLine("Proqram bitdi");
                    break;
                }

                Console.Write("Birinci reqemi daxil edin: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("İkinci reqemi daxil edin: ");
                double num2 = double.Parse(Console.ReadLine());

                double result = 0;  

                switch (secim)
                {
                    case 1:
                        result = num1 + num2;
                        break;
                    case 2:
                        result = num1 - num2;
                        break;
                    case 3:
                        result = num1 * num2;
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Bolen 0 ola bilmez!");
                            continue;  
                        }
                        break;
                    default:
                        Console.WriteLine("Zehmet olmasa 1-5 arasi secimlerden birini daxil edin.");
                        continue;  
                }

                Console.WriteLine($"Result: {result}");

            } while (true);  

            #endregion


















        }
    }
}

