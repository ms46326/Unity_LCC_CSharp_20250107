using AES.Tools;
using UnityEngine;
using System;

namespace KID
{
    /// <summary>
    /// ��������ഫ
    /// </summary>
    public class class_9_2_DataTypeSwitch : MonoBehaviour
    {
        private void Awake()
        {
            // �����ഫ�G���ݭn�t�~�ŧi�ഫ����
            // �N�p����Ʃ��j����Ƥ�
            byte byte1 = 1;
            int int1 = 0;
            LogSystem.LogWithColor(byte1, "#7f7");
            LogSystem.LogWithColor(byte1.GetType(), "#7f7");
            LogSystem.LogWithColor(int1, "#7f7");
            LogSystem.LogWithColor(int1.GetType(), "#7f7");
            // �����ഫ�G�N����p�� byte ���j�� int
            int1 = byte1;
            LogSystem.LogWithColor(int1, "#7f7");
            LogSystem.LogWithColor(int1.GetType(), "#7f7");

            // �㦡�ഫ�G�ݭn�ŧi�ഫ����
            // �N�j����Ʃ��p����Ƥ�
            int int2 = 100;
            byte byte2 = 0;
            LogSystem.LogWithColor(int2, "#f77");
            LogSystem.LogWithColor(int2.GetType(), "#f77");
            LogSystem.LogWithColor(byte2, "#f77");
            LogSystem.LogWithColor(byte2.GetType(), "#f77");
            // ����ഫ�G�N����j�� int ���p�� byte
            // �K�[ (�������)
            byte2 = (byte)int2;
            LogSystem.LogWithColor(byte2, "#f77");
            LogSystem.LogWithColor(byte2.GetType(), "#f77");

            LogSystem.LogWithColor(".................", "#ff3");

            float float1 = 3.5f;
            byte byte3 = 0;

            byte3 = (byte)float1;
            LogSystem.LogWithColor(byte3, "#77f");

            LogSystem.LogWithColor(".................", "#ff3");

            // �d����j���ର�d����p���A�|�ɭP����
            int int3 = 258;
            byte byte4 = 0;
            byte4 = (byte)int3;
            LogSystem.LogWithColor(byte4, "#3f9");

            LogSystem.LogWithColor(".................", "#ff3");

        }

        private void Start()
        {
            // �N����ର�r��
            int count = 99;
            var intToString = Convert.ToString(count);
            LogSystem.LogWithColor(intToString, "#f96");
            LogSystem.LogWithColor(intToString.GetType(), "#f96");
            // �N���L���ର�r��
            bool isOver = false;
            var boolToString = Convert.ToString(isOver);
            LogSystem.LogWithColor(boolToString, "#f96");
            LogSystem.LogWithColor(boolToString.GetType(), "#f96");

            float move = 3.5f;              // 3.5�� byte �|�^�స�� 4
            float move1 = 4.5f;             // 4.5�� byte �|�^�స�� 4
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

