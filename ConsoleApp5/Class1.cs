using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class Bank : Propis
    {
        string FIO = "Новый пользователь";
        double NomerScheta = 1234567812345678;
        double SummaRubl = 0;
        double SummaDoll = 0;
        double SummaEuro = 0;
        double ProcentNach = 0;

        public Bank()
        {
            Console.WriteLine("Владелец:", FIO);
            Console.WriteLine("Номер счета:", NomerScheta);
            Console.WriteLine("Сумма счета:", SummaRubl);
            Console.WriteLine("Процент начисления:", ProcentNach);
            Console.WriteLine("Сумма в Долларах:", SummaDoll);
            Console.WriteLine("Сумма в Евро:", SummaEuro);
        }

        public void Rename()
        {
            string FIO = Console.ReadLine();
            Console.WriteLine("Пользователь:", FIO);
        }

        public void Deposit()
        {
            SummaRubl = SummaRubl + Console.Read();
            Console.WriteLine("Сумма счета:", SummaRubl);
        }

        public void Withdraw()
        {
            SummaRubl = SummaRubl - Console.Read();
            Console.WriteLine("Сумма счета:", SummaRubl);
        }

        public void DepositProc()
        {
            ProcentNach = ProcentNach + Console.Read();
            Console.WriteLine("Процент начисления:", ProcentNach);
        }

        public void ConvertRubl()
        {
            if (SummaDoll != 0)
            {
                SummaRubl = SummaRubl + SummaDoll * 64.48;
            }

            if (SummaEuro != 0)
            {
                SummaRubl = SummaRubl + SummaEuro * 72.12;
            }

            Console.WriteLine("Все наличные кновертированы в рубли. Ваш счет:", SummaRubl);
        }

        public void ConvertDoll()
        {
            if (SummaRubl != 0)
            {
                SummaDoll = SummaRubl / 64.48;
                Console.WriteLine("Ваш Долларовый счет:", SummaDoll);
            }
        }

        public void ConvertEuro()
        {
            if (SummaRubl != 0)
            {
                SummaEuro = SummaRubl / 72.12;
                Console.WriteLine("Ваш Евро счет:", SummaEuro);
            }
        }

        public void Write()
        {
            int val = Console.Read();
            Console.WriteLine(Propis.Str(val));
        }
    }   
}
