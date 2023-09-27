using System;



namespace Lab02
{
   internal class Program
    {
        static void Main()
        {
            ExcellentPupil ePupil = new ExcellentPupil();
            GoodPupil gPupil = new GoodPupil();
            BadPupil bPupil = new BadPupil();

            ClassRoom class1 = new ClassRoom(ePupil, ePupil, gPupil, bPupil);
            ClassRoom class2 = new ClassRoom(ePupil, gPupil, bPupil);

            Console.WriteLine("Класс #1");
            class1.Study();
            class1.Read();
            class1.Write();
            class1.Relax();
            class1.GetInfo();

            Console.WriteLine("\n\nКласс #2");
            class2.Study();
            class2.Read();
            class2.Write();
            class2.Relax();
            class2.GetInfo();

        }
    }

    class ClassRoom
    {
        Pupil[] pupils;

        public ClassRoom(params Pupil[] pupils)
        {
            this.pupils = pupils;
        }

        public void Study()
        {
            foreach (Pupil pupil in pupils)
            {
                pupil.Study();
            }
        }

        public void Read()
        {
            foreach (Pupil pupil in pupils)
            {
                pupil.Read();
            }
        }

        public void Write()
        {
            foreach (Pupil pupil in pupils)
            {
                pupil.Write();
            }
        }

        public void Relax()
        {
            foreach (Pupil pupil in pupils)
            {
                pupil.Relax();
            }
        }



        public void GetInfo()
        {
            int Exclnum = 0, Goodnum = 0, Badnum = 0;
            foreach (Pupil i in pupils)
            {
                if (i is ExcellentPupil) Exclnum++;
                else if (i is GoodPupil) Goodnum++;
                else if (i is BadPupil) Badnum++;
            }
            Console.WriteLine($"В классе {Exclnum} отличных, {Goodnum} хороших и {Badnum} плохих учеников");
        }


    }

    public class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Ученик учится");
        }

        public virtual void Read()
        {
            Console.WriteLine("Ученик читает");
        }
        public virtual void Write()
        {
            Console.WriteLine("Ученик пишет");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Ученик отдыхает");
        }

    }

    public class ExcellentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Превосходный Ученик учится");
        }

        public override void Read()
        {
            Console.WriteLine("Превосходный Ученик читает");
        }
        public override void Write()
        {
            Console.WriteLine("Превосходный Ученик пишет");
        }
        public override void Relax()
        {
            Console.WriteLine("Превосходный Ученик отдыхает");
        }
    }

    public class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Хороший Ученик учится");
        }

        public override void Read()
        {
            Console.WriteLine("Хороший Ученик читает");
        }
        public override void Write()
        {
            Console.WriteLine("Хороший Ученик пишет");
        }
        public override void Relax()
        {
            Console.WriteLine("Хороший Ученик отдыхает");
        }
    }

    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("Плохой Ученик учится");
        }

        public override void Read()
        {
            Console.WriteLine("Плохой Ученик читает");
        }
        public override void Write()
        {
            Console.WriteLine("Превосходный Ученик пишет");
        }
        public override void Relax()
        {
            Console.WriteLine("Превосходный Ученик отдыхает");
        }
    }

}