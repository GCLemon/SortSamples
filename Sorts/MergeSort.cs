//////////////////////////////////////////////////
//
//    マージソート
//

namespace SortSamples
{
    public static partial class Sort
    {
        public static void MergeSort(int[] array, int left = 0, int right = -1)
        {
            if(right == -1) right = array.Length - 1;

            // もし,配列の左端が右端より右側にあった場合
            // マージソートを行う必要はないため,処理を終える
            if(left >= right) return;

            // 配列の中間を求める
            int c = (left + right) / 2;

            // 配列の左右についてマージソート
            MergeSort(array, left , c    );
            MergeSort(array, c + 1, right);

            // マージソート結果を格納する配列を作る
            int[] result = new int[right - left + 1];

            int l = left, r = c + 1;
            for(int i = 0; i < result.Length; ++i)
            {
                // lの値が配列の中間を過ぎた場合
                if(l > c)
                {
                    // 配列に値を格納してrを一つ進める
                    result[i] = array[r]; ++r;
                }

                // rの値が配列の末尾を過ぎた場合
                else if(r > right)
                {
                    // 配列に値を格納してlを一つ進める
                    result[i] = array[l]; ++l;
                }

                // それ以外の場合
                else
                {
                    // 配列の対応する部分を比べて,小さいものを選ぶ
                    // 等しい場合は右側を選ぶ
                    switch(Compare(array, l, r))
                    {
                        case -1:
                            // 配列に値を格納してlを一つ進める
                            result[i] = array[l]; ++l; break;
                        case  0:
                        case  1:
                            // 配列に値を格納してrを一つ進める
                            result[i] = array[r]; ++r; break;
                    }
                }
            }

            // 配列に格納して終わり
            for(int i = 0; i <= right - left; ++i)
                array[i + left] = result[i];
        }
    }
}