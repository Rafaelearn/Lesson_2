using System;

namespace Classwork
{
    struct Client
    {
        public string name;
        public string city;
        public byte age;
        public ushort pin;

    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nTask 1\nОбласти значений типов данных:");
            Console.WriteLine("byte [{0}; {1}]", Byte.MinValue, Byte.MaxValue);
            Console.WriteLine("sbyte [{0}; {1}]", SByte.MinValue, SByte.MaxValue);
            Console.WriteLine("short [{0}; {1}]", Int16.MinValue, Int16.MaxValue);
            Console.WriteLine("ushort [{0}; {1}]", UInt16.MinValue, UInt16.MaxValue);
            Console.WriteLine("int [{0}; {1}]", Int32.MinValue, Int32.MaxValue);
            Console.WriteLine("uint [{0}; {1}]", UInt32.MinValue, UInt32.MaxValue);
            Console.WriteLine("long [{0}; {1}]", Int64.MinValue, Int64.MaxValue);
            Console.WriteLine("ulong [{0}; {1}]", UInt64.MinValue, UInt64.MaxValue);
            Console.WriteLine("float [{0}; {1}]", Single.MinValue, Single.MaxValue);
            Console.WriteLine("double [{0}; {1}]", Double.MinValue, Double.MaxValue);
            Console.WriteLine("decimal [{0}; {1}]", Decimal.MinValue, Decimal.MaxValue);
            Console.WriteLine("char [{0}; {1}]", Char.MinValue, Char.MaxValue);


            Console.WriteLine("\nTask 2");
            Client user;
            Console.Write("Введите имя: ");
            user.name = Console.ReadLine();
            Console.Write("Введите город: ");
            user.city = Console.ReadLine();
            Console.Write("Введите возраст: ");
            user.age = Convert.ToByte(Console.ReadLine());
            Console.Write("Введите пин-код: ");
            user.pin = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine($"Данные о клиенте:\nИмя\t{user.name}\nГород\t{user.city}\nВозраст\t{user.age}\nПин-код\t{user.pin}");


            Console.WriteLine("\nTask 3");
            Console.Write("Введите строку: ");
            string str1 = Console.ReadLine();
            string str2 = "";
            int i = 0;
            for (; i < str1.Length; i++)
            {
                if (char.ToLower(str1[i]) == str1[i])
                {
                    str2 += char.ToUpper(str1[i]);
                }
                else
                {
                    str2 += char.ToLower(str1[i]);
                }
            }
            Console.WriteLine("После форматирования: " + str2);


            Console.WriteLine("\nTask 4");
            Console.Write("Введите строку: ");
            str1 = Console.ReadLine();
            Console.Write("Введите подстроку: ");
            str2 = Console.ReadLine();
            int count = -1;
            count = (str1.Length - str1.Replace(str2, "").Length) / str2.Length;
            Console.WriteLine($"Количество вхождений: {count}");


            Console.WriteLine("\nTask 5");
            Console.Write("Введите скорость тараканчика в км/ч: ");
            float cockroachSpeed = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"Скорость таракана в см/сек: {SpeedConvert(cockroachSpeed)}");


            Console.WriteLine("\nTask 6");
            Console.Write("Введите возраст отца: ");
            byte ageDad = Convert.ToByte(Console.ReadLine());
            Console.Write("Введите возраст сына: ");
            byte ageSon = Convert.ToByte(Console.ReadLine());
            if (ageDad < 2 * ageSon)
            {
                Console.WriteLine($"Через {AgeDouble(ageDad, ageSon)} лет Отец будет вдвое старше сына");
            }
            else if (ageDad > 2 * ageSon)
            {
                Console.WriteLine($"  {AgeDouble(ageDad, ageSon)} лет назад Отец был вдвое старше сына");
            }
            else
            {
                Console.WriteLine("Отец вдвое старше сына");
            }


            Console.WriteLine("\nTask 7");
            Console.Write("Цена бутылки виски: ");
            try
            {
                ushort normPrice = Convert.ToUInt16(Console.ReadLine());
                Console.Write("Скидка в %: ");
                byte salePrice = Convert.ToByte(Console.ReadLine());
                Console.Write("Стоимость отпуска: ");
                int holidayPrice = Convert.ToInt32(Console.ReadLine());
                float numBottle = (float)holidayPrice / (normPrice * ((float)salePrice / 100));
                Console.WriteLine($"Дабы покрыть Ваши расходы купите {Math.Floor(numBottle)} бутылок отменного виски");
            }
            catch (Exception)
            {

                throw;
            }
            

            Console.ReadKey();
        }
        
        static byte SpeedConvert(float x)
        {
            x /= 0.036f;
            return (byte)(Math.Floor(x));
        }

        static byte AgeDouble(byte ageDad, byte ageSon)
        {
            return (byte)Math.Abs(ageDad - 2 * ageSon);
        }


    }
}
