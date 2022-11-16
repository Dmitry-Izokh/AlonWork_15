using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlonWork_15
{
    interface ISeries
    {
        /* Разработать интерфейс ISeries генерации ряда чисел. Интерфейс содержит следующие элементы:
         * метод void SetStart(int x) - устанавливает начальное значение
         * метод int GetNext() - возвращает следующее число ряда
         * метод void Reset() - выполняет сброс к начальному значению
         * Разработать классы ArithProgression и GeomProgression, которые реализуют интерфейс ISeries. 
         * В классах реализовать методы интерфейса в соответствии с логикой арифметической и геометрической
         * прогрессии соответственно. */
        void SetStart(int x);
        int GetNext();
        void Reset();
    }
    class ArithProgression : ISeries
    {
        int step;
        int startValue;
        int currentValue;
        int nunberStep;

        public int GetNext()
        {
            currentValue += step;
            return currentValue;
        }

        public int GetNext2()
        {
            currentValue *= step;
            return currentValue;
        }

        public void Reset()
        {
            currentValue = startValue;
        }

        public void SetStart(int x)
        {
            startValue=x;
            currentValue = startValue;
        }

        public void setStep(int s)
        {
            step = s;
        }

        public void ShowStart()
        {
            Console.WriteLine(startValue);
        }

        public void numberStep(int i)
        {
            nunberStep = i;
        }

        public void NStep()
        {
            int n = nunberStep;
            for(int a=0; a<=n; a++)
            {
                Console.Write("Шаг {0} = ", a);
                Console.WriteLine(GetNext());
            }            
        }
        public void NStep2()
        {
            int n = nunberStep;
            for (int a = 0; a <= n; a++)
            {
                Console.Write("Шаг {0} = ", a);
                Console.WriteLine(GetNext2());
            }
        }


    }
}
