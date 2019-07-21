//////////////////////////////////////////////////
//
//    ソートをするために必要なメソッド
//

using static System.Console;

namespace SortSamples
{
    public static partial class Sort
    {
        // 比較・交換を行った回数
        public static int CompareCount;
        public static int SwapCount;

        // カウンタをリセットする
        public static void ResetCounters() => CompareCount = SwapCount = 0;

        // 配列の値の比較を行う
        private static int Compare(int[] array, int i, int j)
        {
            // カウンタをインクリメント
            ++CompareCount;

            // 前者が大きい場合は1,後者が大きい場合は-1,等しい場合は0
                 if(array[i] > array[j]) return  1;
            else if(array[i] < array[j]) return -1;
            else                         return  0;
        }

        // 配列の値の交換を行う
        private static void Swap(int[] array, int i, int j)
        {
            // カウンタをインクリメント
            ++SwapCount;

            // 配列内の値を交換する
            int tmp  = array[i];
            array[i] = array[j];
            array[j] = tmp;
        }

        // 配列の内容を表示する
        public static void Display(int[] array)
        {
            // 左括弧
            Write("[ ");

            // 配列の中身
            for(int i = 0; i < array.Length; ++i)
                Write(array[i] + (i == array.Length - 1 ? " " : ", "));

            // 右括弧
            WriteLine("]");
        }
    }
}