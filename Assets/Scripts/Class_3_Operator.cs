using UnityEngine;
/// <summary>
/// �ҵ{ 3 �G�B��l
/// �ɥR�GUnity ����ݩʡBUnity �ƥ�
/// </summary>

public class Class_3_Operator : MonoBehaviour
{
    #region �򥻪�����ݩ�
    // C# �ܼ� = ��� Field
    // ����ݩ� Field Attritube
    //[���D(���D��r)]�G�b�ݩʭ��O�W��ܤ�r
    [Header("����")]
    public int lv = 1;
    //[����(���ܤ�r)]�G�b�ݩʭ��O�ƹ����d�b�ܼƤW�����
    [Tooltip("�o�O���⪺���ʳt�סA����ĳ�W�L 100�C")]
    public float moveSpeed = 2.5f;
    //[�d��(�̤p,�̤j)]�G���ƭ������K�[�d��(���O�W�אּ�Ʊ�)
    [Range(1, 100)]
    public byte count = 10;
    //�d�򤣯�ϥΦb�D�ƭ������W�A�|��� "Use Range with float or int."
    [Range(0, 10)]
    public string weapon = "�P��";
    //[��r�d��(�̤p��,�̤j��)]�G�ϥΦb��r�W�A�]�w���O����r�ؽd��
    [TextArea(2, 5)]
    public string itemdescription = "�o�̬O�D�㪺�y�z�A�o�̬O�D�㪺�y�z�A�o�̬O�D�㪺�y�z�A";

    //�h������ݩ�
    [Header("��q")]
    [Range(0, 999)]
    public int hp = 100;
    [Header("��q"), Range(0, 999)]
    public float attack = 30.5f;
    //[�b�ݩʭ��O����]�G�N���}�ܼ�����
    [HideInInspector]
    public string password = "�ڬO�K�X";
    //[�ǦC�����]�G�N�p�H�ܼ����
    [SerializeField]
    private float mp = 500;

    #endregion

    // �ϥ� Unity ���ƥ�
    // 1. �����b�}���᭱�K�[ �G MonoBehaviour (�~��)
    // 2. �ϥ�����r�ֳt�����A�Ҧp�G��J Awake �D��n�ϥΪ��ƥ�� Enter
    // ����ƥ�G����C����|���檺�Ĥ@�Өƥ�A�u����@��
    // �ƥ�W�٬O�Ŧ⪺(�S���ܦ⤣�v�T)
    private void Awake()
    {
        #region ��X�T��
        // �N�p�A�������T����X�� Unity ��Console ����x���O
        // Ctrl + Shift + C �}�ұ���x���O
        Debug.Log("���o�A�U�w :D");      // ��X��r
        Debug.Log(hp);                  // ��X�ܼƪ���
        Debug.Log("�����O�G" + attack);  // �r��P�ܼ�
        Debug.Log($"�����O�G{attack}");  // $�r��榡
        Debug.Log("�����O�G{attack}");   // �S���g$

        Debug.Log("<b>����</b>");
        Debug.Log("<color=orange>���</coloer>");
        //��X�G#����������šA�ƭȡG0~9�Aa~f�V�k���C��V�G #000�� #fff��
        Debug.Log("<color=#66aaff>�Ŧ�</coloer>");
        Debug.Log("<color=#6af>�Ŧ�</coloer>");
        #endregion

        #region ��N�B��l
        Debug.Log("<color=#f93>---��N�B��l---</color>");
        //�B��l
        // 1. ��N�B��l
        // �[�B��B���B���B�l
        // +�B-�B*�B/�B%
        Debug.Log(10 + 3);      // 13
        Debug.Log(10 - 3);      // 7
        Debug.Log(10 * 3);      // 30
        Debug.Log(10 / 3);      // 3
        Debug.Log(10 % 3);      // 10 / 3 = 3 �l 1�A���G 1

        Debug.Log("<color=#f93>---��N�B��l�G�ϰ��ܼ�---</color>");
        // �ϰ��ܼơG�Ȧb���j�A�����s��(���ݭn�׹������ܼ�)
        float numberA = 10;
        float numberB = 3;

        Debug.Log(numberA + numberB);
        Debug.Log(numberA - numberB);
        Debug.Log(numberA * numberB);
        Debug.Log(numberA / numberB);     // 3.33
        Debug.Log(numberA % numberB);

        #endregion

        #region ����B��l
        Debug.Log("<color=#f93>---����B��l---</color>");
        //����B��l�A�ϥΫ�|�o�쥬�L��
        int numberC = 100, numberD = 1;
        Debug.Log(numberC > numberD);   // �j   �� True
        Debug.Log(numberC < numberD);   // �p   �� False 
        Debug.Log(numberC >= numberD);  // �j�󵥩� True
        Debug.Log(numberC <= numberD);  // �p�󵥩� False
        Debug.Log(numberC == numberD);  // ��   �l True
        Debug.Log(numberC != numberD);  // ��  ���� False

        #endregion


    }


}
