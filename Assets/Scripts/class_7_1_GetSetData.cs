using UnityEngine;
namespace KID
{
    /// <summary>
    /// �m�ߦs����ƥ�
    /// </summary>
    public class class_7_1_GetSetData : MonoBehaviour
    {
        public class_7_1_Property property;

        private void Awake()
        {
            //���o�t�@�����O�����
            Debug.Log(property.moveSpeed);      //�i�H���o���}�ܼ�
            //Debug.Log(property.turnSpeed);    //���i���o�p�H�ܼ�

            //�]�w�t�@�����O�����
            property.moveSpeed = 7.7f;          //�i�H�]�w���}�ܼ�
            //property.turnSpeed = 20.2f;       //���i�]�w�p�H�ܼ�

            Debug.Log(property.runSpeed);       //�i�H���o���}�ܼ�
            //Debug.Log(property.sprintSpeed);  //���i���o�p�H�ܼ�

            property.runSpeed = 50.3f;          //�i�H�]�w�� set ���ݩ�
            //property.jumpSpeed = 99.5f;       //���i�]�w�S�� set ���ݩ�(�߿W)





        }




    }
}

