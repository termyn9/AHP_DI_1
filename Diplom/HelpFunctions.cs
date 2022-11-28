using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diplom
{
    public class HelpFunctions
    {
        public static string[] ListBoxFactors = 
        { 
            "Степень секретности",
            "Объёмы",
            "Интенсивность обработки",
            "Геометрические размеры",
            "Территориальная распределённость",
            "Структурированность компонентов",
            "Расположение в населённом пункте",
            "Расположение на территории объекта",
            "Обустроенность",
            "Масштаб",
            "Стабильность",
            "Доступность",
            "Общая постановка дела",
            "Укомплектованность кадрами",
            "Уровень подготовки и воспитания кадров"
        };

        public static string[] ListBoxRequirements =
        {
            "Идентификация и аутентификация пользователей, являющихся работниками оператора",
            "Управление идентификаторами, в том числе создание, присвоение, уничтожение идентификаторов",
            "Управление средствами аутентификации, в том числе хранение выдача, инициализация, блокирование средств аутентификации и принятие мер в случае утраты и (или) компрометации средств аутентификации",
            "Защита обратной связи при вводе аутентификационной информации",
            "Идентификация и аутентификация пользователей, не являющихся работниками оператора (внешних пользователей)"
        };

        public static double FractionToDouble(string fraction)
        {
            double result;

            if (double.TryParse(fraction, out result))
            {
                return result;
            }

            string[] split = fraction.Split(new char[] { ' ', '/' });

            if (split.Length == 2 || split.Length == 3)
            {
                int a, b;

                if (int.TryParse(split[0], out a) && int.TryParse(split[1], out b))
                {
                    if (split.Length == 2)
                    {
                        return (double)a / b;
                    }

                    int c;

                    if (int.TryParse(split[2], out c))
                    {
                        return a + (double)b / c;
                    }
                }
            }

            throw new FormatException("Not a valid fraction.");
        }


    }
}
