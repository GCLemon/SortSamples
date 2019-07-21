//////////////////////////////////////////////////
//
//    選択ソート
//

namespace SortSamples
{
    public static partial class Sort
    {
        public static void SelectionSort(int[] array)
        {
            for(int i = 0; i < array.Length; ++i)
            {
                // 最小値が格納されている位置
                int min_i = i;

                // 未ソート部分に対して処理
                for(int j = i; j < array.Length; ++j)

                    // 最小値より小さい値が見つかった場合,min_iの値を変更する
                    if(Compare(array, min_i, j) == 1) min_i = j;

                // 最小値と未ソート部分の先頭と値を交換する
                Swap(array, i, min_i);
            }
        }
    }
}