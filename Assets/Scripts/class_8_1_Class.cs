using UnityEngine;
namespace KID
{
    /// <summary>
    /// ���O Class �G�Ψөw�q�@�Ӫ���H�ΩҾ֦�����ƻP�\��(����)
    /// </summary>
    public class class_8_1_Class : MonoBehaviour
    {
        private void Awake()
        {
            // ��Ҥ� NPC ���x�s�b npcJack �ܼƤ�
            class_8_1_NPC npcJack = new class_8_1_NPC();
            class_8_1_NPC npcKID = new class_8_1_NPC("KID","�A�n��~");

            npcJack.LogName();
            npcKID.LogName();
            npcJack.Talk();
            npcKID.Talk();

        }
        
    }
}

