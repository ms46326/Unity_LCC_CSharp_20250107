using UnityEngine;
namespace KID
{
    /// <summary>
    /// NPC ���O�GNPC �W�ٻP��ܤ��e��ơA����X�P���ܪ��\��
    /// </summary>
    public class class_8_1_NPC
    {
        private string name;
        private string dialogue;


        // �غc�l�G�S���Ǧ^�����A�W�ٻP���O�ۦP�����}��k
        // �w�]�غc�l�G�S���Ѽ�
        public class_8_1_NPC() 
        { 
            Debug.Log($"<color=#f3d>�w�]�غc�l</color>");
        }
        // �غc�l��²�g
        public class_8_1_NPC( string _name) => name = _name;

        public class_8_1_NPC(string _name, string _dialogue)
        {
            name = _name;
            dialogue = _dialogue;
            Debug.Log($"<color=#f3d>���Ѽƪ��غc�l</color>");
        }

        public void LogName() 
        {
            Debug.Log($"<color=#373>NPC ���W�١G{name}");
        }

        public void Talk() 
        {
            Debug.Log($"<color=#373>{dialogue}");
        }




    }
}

