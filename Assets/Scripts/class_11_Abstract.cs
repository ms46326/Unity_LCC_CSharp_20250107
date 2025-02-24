using AES.Tools;
using UnityEngine;
namespace KID
{
    /// <summary>
    /// ��H
    /// </summary>
    public class class_11_Abstract : MonoBehaviour
    {
        private void Awake()
        {
            // ��H���O�G
            // 1. �����ϥ�����r abstract
            // 2. ����Q��Ҥ� (new)
            // 3. �p�G����H��k�����A���ݭn�D�� (�j�A��)
            // 4. ��H���������Q�l���O��@ (override)
            var flyDragon = new FlyDragon();
            var threeHornDragon = new ThreeHornDragon();

            // var monster = new Monster();     // ���~�Gabstract �O�L�k�Q��Ҥ�
            flyDragon.Attact();
            threeHornDragon.Attact();

            // �V�W�૬ Upcasting�G��Ҥƫ�������O
            // �V�W�૬�i�H�ϥΦh��
            Monster fly = new FlyDragon();
            fly.Track();
            fly.Track(50);

            FlyDragon fly2 = new FlyDragon();
            fly2.Track();
            fly2.Track(100);

            var fly3 = new FlyDragon();
            fly3.Track();
            fly3.Track(150);

        }
    }

    // abstract ��H���O
    public abstract class Monster 
    {
        public float hp;
        public float moveSpeed;

        // ��H��k���ݭn�D��(�]�N�O�j�ظ�{})
        public abstract void Attact();

        public void Track() 
        {
            LogSystem.LogWithColor("�l��", "#f93");
        }

    }

    public class FlyDragon : Monster
    {
        public override void Attact()
        {
            LogSystem.LogWithColor("���s����", "#f77");
        }

        public void Track(int speed) 
        {
            LogSystem.LogWithColor($"�l�ܡA�t��{speed}", "#f93");
        }
    }

    public class ThreeHornDragon : Monster
    {
        public override void Attact()
        {
            LogSystem.LogWithColor("�T���s����", "#7f7");
        }
    }
}

