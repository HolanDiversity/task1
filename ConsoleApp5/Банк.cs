using System;
namespace ConsoleApp5
{

    class Банк : Bank
    {

        static void Main(string[] args)
        {
            Bank Polz1 = new Bank();


            int i = 1;
            while (i != 0)
            {
                int caseSwitch = Console.Read();
                switch (caseSwitch)
                {
                    case 1:
                        Polz1.Rename();
                        break;
                    case 2:
                        Polz1.Deposit();
                        break;
                    case 3:
                        Polz1.Withdraw();
                        break;
                    case 4:
                        Polz1.DepositProc();
                        break;
                    case 5:
                        Polz1.ConvertRubl();
                        break;
                    case 6:
                        Polz1.ConvertDoll();
                        break;
                    case 7:
                        Polz1.ConvertEuro();
                        break;
                    case 8:
                        Polz1.Write();
                        break;
                    case 0:
                        Console.WriteLine("Заканчиваем работу");
                        i = caseSwitch;
                        break;
                    default:
                        Console.WriteLine("Неизвестно");
                        break;

                }
            }
                    

            Console.ReadKey();
        }
    }
}