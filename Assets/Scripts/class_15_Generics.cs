using AES.Tools;
using UnityEngine;
namespace KID.Class_15
{
    /// <summary>
    /// 泛型 Generics
    /// </summary>
    public class class_15_Generics : MonoBehaviour
    {
        private void Awake()
        {
            int numberA = 7, numberB = 9;
            LogSystem.LogWithColor($"數字 A 與 B：{numberA}|{numberB}", "#f93");
            SwapNumber(ref numberA, ref numberB);
            LogSystem.LogWithColor($"數字 A 與 B：{numberA}|{numberB}", "#f93");

            char charA = '嗨', charB = '嘿';
            LogSystem.LogWithColor($"字元 A 與 B：{charA}|{charB}", "#9f3");
            SwapChar(ref charA, ref charB);
            LogSystem.LogWithColor($"字元 A 與 B：{charA}|{charB}", "#9f3");

            object objA = 3.5f, objB = 7.7f;
            LogSystem.LogWithColor($"物件 A 與 B：{objA}|{objB}", "#3f3");
            SwapObject(ref objA, ref objB);
            LogSystem.LogWithColor($"物件 A 與 B：{objA}|{objB}", "#3f3");

        }


        /// <summary>
        /// 數字對調
        /// </summary>
        /// <param name="a">第一個數字</param>
        /// <param name="b">第二個數字</param>
        public void SwapNumber(ref int a,ref int b)
        {
            int temp = a;   // 將第一個數字放去旁邊(暫存)
            a = b;          // 將第二個數字放到第一個數字內
            b = temp;       // 將旁邊的數字放到第二個數字
        }

        /// <summary>
        /// 字元對調
        /// </summary>
        /// <param name="a">第一個字元</param>
        /// <param name="b">第二個字元</param>
        public void SwapChar(ref char a, ref char b) 
        {
            char temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// 物件對調
        /// </summary>
        /// <param name="a">第一個物件</param>
        /// <param name="b">第二個物件</param>
        public void SwapObject(ref object a, ref object b)  // 不建議 object，因為封裝、拆裝消耗系統資源
        {
            object temp = a;
            a = b;
            b = temp;
        }
    }
}

