using AES.Tools;
using UnityEngine;
using System;

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

        private void Start()
        {
            // 將整數轉為字串
            int count = 99;
            var intToString = Convert.ToString(count);
            LogSystem.LogWithColor(intToString, "#f96");
            LogSystem.LogWithColor(intToString.GetType(), "#f96");
            // 將布林值轉為字串
            bool isOver = false;
            var boolToString = Convert.ToString(isOver);
            LogSystem.LogWithColor(boolToString, "#f96");
            LogSystem.LogWithColor(boolToString.GetType(), "#f96");

            float move = 3.5f;              // 3.5轉 byte 會回轉偶數 4
            float move1 = 4.5f;             // 4.5轉 byte 會回轉偶數 4
            var floatToByte = Convert.ToByte(move);
            var floatToByte1 = Convert.ToByte(move);
            LogSystem.LogWithColor(floatToByte, "#6f6");
            LogSystem.LogWithColor(floatToByte1, "#6f6");
            LogSystem.LogWithColor(floatToByte.GetType(), "#6f6");

            // true = 1 , false = 0
            bool isGrounded = true;
            var boolToByte = Convert.ToByte(isGrounded);
            LogSystem.LogWithColor(boolToByte, "#6f6");
            LogSystem.LogWithColor(boolToByte.GetType(), "#6f6");

        }

    }
}

