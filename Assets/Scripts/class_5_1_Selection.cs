using UnityEngine;
//�R�W�Ŷ��G
//�N���O�����A�����ܮw�������A���P�ܮw�i�H���ۦP�W�����O�C
//�y�k�Gnamespace �R�W�Ŷ��W�� { ���e }
namespace KID
{
    /// <summary>
    /// ������z�� Selection Statement
    /// 1. if �P�_��
    /// 2. Switch �P�_��
    /// </summary>
    public class class_5_1_Selection : MonoBehaviour
    {
        [SerializeField, Header("�O�_�}��")]
        private bool isOpen;
        [SerializeField, Header("����"), Range(0,100)]
        private int score = 100;
        [SerializeField, Header("�Z��")]
        private string weapon ;
        [SerializeField, Header("��q"),Range(0,100)]
        private float hp ;

        private void Awake()
        {
            // if�P�_��
            // if (���L��) { ���z�� }
            if (true)
            {
                Debug.Log("���L�Ȭ� True�A�|����o�̡C");
            }

            // �ֳt�����G��J if ��� if ���z���� Enter �� Tab
            if (false)
            {
                Debug.Log("���L�Ȭ� False�A���|����o�̦ӥB�|����L�C�C");
            }
        }

        // ��s�ƥ�G�@��������� 60 �� ( 60 FPS ) Frame Per Second
        private void Update()
        {
            // �`�Χֱ���
            // 1. �榡�� (�ƪ�) Ctrl + K D
            // 2. �{���X���q Ctrl + K S �� region
            #region �P�_�� if
            Debug.Log("<color=#79f>��s�ƥ�</color>");

            // �p�G isOpen ���L�ȵ��� True �A�N��ܤw�g�}���C
            if (isOpen)
            {
                Debug.Log("<color=#f93>�w�g�}��</color>");
            }
            // �_�h isOpen ���L�ȵ��� False �A�N��������F�C
            else
            {
                Debug.Log("<color=#f93>�����F</color>");
            }

            // ����B��l�B�޿�B��l���G�����L��
            // if �|�b�̤W��Belse �|�b�̤U��A�����i�H���h�� else if 
            // �p�G ���� >= 60 �N�q�L
            if (score >= 60)
            {
                Debug.Log("<color=#3f3>���ߧA C# �q�L�F</color>");
            }
            // �_�h �p�G ���� >= 40 �i�H�ɦ�
            else if (score >= 40)
            {
                Debug.Log("<color=#f96>�A C# �i�H�ɦ�</color>");
            }
            // �_�h �p�G ���� >= 20 �i�H�ɦҦ��O�n���@�� C# �p�M�D
            else if (score >= 20)
            {
                Debug.Log("<color=#f9a>�A C# �i�H�ɦҦ��O�n���@�� C# �p�M�D</color>");
            }
            // �_�h ��
            else
            {
                Debug.Log("<color=#f33>�A�� C# �Q��F</color>");
            }

            #endregion

            #region �P�_�� switch
            // switch �P�_��
            // switch (�n�P�_����) { ���z�� }
            // �ֳt�����Gswitch + ( Tab * 2 )
            switch (weapon)
            {
                // case ��:
                // ��P�_���ȵ���Ȯɷ|����o��
                // break; ���X�P�_��
                // �p�G�Z������p�M�A�����O����20
                case "�����M":
                // ���[break�A�|�@�����U����A����J��break;
                case "�p�M":
                    Debug.Log("<color=#ff3>�����O �G 20</color>");
                    break;
                case "���u�M":
                    Debug.Log("<color=#ff3>�����O �G 10</color>");
                    break;
                case "�O�s�M":
                    Debug.Log("<color=#ff3>�����O �G 999</color>");
                    break;
                // else
                default:
                    Debug.Log("<color=#ff3>�o�O����ϥΪ��Z��</color>");
                    break; 
                    
            }
            #endregion

            #region Practice switch
            switch (hp)
            {
                case  >= 80:
                    Debug.Log("<color=#ff3>��q�w��</color>");
                    break;
                case >= 60:
                    Debug.Log("<color=#ff3>���d���A�����p</color>");
                    break;
                case >= 40:
                    Debug.Log("<color=#ff3>ĵ�i�A�ֳܤ�</color>");
                    break;
                case > 10:
                    Debug.Log("<color=#ff3>�֦����F</color>");
                    break;
                case <= 0 :
                    Debug.Log("<color=#ff3>�A�w�g���F</color>");
                    break;
                default :
                    Debug.Log("<color=#ff3></color>");
                    break;
            } 
            #endregion
        }

    }

}
