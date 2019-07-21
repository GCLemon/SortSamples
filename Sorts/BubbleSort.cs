//////////////////////////////////////////////////
//
//    バブルソート
//

namespace SortSamples
{
    public static partial class Sort
    {
        public static void BubbleSort(int[] array)
        {
            for(int i = array.Length - 1; i > 0; --i)

                // 未ソート部分に対して処理
                for(int j = 0; j < i; ++j)

                    // 一つ後の値と比較して,自身の方が大きかった場合は交換する
                    if(Compare(array, j, j + 1) == 1) Swap(array, j , j + 1);
                    
        }
    }
}