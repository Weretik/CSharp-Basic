using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *Завдання 3 

Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 

Потрібно: 

Створіть 2 інтерфейси IPlayable та IRecodable. У кожному з інтерфейсів створіть по 3 методи 
void Play() / void Pause() / void Stop() 
та void Record() / void Pause() / void Stop() відповідно. 
Створіть похідний клас Player від базових інтерфейсів IPlayable та IRecodable.
Написати програму, яка виконує програвання та запис.
*/

namespace Abstraction
{
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }
    interface IRecodable
    {
        void Record();
        void Pause();
        void Stop();
    }

    class Player : IPlayable, IRecodable 
    {
        public void Play() 
        {
            Console.WriteLine("Гравець грає в гру");
        }
        public void Record() 
        {
            Console.WriteLine("Гравець розпочинає запис гри");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Гравець поставив гру на паузу");
        }
        void IRecodable.Pause()
        {
            Console.WriteLine("Гравець поставив запис гри на паузу");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Гравець закінчив грати");
        }
        void IRecodable.Stop()
        {
            Console.WriteLine("Гравець закінчив запис гри");
        }
    }
}
