using UnityEngine;
namespace KID
{
    /// <summary>
    /// �m�ߨ��o�P�]�w�R�A���
    /// </summary>
    public class Class_7_2_GetSetStaticData : MonoBehaviour
    {
        // ���o�D�R�A���
        // 1. ���w�q�n��o�Ӹ�����O���ܼ�
        // 2. �z�L�ܼƨ��o�D�R�A���(����)
        
        public class_7_2_Static class_7_2;

        private void Awake()
        {
            // �ܼƦW��.�D�R�A����
            // ���o�D�R�A�ܼ� 
            Debug.Log($"<color=#f3d>�D�R�A�ܼơG{class_7_2.inventoryWater}</color>");
            // ���o�D�R�A�ݩ�
            Debug.Log($"<color=#f3d>�D�R�A�ܼơG{class_7_2.skillMain}</color>");
            // �I�s�D�R�A��k
            class_7_2.Punch();


            // ���O�W��.�R�A����
            // ���o�R�A�ܼ�
            Debug.Log($"<color=#f3d>�R�A�ܼƦ����G{class_7_2_Static.inventoryProp}</color>");
            // ���o�R�A�ݩ�
            Debug.Log($"<color=#f3d>�R�A�ݩʦ����G{class_7_2_Static.skillSecon}</color>");
            // �I�s�R�A��k
            class_7_2_Static.Kick();    

        }

        public class_7_2_Slime slimeGreen, slimeBlue;

        private void Start()
        {
            // �D�R�A����
            slimeGreen.hp -= 10;
            Debug.Log($"<color=#3f3>��v�ܩi HP�G{slimeGreen.hp}</color>");
            slimeBlue.hp -= 10;
            Debug.Log($"<color=#3f3>�ťv�ܩi HP�G{slimeBlue.hp}</color>");

            // �R�A����
            // �R�A�����S��k�z�L����s��
            // slimeGreen.moveSpeed = 3.5f;
            class_7_2_Slime.moveSpeed = 3.5f;
            Debug.Log($"<color=#3f3>�v�ܩi���ʳt�סG{class_7_2_Slime.moveSpeed}</color>");
        }
    }
}
        
