using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Pupil
    {
        public virtual void Study() => Console.WriteLine("Навчається на середньому рівні.");
        public virtual void Read() => Console.WriteLine("Читає на середньому рівні.");
        public virtual void Write() => Console.WriteLine("Пише на середньому рівні.");
        public virtual void Relax() => Console.WriteLine("Відпочиває на середньому рівні.");
    }

    class ExcelentPupil : Pupil
    {
        public override void Study() => Console.WriteLine("Навчається відмінно.");
        public override void Read() => Console.WriteLine("Читає швидко і вдумливо.");
        public override void Write() => Console.WriteLine("Пише без помилок.");
        public override void Relax() => Console.WriteLine("Відпочиває рідко.");
    }

    class GoodPupil : Pupil
    {
        public override void Study() => Console.WriteLine("Навчається добре.");
        public override void Read() => Console.WriteLine("Читає з розумінням.");
        public override void Write() => Console.WriteLine("Пише майже без помилок.");
        public override void Relax() => Console.WriteLine("Відпочиває у вільний час.");
    }


    class BadPupil : Pupil
    {
        public override void Study() => Console.WriteLine("Навчається погано.");
        public override void Read() => Console.WriteLine("Читає повільно.");
        public override void Write() => Console.WriteLine("Пише з помилками.");
        public override void Relax() => Console.WriteLine("Відпочиває більше, ніж навчається.");
    }


    class ClassRoom
    {
        private Pupil[] pupils = new Pupil[4];

        public ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            pupils[0] = pupil1;
            pupils[1] = pupil2;
            pupils[2] = new GoodPupil();
            pupils[3] = new BadPupil();
        }
        public void ShowPupilsInfo()
        {
            for (int i = 0; i < pupils.Length; i++)
            {
                Console.WriteLine($"Учень {i + 1}:");
                pupils[i].Study();
                pupils[i].Read();
                pupils[i].Write();
                pupils[i].Relax();
                Console.WriteLine();
            }
        }
    }

}
