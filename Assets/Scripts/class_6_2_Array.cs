using NUnit.Framework.Internal;
using UnityEngine;
namespace KID
{
    /// <summary>
    /// �}�C Array
    /// </summary>
    public class class_6_2_Array : MonoBehaviour
    {
        // ���ϥΰ}�C���g�k�G
        // �֥d�C�B�p���s�B�֥d�~
        public string card1 = "�֥d�C", card2 = "�p���s", card3 = "�֥d�~";
        
        // �ϥΰ}�C���g�k�G 
        // �}�C�G�Ψ��x�s�h���ۦP���������
        // �Ĥ@�ءG�����w�ȡA�z�L Unity ���O��J
        // �׹��� �������[] �}�C�W��;
        public string[] cards;
        // �ĤG�ءG�����w�q�}�C���ƶq
        // �w�q�@�ӵP��1�A�i�H�񤭱i�d�P
        public string[] deck1 = new string[5];
        // �ĤT�ءG�����w�q�}�C���� 
        public string[] deck2 = {"��᳾","����","�_�ۮ��P" };

        // �G���}�C
        public string[,] inventory = { {"�����Ĥ�","�Ŧ��Ĥ�"},{"���u","����" } };

        // �T���}�C
        public string[,,] shop = 
        {
            { {"�p�M","���u�M"},{"�Z�h�M","�O�s�M" } },
            { {"���F�y","���Ųy"},{"�j�v�y","�_�޲y" } }
        };

        private void Start()
        {
            Debug.Log($"<color=#f32>Cards ���ĤT�i�d���G{cards[2]}</color>");



            deck2[2] = "�ǥ��t";
            Debug.Log($"<color=#f39>�s��[0,1]���D��G{deck2[2]}</color>");

            // �s���G���}�C
            Debug.Log($"<color=#3f3>�s��[0,1]���D��G{inventory[0, 1]}</color>");

            inventory[1, 1] = "�n����";
            Debug.Log($"<color=#3f3>�s��[1,1]���D��G{inventory[1, 1]}</color>");

            // �s���T���}�C
            // ���o�O�s�M
            Debug.Log($"<color=#f3d>�s��[0,1,1]���D��G{shop[0,1, 1]}</color>");

            // �]�w���Ųy���W�Ųy
            shop[1, 0, 1] = "�W�Ųy";
            Debug.Log($"<color=#f3d>�s��[1,0,1]���D��G{shop[1, 0, 1]}</color>");


            // ��o�}�C�����שM����
            // �@�� ~ �h���}�C�����סG�}�C�W��.Length
            Debug.Log($"<color=#f93>�@�� - �P�� 2 �����סG{deck2.Length}</color>");
            Debug.Log($"<color=#f93>�G�� - �D�㪺���סG{inventory.Length}</color>");
            Debug.Log($"<color=#f93>�T�� - �ӫ~�����סG{shop.Length}</color>");
            // �}�C�����סG�}�C�W��.Rank
            Debug.Log($"<color=#f39>�@�� - �P�� 2 �����סG{deck2.Rank}</color>");
            Debug.Log($"<color=#f39>�G�� - �D�㪺���סG{inventory.Rank}</color>");
            Debug.Log($"<color=#f39>�T�� - �ӫ~�����סG{shop.Rank}</color>");

        }



    }


}
