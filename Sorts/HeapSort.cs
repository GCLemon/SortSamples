//////////////////////////////////////////////////
//
//    ヒープソート
//

namespace SortSamples
{
    public static partial class Sort
    {
        public static void HeapSort(int[] array)
        {
            // ヒープを構成する
            for(int i = 1; i < array.Length; ++i)
            {
                for(int j = i, p = 0; j > 0; j = p)
                {
                    // 親のノード番号を求める
                    p = (j - 1) / 2;

                    // 親と比較して自身の方が大きかった場合,交換する
                    if(Compare(array, j, p) == 1) Swap(array, j, p);
                }
            }

            // 根の削除・シフトダウンを繰り返す
            for(int i = array.Length - 1; i >= 0; --i)
            {
                // ヒープの根を削除する(すなわちヒープの先頭と末尾を交換する)
                Swap(array, 0, i);

                // シフトダウン操作を行う
                for(int j = 0, c = 0; j < i; j = c)
                {
                    int c_l = j * 2 + 1; // 左の子ノードの番号
                    int c_r = j * 2 + 2; // 右の子ノードの番号

                    // 左の子ノードの番号が削除後のヒープの大きさ未満であり
                    // かつ値を比較して自身の方が小さかった場合,trueになる
                    bool smaller_l =
                        c_l < i && Compare(array, j, c_l) == -1;

                    // 右の子ノードについても同様の操作をする
                    bool smaller_r =
                        c_r < i && Compare(array, j, c_r) == -1;

                    // 両方trueだった場合
                    if(smaller_l && smaller_r)
                    {
                        // 左右の子の値を比較し,大きいものと交換する
                        // 等しかった場合は右の子と交換する
                        switch(Compare(array, c_l, c_r))
                        {
                            case -1:
                            case  0: Swap(array, j, c_r); c = c_r; break;
                            case  1: Swap(array, j, c_l); c = c_l; break;
                        }
                    }

                    // smaller_lだけtrueだった場合,左の子と交換する
                    else if(smaller_l) { Swap(array, j, c_l); c = c_l; }

                    // smaller_rだけtrueだった場合,右の子と交換する
                    else if(smaller_r) { Swap(array, j, c_r); c = c_r; }

                    // それ以外の場合,シフトダウン操作を終える
                    else break;
                }
            }
        }
    }
}