//////////////////////////////////////////////////
//
//    クイックソート
//

namespace SortSamples
{
    public static partial class Sort
    {
        public static void QuickSort(int[] array, int left = 0, int right = -1)
        {
            if(right == -1) right = array.Length - 1;

            // もし,配列の左端が右端より右側にあった場合
            // クイックソートを行う必要はないため,処理を終える
            if(left >= right) return;

            int l = 0, r = 0;       

            // 配列を左右に分離する
            while(true)
            {
                // 配列の指定された部分の右端をピボットとする
                // ピボット以外の部分の左端・右端を決定する
                l = left;
                r = right - 1; 

                // 配列の左端からピボットの値より大きなものを線形探索
                while(l < right && Compare(array, l, right) == -1) ++l;

                // 配列の右端からピボットの値以下のを線形探索
                while(l < r     && Compare(array, r, right) >=  0) --r;

                // 交換されるべき値が発見された場合は交換する
                if(l < r) Swap(array, l, r);

                // そうでなければ分離を完了する
                else break;
            }

            // ピボットと,求めたlを交換する
            Swap(array, l, right);

            // 分離した左右についてクイックソートを行う
            QuickSort(array, left,  l - 1);
            QuickSort(array, l + 1, right);
        }
    }
}