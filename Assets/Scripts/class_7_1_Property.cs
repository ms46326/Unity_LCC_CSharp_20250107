using UnityEngine;
namespace KID 
{
    
    /// <summary>
    /// �ݩ� Property
    /// </summary>
    public class class_7_1_Property : MonoBehaviour
    {
        #region �{���ݩ� Property
        // ���}���ܼơG�i�H���~��Ū���P�g�J
        public float moveSpeed = 3.5f;

        // �p�H���ܼơG�����\�~��Ū���P�g�J
        private float turnSpeed = 12.7f;

        // ���}���ݩʡG���\�s��
        public float runSpeed { get; set; }
        // �p�H���ݩʡG�����\�s��
        private float sprintSpeed { get; set; }
        // ���}���ݩʡG�u�� set �N��߿W (�u��Ū������g�J)
        public float jumpSpeed { get; }


        // prop + Tab
        // ���w�]�Ȫ��ݩ�
        public byte lv { get; set; } = 1;

        private void Awake()
        {
            Debug.Log("-----���o�ܼƻP�ݩ�-----");
            Debug.Log(moveSpeed);
            Debug.Log(turnSpeed);
            Debug.Log(runSpeed);
            Debug.Log(sprintSpeed);
            Debug.Log(jumpSpeed);
            Debug.Log(lv);
            Debug.Log("-----�]�w�ܼƻP�ݩ�-----");
            moveSpeed = 11.1f;
            turnSpeed = 2.5f;               // �p�H�ܼƦb���O���i�H�]�w
            runSpeed = 30;
            sprintSpeed = 60.2f;
            //jumpSpeed = 90;               // �S�� set ���ݩʦb���O���]�L�k�]�w
            lv = 10;
        }
        #endregion

        // �ݩ��Y�g
        public float hp { get; set; } = 100;

        // �ݩʼзǼg�k
        // _mp �ΨӸ��ݩ� mp �Ȫ��e��
        private float _mp = 50;
        // �ݩʬO�����~���s���v�������f
        public float mp 
        { 
            get 
            { 
                return _mp; 
            } 
            set
            {
                _mp = value;
            }
        }


        // ���o�ݩʪ�²�g (�b�Y => Lambda)
        // ��Ū�ݩ� ���m�ȬO30
        public int defence { get; } = 30;
        // ��Ū�ݩ� �����ȬO50  Lambda�O���²���g�k
        public int attack => 50;


        private void Start()
        {
            Debug.Log($"<color=#77f>��qhp�G{hp}</color>");
            Debug.Log($"<color=#77f>�ק�e�]�Omp�G{mp}</color>");
            mp = 500;
            Debug.Log($"<color=#77f>�ק���]�Omp�G{mp}</color>");
        }


    }



}

