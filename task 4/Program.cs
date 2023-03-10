using System.ComponentModel.Design.Serialization;

namespace task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
        #region task 1 
        ///*
        //   1) verilmish ededin tek ve ya cut eded oldugunu yoxla
        // */
        //l1:
        //    Console.Write("ededi daxil edin: ");
        //    if (!int.TryParse(Console.ReadLine(), out int value))
        //    {
        //        Console.WriteLine("ededi duzgun daxil edin");
        //        goto l1;
        //    }
        //    if (value % 2 == 0)
        //    {
        //        Console.WriteLine("eded cut ededdir");
        //    }
        //    else
        //    {
        //        Console.WriteLine("eded tek ededdir");
        //    }
        #endregion

        #region task 2
        ///*
        //  2 eded verilib. Eger I eded II edede tam bolunurse o zaman cavabi cixart.
        //   Eks halda  "bolunmur" sozunu cap et
        // */
        //l1:
        //    Console.Write("1-ci ededi daxil edin: ");
        //    if (!int.TryParse(Console.ReadLine(), out int firstValue))
        //    {
        //        Console.WriteLine("ededi duzgun daxil edin");
        //        goto l1;
        //    }
        //l2:
        //    Console.Write("2-ci ededi daxil edin: ");
        //    if (!int.TryParse(Console.ReadLine(), out int scndValue))
        //    {
        //        Console.WriteLine("ededi duzgun daxil edin");
        //        goto l2;
        //    }
        //    if (firstValue % scndValue == 0)
        //    {
        //        Console.WriteLine($"{firstValue / scndValue}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("bolunmur");
        //    }

        #endregion

        #region task 3
        ///*
        // 3) Verilmish ededdin sonuncu reqemi 7 ile qurtarirmi? Beli ve Xeyr cavabini yaz ekrana
        // */
        //l1:
        //    Console.Write("ededi daxil edin: ");
        //    if (!int.TryParse(Console.ReadLine(), out int value))
        //    {
        //        goto l1;
        //    }
        //    if (value % 10 == 7)
        //    {
        //        Console.WriteLine("beli");
        //    }
        //    else
        //    {

        //        Console.WriteLine("xeyr");
        //    }
        #endregion

        #region task 4
        ///*
        // 4) Verilmihs 2 reqemli ededin reqemleri eynidirmi?   Beli ve Xeyr cavabini yaz ekrana
        // */
        //l1:
        //    Console.Write("2 reqmli eded daxil edin: ");
        //    if (!int.TryParse(Console.ReadLine(), out int value))
        //    {
        //        Console.WriteLine("ededi duzgun daxil edin");
        //        goto l1;
        //    }
        //    if ((int)Math.Log10(value) + 1 != 2)
        //    {
        //        Console.WriteLine("ededi duzgun daxil edin");
        //        goto l1;
        //    }
        //    int remainder_1 = value % 10;
        //    value /= 10;
        //    int remainder_2 = value % 10;
        //    if (remainder_1 == remainder_2)
        //    {
        //        Console.WriteLine("beli");
        //    }
        //    else
        //    {
        //        Console.WriteLine("xeyr");
        //    }
        #endregion

        #region task 5
        ///*
        // Verilmish 2 reqemli ededdin reqemleri cemi cut ededdirse o zaman
        //  hemin 2 reqemli ededdin reqemlerinin hasilini ekrana cixart.

        //*/
        //l1:
        //    Console.Write("2 reqmli eded daxil edin: ");
        //    if (!int.TryParse(Console.ReadLine(), out int value))
        //    {
        //        Console.WriteLine("ededi duzgun daxil edin");
        //        goto l1;
        //    }

        //    if ((int)Math.Log10(value) + 1 != 2)
        //    {
        //        Console.WriteLine("ededi duzgun daxil edin");
        //        goto l1;
        //    } 
        //    int sum = 0;
        //    int sum_2 = 1;
        //    while (value > 0)
        //    {
        //        int remainder = value % 10;
        //        value /= 10;
        //        sum += remainder;
        //        sum_2 *= remainder;

        //    }
        //    if (sum % 2 == 0)
        //    {
        //        Console.WriteLine(sum_2);
        //    }
        //    else
        //    {
        //        Console.WriteLine("reqemleri cemi tek ededdir");
        //    }
        #endregion

        #region task 6
        ///*
        // 6) Verilmish 3 reqemli ededdin I ve III reqemlerinin cemi II reqeme beraberdirmi?  Beli ve Xeyr cavabini yaz ekrana
        // */
        //l1:
        //    Console.Write("3 reqmli eded daxil edin: ");
        //    if (!int.TryParse(Console.ReadLine(), out int value))
        //    {
        //        goto l1;
        //    }
        //    if ((int)Math.Log10(value) + 1 != 3)  
        //    {
        //        Console.WriteLine("ededi duzgun daxil edin");
        //        goto l1;
        //    }
        //    int remainder = value % 10;
        //    value /= 10;
        //    int remainder_2 = value % 10;
        //    value/= 10;
        //    int remainder_3 = value % 10;
        //    if (remainder + remainder_3 == remainder_2) 
        //    {
        //        Console.WriteLine("beli");
        //    }
        //    else
        //    {
        //        Console.WriteLine("xeyr");
        //    }

        #endregion

        #region task 7
        ///*
        // 7) Verilmish 3 reqemli ededdin reqemleri cemi I reqemin kvadratina beraberdirmi?  Beli ve Xeyr cavabini yaz ekrana
        // */
        //l1:
        //    Console.Write("3 reqmli eded daxil edin: ");
        //    if (!int.TryParse(Console.ReadLine(), out int value))
        //    {
        //        goto l1;
        //    }
        //    if ((int)Math.Log10(value) + 1 != 3)
        //    {
        //        Console.WriteLine("ededi duzgun daxil edin");
        //        goto l1;
        //    }
        //    int pow =(int)Math.Pow(value%10,2);
        //    int sum = 0;
        //    while (value > 0) 
        //    {
        //        int remainder = value % 10;
        //        value/= 10;
        //        sum += remainder;
        //    }
        //    if(sum==pow)
        //    {
        //        Console.WriteLine("beli");
        //    }
        //    else
        //    {
        //        Console.WriteLine("xeyr");
        //    }
        #endregion

        #region task 8
        ///*
        // 8) SWITCH operatoru ile yoxla.
        //    Verilmish ededdin sonuncu reqemi
        //         1 olarsa-"I gun" sozunu
        //        2 olarsa-"II gun" sozunu
        //        ...
        //        7 olarsa-"VI gun" sozunu yaz       
        //*/
        //l1:
        //    Console.Write(" ededi daxil edin: ");
        //    if (!int.TryParse(Console.ReadLine(), out int value))
        //    {
        //        goto l1;
        //    }
        //switch (value%10)
        //{
        //    case 1:
        //        Console.WriteLine("I gun");
        //        break;
        //    case 2:
        //        Console.WriteLine("II gun");
        //        break;
        //    case 3:
        //        Console.WriteLine("III gun");
        //        break;
        //    case 4:
        //        Console.WriteLine("IV gun");
        //        break;
        //    case 5:
        //        Console.WriteLine("V gun");
        //        break;
        //    case 6:
        //        Console.WriteLine("VI gun");
        //        break;
        //    case 7:
        //        Console.WriteLine("VII gun");
        //        break;

        #endregion

        #region task 9
        ///*
        // 9) SWITCH operatoru ile yoxla.
        //    Verilmish ededdin 1-ile 12 arasinda olugunu yoxla.(1 ve 12 ozude daxil olmaq sherti ile)
        //     Eger bu eded
        //     1 olarsa-"Yanvar" sozunu
        //    2 olarsa-"Fevral" sozunu
        //    ...
        //    12 olarsa-"Dekabr" sozunu yaz

        // */
        //    l1:
        //    Console.Write("1-12 araliqinda eded daxil edin: ");
        //    if (!int.TryParse(Console.ReadLine(), out int value))
        //    {
        //        Console.WriteLine("eded 1-12 aralaqinda olmalidir");
        //        goto l1;
        //    }            
        //    if (value < 1 || value > 12)
        //    {
        //        Console.WriteLine("eded 1-12 aralaqinda olmalidir");
        //        goto l1;
        //    }       
        //     switch (value)
        //     {
        //        case 1:
        //            Console.WriteLine("yanvar");
        //            break;

        //        case 2:
        //            Console.WriteLine("fevral");
        //            break;

        //        case 3:
        //            Console.WriteLine("mart");
        //            break;

        //        case 4:
        //            Console.WriteLine("aprel");
        //            break;

        //        case 5:
        //            Console.WriteLine("may");
        //               break;

        //        case 6:
        //            Console.WriteLine("iyun");
        //            break;

        //        case 7:
        //            Console.WriteLine("iyul");
        //            break; 

        //        case 8:
        //            Console.WriteLine("avqust");
        //            break;

        //        case 9:
        //            Console.WriteLine("sentyabr");
        //            break;

        //        case 10:
        //            Console.WriteLine("oktyabr");
        //            break;

        //        case 11:
        //            Console.WriteLine("noyabr");
        //            break; 

        //        case 12:
        //            Console.WriteLine("dekabr");
        //            break;

        //     }
        #endregion

        #region task 10
        ///*
        // 10) IF operatoru ile yoxla.
        // 6 dene eded verilib. Bu ededlerden hansi en boyukdur.
        // */

        //l1:
        //    Console.Write("ededi daxil edin: ");
        //    if (!int.TryParse(Console.ReadLine(), out int value))
        //    {
        //        Console.WriteLine("ededi duzgun daxil edin");
        //        goto l1;
        //    }
        //l2:
        //    Console.Write("ededi daxil edin: ");
        //    if (!int.TryParse(Console.ReadLine(), out int value_2))
        //    {
        //        Console.WriteLine("ededi duzgun daxil edin");
        //        goto l2;
        //    }
        //l3:
        //    Console.Write("ededi daxil edin:  ");
        //    if (!int.TryParse(Console.ReadLine(), out int value_3))
        //    {
        //        Console.WriteLine("ededi duzgun daxil edin");
        //        goto l3;
        //    }
        //l4:
        //    Console.Write("ededi daxil edin:  ");
        //    if (!int.TryParse(Console.ReadLine(), out int value_4))
        //    {
        //        Console.WriteLine("ededi duzgun daxil edin");
        //        goto l4;
        //    }
        //l5:
        //    Console.Write("ededi daxil edin:  ");
        //    if (!int.TryParse(Console.ReadLine(), out int value_5))
        //    {
        //        Console.WriteLine("ededi duzgun daxil edin");
        //        goto l5;
        //    }
        //l6:
        //    Console.Write("ededi daxil edin:  ");
        //    if (!int.TryParse(Console.ReadLine(), out int value_6))
        //    {
        //        Console.WriteLine("ededi duzgun daxil edin");
        //        goto l6;
        //    }
        //    if (value > value_2 && value > value_3 && value > value_4 && value > value_5 && value > value_6)
        //    {
        //        Console.WriteLine(value);
        //    }
        //    else if (value_2 > value_3 && value_2 > value_4 && value_2 > value_5 && value_2 > value_6)
        //    {
        //        Console.WriteLine(value_2);
        //    }
        //    else if (value_3 > value_4 && value_3 > value_5 && value_3 > value_6)
        //    {
        //        Console.WriteLine(value_3);
        //    }
        //    else if (value_4 > value_5 && value_4 > value_6)
        //    {
        //        Console.WriteLine(value_4);
        //    }
        //    else if (value_5 > value_6)  
        //    {
        //        Console.WriteLine(value_5);
        //    }
        //    else
        //    {
        //        Console.WriteLine(value_6);
        //    }
        #endregion

        #region task 11
        ///*
        //  Verilmish 6 reqemli ededin ilk 3 reqeminin cemi son 3 reqeminin cemine beraberdirse
        //   o zaman
        //     bu ededdin ilk 2 reqemini son 2 reqemine yapishdir.
        //     Neticenin ustune ortaya dushen 2 reqemini gel.
        // */
        //l1:
        //    Console.Write("ededi daxil edin: ");
        //    if (!int.TryParse(Console.ReadLine(), out int value))
        //    {
        //        Console.WriteLine("ededi duzgun daxil edin");
        //        goto l1;
        //    }
        //    if ((int)Math.Log10(value) + 1 != 6)
        //    {
        //        Console.WriteLine("ededi duzgun daxil edin");
        //        goto l1;
        //    }
        //    int newValue = value;
        //    int lastThree = value % 1000;
        //    int firstThree=value/1000;
        //    int sum_1 = 0;
        //    int sum_2 = 0;
        //    int centerValue = 10 * ((firstThree / 10) % 10) + (lastThree / 10)%10;
        //    while (lastThree > 0)
        //    {
        //        int remainder = lastThree % 10;
        //        lastThree /= 10;
        //        sum_1 += remainder;
        //    }
        //    while (firstThree > 0)
        //    {
        //        int remainder = firstThree % 10;
        //        firstThree /= 10;
        //        sum_2 += remainder;
        //    }
        //    if (sum_1 == sum_2)
        //    {
        //        int result=(newValue/10000)*100+newValue%100;
        //        int lastResult = result + centerValue;
        //        Console.WriteLine(lastResult);

        //    }
        //    else
        //    {
        //        Console.WriteLine("ilk 3 reqeminin cemi son 3 reqeminin cemine beraber deyil");
        //    }
        #endregion

        #region task 12
        ///*
        //  12) Verilmihs 6 reqemli ededdin evveline ve axirina 8 artir.
        //   Alinan neticenin ilk 4 reqemi ile son 4 reqeminin yerini deyish
        //   Neticenin tek yerde dayanan reqemlerini 0 reqemi ile evez et.
        // */
        //l1:
        //    Console.Write("ededi daxil edin: ");
        //    if (!long.TryParse(Console.ReadLine(), out long value))
        //    {
        //        Console.WriteLine("ededi duzgun daxil edin");
        //        goto l1;
        //    }
        //    if ((long)Math.Log10(value) + 1 != 6)
        //    {
        //        Console.WriteLine("ededi duzgun daxil edin");
        //        goto l1;
        //    }
        //    long newValue = 8 * 10000000 + value * 10 + 8;
        //    long reverseValue = 10000 * (newValue % 10000) + newValue / 10000;
        //    long reverse = 0;
        //    long result = 0;
        //    Console.WriteLine(newValue);
        //    Console.WriteLine(reverseValue);
        //    while (reverseValue > 0)
        //    {
        //        long remainder = reverseValue % 10;
        //        reverseValue /= 100;
        //        reverse = reverse * 100 + remainder;
        //    }
        //    Console.WriteLine(reverse);
        //    while (reverse > 0)
        //    {
        //        long remainder = reverse % 10;
        //        reverse /= 10;
        //        result = result * 10 + remainder;
        //    }
        //    Console.WriteLine($"0{result}");
        #endregion

        #region task 13
        ///*
        // * 13) Verilmish 7 reqemli eded polindromdursa  o zaman onun daxilnde nece dene 0 reqemi oldugunu tap?
        // */
        //l1:
        //    Console.Write("ededi daxil edin: ");
        //    if (!int.TryParse(Console.ReadLine(), out int value))
        //    {
        //        Console.WriteLine("ededi duzgun daxil edin");
        //        goto l1;
        //    }
        //    if ((int)Math.Log10(value) + 1 != 7)
        //    {
        //        Console.WriteLine("ededi duzgun daxil edin");
        //        goto l1;
        //    }
        //    int newValue = value;
        //    int reverseValue = 0;
        //    int contains = 0;
        //    while (newValue > 0) 
        //    {
        //        int remainder = newValue % 10;
        //        newValue /= 10;
        //        reverseValue = reverseValue * 10 + remainder;

        //    }  
        //    if (reverseValue == value)  
        //    {
        //        while (value > 0)
        //        {
        //            int remainder = value % 10;
        //            value /= 10;
        //            if (remainder == 0)
        //            {
        //                contains++;


        //            } 
        //        }
        //        Console.WriteLine(contains);

        //    }
        //    else
        //    {
        //        Console.WriteLine("eded polindrom deyil");
        //    }

        #endregion

        #region task 14
        ///*
        // 14) Bir eded daxil et. Bu eded maksimum 8 reqemli ola biler( bu o demekdirki 1,2,3,4,5,6,7 reqemlide ola biler)
        // Bu ededin evvelin 1 reqemini artir.
        // */
        //l1:
        //    Console.Write("ededi daxil edin: ");
        //    if (!int.TryParse(Console.ReadLine(), out int value))
        //    {
        //        Console.WriteLine("ededi duzgun daxil edin");
        //        goto l1;
        //    }
        //    int lenght = (int)Math.Log10(value) + 1;
        //    if (lenght > 8)
        //    {
        //        Console.WriteLine("ededi duzgun daxil edin");
        //        goto l1;
        //    }
        //    int result = 1 * (int)Math.Pow(10, lenght) + value;
        //    Console.WriteLine(result);

        #endregion

        #region task 15
        ///*
        // * 15) IF operatoru ile yoxla.
        //       Verilmish ededdin 1-ile 365 arasinda olugunu yoxla (1 ve 365 ozude daxil olmaq sherti ile)
        //      Ededin ilin hansi ayina dushduyunu tap. Ve hemin ay ve gune uygun hansi burc oldugunu goster
        // */
        //l1:
        //    Console.Write("ededi daxil edin: ");
        //    if (!int.TryParse(Console.ReadLine(), out int value))
        //    {
        //        Console.WriteLine("ededi duzgun daxil edin");
        //        goto l1;
        //    }
        //    if(value<1 || value>365) 
        //    {
        //        Console.WriteLine("ededi duzgun daxil edin");
        //        goto l1;
        //    }

        //    if (1 <= value && value <= 31)
        //    {
        //        Console.Write("Yanvar ayi, ");
        //    }
        //    else if (32 <= value && value <= 59)
        //    {
        //        Console.Write("Fevral ayi, ");
        //    }
        //    else if (60 <= value && value <= 90)
        //    {
        //        Console.Write("Mart ayi, ");
        //    }
        //    else if (91 <= value && value <= 120)
        //    {
        //        Console.Write("Aprel ayi, ");
        //    }
        //    else if (121 <= value && value <= 151)
        //    {
        //        Console.Write("May ayi, ");
        //    }
        //    else if (152 <= value && value <= 181)
        //    {
        //        Console.Write("Iyun ayi, ");
        //    }
        //    else if (182 <= value && value <= 212)
        //    {
        //        Console.Write("Iyul ayi, ");
        //    }
        //    else if (213 <= value && value <= 243)
        //    {
        //        Console.Write("Avqust ayi, ");
        //    }
        //    else if (244 <= value && value <= 273)
        //    {
        //        Console.Write("Sentyabr ayi, ");
        //    }
        //    else if (274 <= value && value <= 304)
        //    {
        //        Console.Write("Oktyabr ayi, ");
        //    }
        //    else if (305 <= value && value <= 334)
        //    {
        //        Console.Write("Noyabr ayi, ");
        //    }
        //    else 
        //    {
        //        Console.Write("Dekabr ayi, ");
        //    }

        //    if (21 <= value && value <= 49)
        //    {
        //        Console.Write(" Dolca burcu");
        //    }
        //    else if (50 <= value && value <= 79)
        //    {
        //        Console.Write(" Baliqlar burcu");
        //    }
        //    else if (80 <= value && value <= 110)
        //    {
        //        Console.Write(" Qoc burcu");
        //    }
        //    else if (111 <= value && value <= 140)
        //    {
        //        Console.Write(" Buga burcu");
        //    }
        //    else if (141 <= value && value <= 172)
        //    {
        //        Console.Write(" Ekizler burcu");
        //    }
        //    else if (173 <= value && value <= 202)
        //    {
        //        Console.Write(" Xerceng burcu");
        //    }
        //    else if (203 <= value && value <= 232)
        //    {
        //        Console.Write(" Sir burcu");
        //    }
        //    else if (233 <= value && value <= 263)
        //    {
        //        Console.Write(" Qiz burcu");
        //    }
        //    else if (264 <= value && value <= 294)
        //    {
        //        Console.Write(" Terezi burcu");
        //    }
        //    else if (295 <= value && value <= 324)
        //    {
        //        Console.Write(" Eqreb burcu");
        //    }
        //    else if (325 <= value && value <= 354)
        //    {
        //        Console.Write(" Oxatan burcu");
        //    }
        //    else
        //    {
        //        Console.Write(" Oglaq burcu");
        //    }

        #endregion

        #region Task 16
        // /*
        // 16)* Verilmish 6 reqemli ededde nece unikal reqem var ? ( UNIKAL- Ededin daxilde her reqemden bir numayende secilecek. Yekunda nece numayende olacaq?)
        // */
        //l1:
        //    Console.Write("ededi daxil edin: ");
        //    if (!int.TryParse(Console.ReadLine(), out int value))
        //    {
        //        Console.WriteLine("ededi duzgun daxil edin");
        //        goto l1;
        //    }
        //    if ((int)Math.Log10(value) + 1 != 6)
        //    {
        //        Console.WriteLine("ededi duzgun daxil edin");
        //        goto l1;    
        //    }
        //    int remainder_1 = value % 10;
        //    value /= 10;
        //    int remainder_2 = value % 10;
        //    value /= 10;
        //    int remainder_3 = value % 10;
        //    value /= 10;
        //    int remainder_4 = value % 10;
        //    value /= 10;
        //    int remainder_5 = value % 10;
        //    value /= 10;
        //    int remainder_6 = value % 10;
        //    value /= 10;
        //    int contains = 0;
        //    if (remainder_6 == remainder_5 || remainder_6 == remainder_4 || remainder_6 == remainder_3 || remainder_6 == remainder_2 || remainder_6 == remainder_1)
        //    {
        //        contains++;
        //        Console.Write(remainder_6);
        //    }
        //    if ((remainder_5 != remainder_6 ) && (remainder_5 == remainder_1 || remainder_5 == remainder_2 || remainder_5 == remainder_3 || remainder_5 == remainder_4))
        //    {
        //        contains++;
        //        Console.Write(remainder_5);
        //    }
        //    if ((remainder_4 != remainder_6 || remainder_4 != remainder_5) && ( remainder_4 == remainder_3 || remainder_4 == remainder_2 || remainder_4 == remainder_1))
        //    {
        //        contains++;
        //        Console.Write(remainder_4);
        //    }
        //    if ((remainder_3 != remainder_6 || remainder_3 != remainder_5 || remainder_3 != remainder_4) && ( remainder_3 == remainder_2 || remainder_3 == remainder_1))
        //    {
        //        contains++;
        //        Console.Write(remainder_3);
        //    }
        //    if ((remainder_2 != remainder_6 ||remainder_2 != remainder_5 || remainder_2 != remainder_4 || remainder_2 != remainder_3 ) && ( remainder_2 == remainder_1))
        //    {
        //        contains++;
        //        Console.Write(remainder_2);
        //    }
         
        //    Console.Write($" , {contains}");


            #endregion

        }




    }
}
