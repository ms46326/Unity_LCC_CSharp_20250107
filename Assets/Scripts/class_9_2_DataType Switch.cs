using AES.Tools;
using UnityEngine;
namespace KID
{
    /// <summary>
    /// 資料類行轉換
    /// </summary>
    public class class_9_2_DataTypeSwitch : MonoBehaviour
    {
        private void Awake()
        {
            // 隱式轉換：不需要另外宣告轉換類型
            // 將小的資料放到大的資料內
            byte byte1 = 1;
            int int1 = 0;
            LogSystem.LogWithColor(byte1, "#7f7");
            LogSystem.LogWithColor(byte1.GetType(), "#7f7");
            LogSystem.LogWithColor(int1, "#7f7");
            LogSystem.LogWithColor(int1.GetType(), "#7f7");
            // 隱式轉換：將比較小的 byte 放到大的 int
            int1 = byte1;
            LogSystem.LogWithColor(int1, "#7f7");
            LogSystem.LogWithColor(int1.GetType(), "#7f7");

            // 顯式轉換：需要宣告轉換類型
            // 將大的資料放到小的資料內
            int int2 = 100;
            byte byte2 = 0;
            LogSystem.LogWithColor(int2, "#f77");
            LogSystem.LogWithColor(int2.GetType(), "#f77");
            LogSystem.LogWithColor(byte2, "#f77");
            LogSystem.LogWithColor(byte2.GetType(), "#f77");
            // 顯示轉換：將比較大的 int 放到小的 byte
            // 添加 (資料類型)
            byte2 = (byte)int2;
            LogSystem.LogWithColor(byte2, "#f77");
            LogSystem.LogWithColor(byte2.GetType(), "#f77");

            LogSystem.LogWithColor(".................", "#ff3");

            float float1 = 3.5f;
            byte byte3 = 0;

            byte3 = (byte)float1;
            LogSystem.LogWithColor(byte3, "#77f");

            LogSystem.LogWithColor(".................", "#ff3");

            // 範圍較大的轉為範圍較小的，會導致溢位
            int int3 = 258;
            byte byte4 = 0;
            byte4 = (byte)int3;
            LogSystem.LogWithColor(byte4, "#3f9");

            LogSystem.LogWithColor(".................", "#ff3");

        }
    }
}

