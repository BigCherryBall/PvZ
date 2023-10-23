using System;

namespace MathTool
{
    
    internal class MathHelper
    {

        #region<根据概率确定是否触发>
        /// <summary>
        /// 传入一个概率，确定事件是否触发
        /// </summary>
        /// <param name="probability">事件发生的概率</param>
        /// <returns>事件是否发生</returns>
        public static bool Probability_SingleEvent(float probability)
        {

            if (probability <= 0) return false;
            else if (probability >=1) return true;
            else
            {
                Random random = new Random(Guid.NewGuid().GetHashCode());
                int number = random.Next(1, 10001);
                if(number <= probability*10000) return true;
                else return false;
            }
        }
        /// <summary>
        /// 传入某一事件的概率和试验的次数，返回该事件具体发生的情况，True为发生了，False为不发生
        /// </summary>
        /// <param name="probability">事件的概率</param>
        /// <param name="times">试验次数</param>
        /// <returns>每次事件是否发生</returns>
#pragma warning disable CS8632 // 只能在 "#nullable" 注释上下文内的代码中使用可为 null 的引用类型的注释。
        public static bool[]? Probability_SingleEvent(float probability,int times)

        {
            if(times <= 0) return null;
            bool[] result = new bool[times];
            if (probability <= 0) return result;
            else if (probability >= 1)
            {
                for(int i = 0; i < times; i++)
                {
                    result[i] = true;
                }
                return result;
            }
            else
            {
                Random random = new Random(Guid.NewGuid().GetHashCode());
                for (int i = 0; i < times; i++)
                {
                    int number = random.Next(1, 10001);
                    if (number <= probability * 10000) result[i]=true;
                }
                return result;
            }
        }
        /// <summary>
        /// 传入一组互斥事件的概率数组，确定哪一个事件发生。概率数组的概率之和最好=1，返回的数组与传入的数组一一对应
        /// </summary>
        /// <param name="probabititly">概率数组</param>
        /// <returns>只有一个为True，所在位置表示该事件发生</returns>
        public static bool[]? Probability_SomeEventChooseOne(float[] probabititly)
        {
            if(probabititly == null ) return null;
            if(probabititly.Length == 0) return null;
            bool[] result = new bool[probabititly.Length];

            float probalititlyTotal = 0;
            for(int i = 0; i < probabititly.Length; i++)
            {
                probalititlyTotal +=probabititly[i];
            }
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int number = random.Next(1, (int)(probalititlyTotal * 10000)+1);
            float p = 0f; //概率累计
            for(int i =0;i<probabititly.Length;i++)
            {
                float q=p+probabititly[i];
               if (p * 10000 < number && number <=q*10000)
                {
                    result[i] = true;
                    break;
                }
               p = q;
            }
            return result;
        }
        /// <summary>
        /// 输入多个不相关事件的概率数组，返回各自是否发生
        /// </summary>
        /// <param name="probabititly">概率数组</param>
        /// <returns>各自是否发生</returns>
        public static bool[]? Probability_SomeEvent(float[] probabititly)
        {
            if (probabititly == null) return null;
            if (probabititly.Length == 0) return null;
            bool[] result = new bool[probabititly.Length];

            Random random = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i < probabititly.Length; i++)
            {
                int number =random.Next(1,10001);
                if(0<number && number <=probabititly[i]*10000)
                {
                    result[i]=true;
                }
            }
            return result;
        }
        #endregion
    }
}
