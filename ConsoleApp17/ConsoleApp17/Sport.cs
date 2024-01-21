using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    class Sport
    {
        /// <summary>
        /// приватное поле описывающее ФИО спортсменов
        /// </summary>
        private string fio;
        /// <summary>
        /// свойство поля реализующее проверку значений
        /// </summary>
        public string Fio
        {
            set { fio =value; }
            get { return (fio == "") ?"Ошибка":fio;}
        }
        /// <summary>
        /// приватное поле описывающее рост спорстменов
        /// </summary>
        private int height;
        /// <summary>
        /// свойство реализующее проверку значений
        /// </summary>
        public int Height
        {
            set { height = (value<150||value>200) ?0:value; }
            get { return height; }
        }
        /// <summary>
        /// приватное поле описывающее вес спорстменов
        /// </summary>
        private int weight;
        /// <summary>
        /// свойство реализующее проверку значений
        /// </summary>
        public int Weight
        {
            set { weight = (value<60||value>120) ?0:value; }
            get { return weight; }
        }
        /// <summary>
        /// конструктор без параметров
        /// </summary>
        public Sport() { }
        /// <summary>
        /// конструктор с параметрами
        /// </summary>
        /// <param name="fio">ФИО</param>
        /// <param name="height">рост</param>
        /// <param name="weight">вес</param>
        public Sport(string fio,int height,int weight)
        {
            Fio = fio;
            Height = height;
            Weight = weight;
            if(weight>70)
            {
                weight70++;
            }
        }
        /// <summary>
        /// статический параметр реализующий подсчет спорстменов с весом более 70кг
        /// </summary>
        static public int weight70;
        /// <summary>
        /// статический конструктор присвающий статитечскому полю значение 0
        /// </summary>
        static Sport()
        {
            weight70 = 0;
        }
        /// <summary>
        /// метод для вывода информации
        /// </summary>
        public void ShowInfo()
        {
            Console.WriteLine($"ФИО={Fio}\tРост={Height}\tВес={Weight}");
        }
    }
}
