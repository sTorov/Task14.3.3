using System.Text;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var phoneBook = new List<Contact>
            {
                new Contact("Игорь", "Николаев", 79990000001, "igor@example.com"),
                new Contact("Сергей", "Довлатов", 79990000010, "serge@example.com"),
                new Contact("Анатолий", "Карпов", 79990000011, "anatoly@example.com"),
                new Contact("Валерий", "Леонтьев", 79990000012, "valera@example.com"),
                new Contact("Сергей", "Брин", 799900000013, "serg@example.com"),
                new Contact("Иннокентий", "Смоктуновский", 799900000013, "innokentii@example.com")
            };

            var sortedPhoneBook = phoneBook
                .OrderBy(c => c.Name)
                .ThenBy(c => c.LastName);

            while (true)
            {
                char ch = Console.ReadKey(true).KeyChar;
                Console.Clear();

                if (!char.IsDigit(ch))
                {
                    Console.WriteLine("Введите число!");
                    continue;
                }

                int number = int.Parse(ch.ToString());

                if (number > 0 && number < 4)
                {
                    var page = sortedPhoneBook.Skip((number - 1) * 2).Take(2);

                    Console.WriteLine($"{"Имя",-13}{"Фамилия",-16}{"Номер телефона",-17}Email\n");

                    foreach (var contact in page)
                        Console.WriteLine(contact);

                    Console.WriteLine($"\nСтраница {ch}");
                }
                else
                    Console.WriteLine($"Страница {ch} не существует!");
            }
        }
    }
}
