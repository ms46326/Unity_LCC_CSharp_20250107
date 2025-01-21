using UnityEngine;

namespace KID
{
    /// <summary>
    /// �C�|�Genumeration�AC# ������r��²�g enum
    /// </summary>
    public class class_5_2_Enumeration : MonoBehaviour
    {
        #region �{�ѦC�|�򥻥Ϊk
        // �C�|�G�w�q�U�Կ�檺�ﶵ (�q�`���O���)
        // �y�k�G
        // �׹��� ����r enum �C�|�W�� { �C�|�ﶵ }
        // �w�q�@�ӦC�|�A�W�٥s���u�`
        private enum Season
        {
            // �w�q�C�|���ﶵ
            Spring, Summer, Autumn, Winter
        }
        
        // �ŧi�ܼơA���欰�u�`�C�|�A�w�]�Ȭ��L��
        [SerializeField, Header("�u�`")]
        private Season season = Season.Summer;

        private void Awake()
        {
            // ���o�C�|���� (Get) ��X�� 
            Debug.Log(season);
            // ���o�C�|����ƭ�
            Debug.Log((int)season);

            // �]�w�C�|���� (Set) �ק��
            season = Season.Winter;
            Debug.Log(season);
            // �z�L�ƭȳ]�w�C�|
            season = (Season)2;
            Debug.Log(season);
        }
        #endregion

        /// <summary>
        /// �D��
        /// </summary>
        private enum Item
        {
            None = 0, Coin = 1, RedWater = 10, BlueWater = 15, Chicken = 20
        }

        [SerializeField,Header("�D��")]
        private Item item = Item.Chicken;

        // ���涶�ǡG Awake > Start > Updata
        // �}�l�ƥ�G�b����ƥ�����@�� (��l��)
        private void Start()
        {
            Debug.Log(item);
            Debug.Log((int)item);
        }



    }
}


