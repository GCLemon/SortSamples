using System;
using static System.Console;
using static SortSamples.Sort;

namespace SortSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length >= 2)
            {
                // データを格納する配列
                int[] data = new int[Int32.Parse(args[1])];

                // データを標準入力から受け取る
                for(int i = 0; i < Int32.Parse(args[1]); ++i)
                    data[i] = Int32.Parse(ReadLine());

                // カウンタをリセットする
                ResetCounters();

                // ソートする
                switch(args[0])
                {
                    // 指定された文字列に対応したソートを実行
                    case "bogo"  : BogoSort(data);      break;
                    case "bubble": BubbleSort(data);    break;
                    case "count" : CountingSort(data);  break;
                    case "heap"  : HeapSort(data);      break;
                    case "insert": InsertionSort(data); break;
                    case "merge" : MergeSort(data);     break;
                    case "quick" : QuickSort(data);     break;
                    case "radix" : RadixSort(data);     break;
                    case "select": SelectionSort(data); break;
                    case "shell" : ShellSort(data);      break;

                    // 上記以外が指定されていた場合は挿入ソートを行う
                    default      : InsertionSort(data); break;
                }

                // ソート結果を表示する
                Display(data);

                // 比較回数を表示する
                switch(CompareCount)
                {
                    case 0 : WriteLine("No comparsion occured.");              break;
                    case 1 : WriteLine("1 comparsion occured.");               break;
                    default: WriteLine(CompareCount + "comparsions occured."); break;
                }

                // 交換回数を表示する
                switch(SwapCount)
                {
                    case 0 : WriteLine("No swap occured.");          break;
                    case 1 : WriteLine("1 swap occured.");           break;
                    default: WriteLine(SwapCount + "swaps occured."); break;
                }
            }
        }
    }
}
