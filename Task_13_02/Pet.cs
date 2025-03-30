using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_02
{
    internal class Pet
    {
        #region поля
        private string nickname; //закрытое поле клички
        private string animal; //закрытое поле вида животного
        private int age; //закрытое поле возраста
        private int weight; //закрытое поле веса
        private bool health; //закрытое поле отметки о состоянии здоровья (здоров/нездоров)
        private string healths; //закрытое поле здоров/нездоров
        #endregion

        #region свойства
        public string Nickname
        {
            get { return nickname; } //аксессор для чтения значения поля
            set                  //аксессор для записи значения в поле
            {
                if (value != null) //если приходящее значение не null
                    nickname = value;   //то в поле записывается приходящее значение
                else Console.WriteLine("Warning! name is empty"); //иначе выводится сообщение о некорректных вх данных и запись в поле не происходит
            }
        }
        public string Animal
        {
            get { return animal; } //аксессор для чтения значения поля
            set                  //аксессор для записи значения в поле
            {
                if (value != null) //если приходящее значение не null
                    animal = value;   //то в поле записывается приходящее значение
                else Console.WriteLine("Warning! name is empty"); //иначе выводится сообщение о некорректных вх данных и запись в поле не происходит
            }
        }
        public int Age
        {
            get { return age; } //аксессор для чтения значения поля
            set                  //аксессор для записи значения в поле
            {
                age = 5;   //в поле записывается приходящее значение            
            }
        }
        public int Weight
        {
            get { return weight; } //аксессор для чтения значения поля
            set                  //аксессор для записи значения в поле
            {
                weight = 5;   //в поле записывается приходящее значение                
            }
        }
        public bool Health
        {
            get { return health; } //аксессор для чтения значения поля
            set                  //аксессор для записи значения в поле
            {
                if (health == false) //если приходящее значение не null
                    healths = "нездоров";   //в поле записывается приходящее значение
                else healths = "здоров";//иначе в поле записывается другое приходящее значение
            }
        }
        #endregion
        public string GetInfo()
        {
            return $"Кличка: {nickname} \nВид животного: {animal} \nВозраст: {age}\n" +
                $"Вес: {weight} \nСостояние здоровья: {healths}";
        }
        public Pet(string nickname, string animal)
        {
            this.nickname = nickname;
            this.animal = animal;
        }

    }
}
