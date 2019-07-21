//////////////////////////////////////////////////
//
//    シェルソート
//

namespace SortSamples
{
    public static partial class Sort
    {
        public static void ShellSort(int[] array)
        {
            // 適当な間隔hを決定する
            int h = 1;
            while(h * 4 < array.Length) h *= 2;

            // 間隔hを狭めつつ処理を行う
            for(; h >= 1; h /= 2)
            {
                // 挿入ソートを行う
                for(int i = h; i < array.Length; ++i)
                {
                    // ソート部分に対して処理
                    for(int j = i; j >= h; j -= h)
                    {
                        // 自身の値が一つ前の値以上になった場合はループを終える
                        if(Compare(array, j, j - h) >= 0) break;

                        // その他の場合は値を交換する
                        else Swap(array, j , j - h);
                    }
                }
            }
        }
    }
}