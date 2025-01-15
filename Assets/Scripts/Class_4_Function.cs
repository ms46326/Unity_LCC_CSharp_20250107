using UnityEditor.Experimental.GraphView;
using UnityEngine;
/// <summary>
/// ��k
/// ����G��k�B�禡�B��ơB�\��
/// �^��GFunction�Bmethod(Unity)
/// </summary>
public class Class_4_Function : MonoBehaviour
{
    private void Awake()
    {
        #region ��k�򥻻y�k�P�ѼƩI�s
        // �I�s��k�G��k�S���I�s���|����
        // ��k�W��();
        FirstFunction();
        UseSkill("���y�N", 30);
        UseSkill("�B�@�N", 50);
        SpawnEnemy();
        SpawnEnemy("�v�ܩi");
        Fire(500);
        Fire(600, "�O�ֲy");
        // ���h�ӿ�ܩʰѼƮɪ��I�s
        // �R�����A50 ��
        BuyItem();
        // �R�����A30 ��
        // BuyItem(30); ���~�G30�|�����a�J�� item �ѼƾɭP����������ŦX
        BuyItem(count: 30);
        // �R�Ť��A50 ��
        BuyItem("�Ť�");
        // �R�Ť��A30 ��
        BuyItem("�Ť�",30);
        #endregion



        Debug.Log($"<color=#66f>BMI�G{BMI()}</color>");

    }
    //�ؿ�n��z���{�� > Ctrl + K S > #region �ֳt�����{���X���q
    #region ��k�򥻻y�k�P�Ѽ�
    // ��k�G
    // �]�t�@�t�C�{���϶�
    // ��k�y�k�G
    // �׹��� �Ǧ^������� ��k�W�� (�Ѽ�1�A�Ѽ�2�A...�A�Ѽ�N) {�{���϶�}
    // ��k�R�W�ߺD�GUnity �ߺD�ϥΤj�g�}�Y�R�W��k
    // void �L�Ǧ^�G�ϥΦ���k���|�Ǧ^���
    private void FirstFunction()
    {
        Debug.Log("�Ĥ@�Ӥ�k");
    }

    // �Ѽƻy�k�G�P�ϰ��ܼƬۦP ������� �ѼƦW�� (�ߺD�Τp�g�Ϊ̥[���u�}�Y)
    private void UseSkill(string skill, float cost)
    {
        Debug.Log($"<color=#f93>�I��ޯ�G{skill}</color>");
        Debug.Log($"<color=#f93>�ޯ���ӡG{cost}</color>");
    }

    private void SpawnEnemy(string enemy = "�����L")
    {
        Debug.Log($"<color=#f33>�ͦ��ĤH�G{enemy}</color>");
    }

    // �S���w�]�Ⱥ٬��G���n�ѼơA���w�]�Ⱥ٬���ܩʰѼ�
    // ��ܩʰѼƭn�g�b�k��
    // 
    // 
    // 
    // 
    // 

    /// <summary>
    /// 
    /// </summary>
    /// <param name="speed"></param>
    /// <param name="fire"></param>
    private void Fire(int speed, string fire = "�l�u")
    {
        Debug.Log($"<color=#66f>�o�g����G{fire},�t�סG{speed}</color>");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="item">�D��W��</param>
    /// <param name="count">�D��ƶq</param>
    private void BuyItem(string item = "����", int count = 50)
    {
        Debug.Log($"<color=#3f3>�ʶR�ӫ~�G{item},�ƶq�G{count}</color>");
    }
    #endregion





    private float BMI(float height = 1.68f, float Weight = 60)
    {
        return Weight / (height * height);
    }









}