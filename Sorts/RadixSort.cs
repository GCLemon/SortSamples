//////////////////////////////////////////////////
//
//    基数ソート
//

using System.Collections.Generic;

namespace SortSamples
{
    public static partial class Sort
    {
        public static void RadixSort(int[] array)
        {
            // バケットの作成
            Queue<int>[] Buckets = new Queue<int>[16];
            for(int i = 0; i < 16; ++i) Buckets[i] = new Queue<int>();

            int n = 1;

            // 16進数の各々の位に対して処理
            // int型の数値は16進法において8桁以内で表される
            for(int i = 0; i < 8; ++i)
            {
                // 対応するバケットにエンキュー
                for(int j = 0; j < array.Length; ++j)
                    Buckets[(array[j] / n) % 16].Enqueue(array[j]);

                // バケットのデータを片っ端からデキューして,
                // 各位がソートされた状態にする
                int array_count = 0;
                for(int j = 0; j < 16; ++j)
                {
                    while(Buckets[j].Count != 0)
                    {
                        array[array_count] = Buckets[j].Dequeue();
                        ++array_count;
                    }
                }

                // 位を一つ進める
                n *= 16;
            }
        }
    }
}