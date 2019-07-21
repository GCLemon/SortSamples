//////////////////////////////////////////////////
//
//    ボゴソート
//

using System;

namespace SortSamples
{
    public static partial class Sort
    {
        public static void BogoSort(int[] array)
        {
            // 乱数オブジェクト
            Random random = new Random();

            while(true)
            {
                // 配列をシャッフルする
                Swap(array, random.Next(array.Length), random.Next(array.Length));

                // ソートされたかを判定
                bool sorted = true;
                for(int i = 0; i < array.Length - 1; ++i)

                    // 大小関係が逆になった時点でfalseになる
                    sorted &= Compare(array, i, i + 1) != 1;

                // ソートされていたら終わり
                if(sorted) break;

                // 比較回数が100万を超えたらタイムアウト
                if(CompareCount > 100_0000)
                {
                    Console.WriteLine("TIME OUT!!!!!");
                    break;
                }
            }
        }
    }
}