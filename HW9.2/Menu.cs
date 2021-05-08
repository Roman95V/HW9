using System;

namespace HW9._2
{
    public static class Menu
    {
        private static User _loggedUser;
        public static void ShowMenu()
        {
            while (true)
            {
                while (_loggedUser == null)
                {
                    Console.WriteLine("Виберіть дію:(1)-Авторизація,(2)-Реєстрація ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            AuthorizeUser();
                            break;
                        case "2":
                            RegistrationUser();
                            break;
                        default:
                            Console.WriteLine("Неправильна команда");
                            break;
                    }
                }

                while (_loggedUser != null)
                {
                    Console.WriteLine("Виберіть дію: \n 1.Внести гроші \n 2.Зняти гроші  \n 3.Обміняти гроші. \n 4.Вийти");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Deposit();
                            break;
                        case "2":
                            WithdrawMoney();
                            break;
                        case "3":
                            ExchangeCurrency();
                            break;
                        case "4":
                            Logout();
                            break;
                        default:
                            Console.WriteLine("Неправильна команда");
                            break;
                    }
                }
            }
        }

        private static void AuthorizeUser()
        {
            Console.WriteLine("Будь ласка, введіть логін:");
            var login = Console.ReadLine();

            Console.WriteLine("Будь ласка, введіть пароль:");
            var password = Console.ReadLine();

            _loggedUser = Actions.GetUser(login, password);

            if (_loggedUser != null)

                Console.WriteLine($"Успішна авторизація. Ласкаво просим");
            else
                Console.WriteLine("Не вірно введено логін або пароль");
        }

        private static void RegistrationUser()
        {
            Console.WriteLine("Будь ласка, введіть логін:");
            var login = Console.ReadLine();

            Console.WriteLine("Будь ласка, введіть пароль:");
            var password = Console.ReadLine();

            Actions.AddUser(login, password);

        }

        private static void Logout()
        {
            _loggedUser = null;
        }

        private static void Deposit()
        {
            Console.WriteLine("Виберіть гаманець, щоб внести депозит");
            var purse = ChoosePurse();

            Console.WriteLine("Введіть суму грошей:");
            double money = Convert.ToDouble(Console.ReadLine());

            purse.Money += money;
            Console.WriteLine("Внесок успішно внесений");

        }

        private static void PrintPurses()
        {
            foreach (var purse in Actions.GetPurses(_loggedUser))
                Console.WriteLine($"{Actions.GetPurses(_loggedUser).IndexOf(purse) + 1}.{purse.Currency}");
        }

        private static void WithdrawMoney()
        {
            var purse = ChoosePurse();
            Console.WriteLine($"Баланс: { purse.Money} {purse.Currency}");
            Console.WriteLine("Введіть суму грошей:");
            double money = Convert.ToDouble(Console.ReadLine());

            if (money <= purse.Money)
            {
                purse.Money -= money;
            }
            Console.WriteLine("Недостатньо грошей");

        }

        private static Purse ChoosePurse()
        {
            PrintPurses();
            Purse purse = null;
            Console.WriteLine("Введіть номер гаманця");
            while (purse == null)
                switch (Console.ReadLine())
                {
                    case "1":
                        purse = _loggedUser.Purses[0];
                        break;
                    case "2" when _loggedUser.Purses.Count > 1:
                        purse = _loggedUser.Purses[1];
                        break;
                    case "3" when _loggedUser.Purses.Count > 2:
                        purse = _loggedUser.Purses[2];
                        break;
                    case "4" when _loggedUser.Purses.Count > 3:
                        purse = _loggedUser.Purses[3];
                        break;
                    case "5" when _loggedUser.Purses.Count > 4:
                        purse = _loggedUser.Purses[4];
                        break;
                    default:
                        Console.WriteLine("Неправильна команда");
                        break;
                }
            return purse;
        }

        private static void ExchangeCurrency()
        {
            var selectAction = new SelectAction();
            selectAction.Menu();

        }
    }
}
