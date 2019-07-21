//////////////////////////////////////////////////
//
//    計数ソート
//

namespace SortSamples
{
    public static partial class Sort
    {
        public static void CountingSort(int[] array)
        {
            // 1週目 : 配列に格納されている値の最大値・最小値を取得
            int minimum = array[0], maximum = array[0];
            for(int i = 1; i < array.Length; ++i)
            {
                // 検出した値が最小値を下回った場合,最小値を更新
                if(array[i] < minimum) minimum = array[i];

                // 検出した値が最大値を上回った場合,最大値を更新
                if(array[i] > maximum) maximum = array[i];
            }

            // 2週目 : どの値がどれくらい含まれているかを数える
            int[] count = new int[maximum - minimum + 1];
            for(int i = 0; i < array.Length; ++i) ++count[array[i] - minimum];

            // 3週目 : 数え上げた情報をもとにソートを行う
            int array_count = 0;
            for(int i = minimum; i <= maximum; ++i)
            {
                for(int j = 0; j < count[i - minimum]; ++j)
                {
                    array[array_count] = i;
                    ++array_count;
                }
            }
        }
    }
}