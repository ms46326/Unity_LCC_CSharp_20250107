using AES.Tools;
using UnityEngine;
namespace KID
{
    /// <summary>
    /// ��������ഫ
    /// </summary>
    public class Practice_9_DataType :MonoBehaviour
    {
        public void Awake()
        {
            float number = -999.321f;
            sbyte byteNumber = (sbyte)number;
            LogSystem.LogWithColor(byteNumber, "#6f6");
        }
    }
}

