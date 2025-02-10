using UnityEngine;
namespace KID
{
    /// <summary>
    /// 迴圈 while、do-while、for與foreach
    /// </summary>
    public class class_6_1_Iteration : MonoBehaviour
    {
        private void Awake()
        {
            #region 迴圈 while、do 與 for
            // 迴圈請在一次性事件內使用 Awake、Start，不要在 Updata
            // while 迴圈：當布林值為 true 時會持續執行
            // while (布林值) { 程式區塊 }
            // 無限迴圈：布林值一直是 true
            // 宣告區域變數 i 為 0
            int i = 0;
            // 當 i < 5 就執行 { }
            while (i < 5)
            {
                Debug.Log($"<color=#f33>while 迴圈，i = {i} </color>");
                // i 遞增 ( i + 1 )
                i++;
            }

            // do 迴圈：
            // do { 程式區塊 } while (布林值)
            int j = 0;
            do
            {
                Debug.Log($"<color=#f79>do-while 迴圈，j = {j} </color>");
                j++;
            }
            while (j < 5);

            // 測試 while 與 do 的差異，初始值皆為 5 ，布林值皆 < 5，發現 while 不會執行，但是 do-while 會先執行一次 b = 5 然後結束
            int a = 5;
            while (a < 5)
            {
                Debug.Log($"<color=#f33>while 迴圈，a = {a} </color>");
                a++;
            }

            int b = 5;
            do
            {
                Debug.Log($"<color=#f79>do-while 迴圈，b = {b} </color>");
                b++;
            }
            while (b < 5);

            // for 迴圈：
            // for (初始值；布林值；迭代器) { 程式區塊 }
            for (int k = 0; k < 5; k++)
            {
                Debug.Log($"<color=#78f>for 迴圈，k = {k} </color>");
            }
            #endregion

            // foreach 迴圈
            // 資料結構：陣列、清單等等...
            // foreach (資料類型 資料名稱 in 資料結構) { 程式區塊 }
            // 字串就是一種資料結構，用來存放 char 的陣列
            string dialogue = "嗨！你好，我是 NPC~";
            // 
            // 
            foreach (var test in dialogue)
            {
                Debug.Log($"<color=#f63>{test}</color>");
            }

        }
    }
}

