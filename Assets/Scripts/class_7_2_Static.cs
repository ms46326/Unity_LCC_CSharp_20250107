using UnityEngine;
namespace KID
{
    /// <summary>
    /// 靜態 Static
    /// </summary>
    public class class_7_2_Static : MonoBehaviour
    {
        // 非靜態變數
        public int inventorwater = 10;
        // 靜態變數：修飾詞後面添加關鍵字 static
        // 靜態變數不顯示在屬性面板上
        public static int inventorProp = 20;

        private void Awake()
        {
            inventorwater = 7;
            inventorProp = 15;
            Debug.Log($"<color=#f31>藥水：{inventorwater}</color>");
            Debug.Log($"<color=#f13>道具：{inventorProp}</color>");
        }
    }
}

