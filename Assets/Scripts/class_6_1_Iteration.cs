using UnityEngine;
namespace KID
{
    /// <summary>
    /// �j�� while�Bdo-while�Bfor�Pforeach
    /// </summary>
    public class class_6_1_Iteration : MonoBehaviour
    {
        private void Awake()
        {
            #region �j�� while�Bdo �P for
            // �j��Цb�@���ʨƥ󤺨ϥ� Awake�BStart�A���n�b Updata
            // while �j��G���L�Ȭ� true �ɷ|�������
            // while (���L��) { �{���϶� }
            // �L���j��G���L�Ȥ@���O true
            // �ŧi�ϰ��ܼ� i �� 0
            int i = 0;
            // �� i < 5 �N���� { }
            while (i < 5)
            {
                Debug.Log($"<color=#f33>while �j��Ai = {i} </color>");
                // i ���W ( i + 1 )
                i++;
            }

            // do �j��G
            // do { �{���϶� } while (���L��)
            int j = 0;
            do
            {
                Debug.Log($"<color=#f79>do-while �j��Aj = {j} </color>");
                j++;
            }
            while (j < 5);

            // ���� while �P do ���t���A��l�ȬҬ� 5 �A���L�Ȭ� < 5�A�o�{ while ���|����A���O do-while �|������@�� b = 5 �M�ᵲ��
            int a = 5;
            while (a < 5)
            {
                Debug.Log($"<color=#f33>while �j��Aa = {a} </color>");
                a++;
            }

            int b = 5;
            do
            {
                Debug.Log($"<color=#f79>do-while �j��Ab = {b} </color>");
                b++;
            }
            while (b < 5);

            // for �j��G
            // for (��l�ȡF���L�ȡF���N��) { �{���϶� }
            for (int k = 0; k < 5; k++)
            {
                Debug.Log($"<color=#78f>for �j��Ak = {k} </color>");
            }
            #endregion

            // foreach �j��
            // ��Ƶ��c�G�}�C�B�M�浥��...
            // foreach (������� ��ƦW�� in ��Ƶ��c) { �{���϶� }
            // �r��N�O�@�ظ�Ƶ��c�A�ΨӦs�� char ���}�C
            string dialogue = "�١I�A�n�A�ڬO NPC~";
            // 
            // 
            foreach (var test in dialogue)
            {
                Debug.Log($"<color=#f63>{test}</color>");
            }

        }
    }
}

