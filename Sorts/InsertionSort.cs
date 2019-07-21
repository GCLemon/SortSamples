//////////////////////////////////////////////////
//
//    挿入ソート
//

namespace SortSamples
{
    public static partial class Sort
    {
        public static void InsertionSort(int[] array)
        {
            for(int i = 1; i < array.Length; ++i)
            {
                // ソート部分に対して処理
                for(int j = i; j > 0; --j)
                {
                    // 自身の値が一つ前の値以上になった場合はループを終える
                    if(Compare(array, j, j - 1) >= 0) break;

                    // その他の場合は値を交換する
                    else Swap(array, j , j - 1);
                }
            }
        }
    }
}