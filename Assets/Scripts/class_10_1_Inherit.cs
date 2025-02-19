using AES.Tools;
using UnityEngine;
namespace KID
{
    /// <summary>
    /// �~�� Inherit
    /// </summary>
    public class class_10_1_Inherit : MonoBehaviour
    {
        private void Awake()
        {
            var goblin1 = new Goblin(10, 1);
            LogSystem.LogWithColor($"�����L1���������G{goblin1.attact}", "#f3d");
            LogSystem.LogWithColor($"�����L1���������G{goblin1.defense}", "#f3d");
            var Slime1 = new Slime(3, 2);
            LogSystem.LogWithColor($"�v�ܩi1���������G{Slime1.attact}", "#3fd");
            LogSystem.LogWithColor($"�v�ܩi1���������G{Slime1.defense}", "#3fd");
            goblin1.Move();
            Slime1.Move();
            Slime1.Initlize();

            // �P�_�v�ܩi�O�_�~�ӭ����L
            // ���OA is ���OB �G ���L��
            var slimeIsGoblin = Slime1 is Goblin;
            LogSystem.LogWithColor($"�v�ܩi1���O�_�������L�G{slimeIsGoblin}", "#f33");

            var spider1 = new spider(15, 3);
            var spiderIsSlime = spider1 is Slime;
            var spiderIsGoblin = spider1 is Goblin;
            LogSystem.LogWithColor($"�j��1���O�_���v�ܩi�G{spiderIsSlime}", "#f33");
            LogSystem.LogWithColor($"�j��1���O�_�������L�G{spiderIsGoblin}", "#f33");

            var snake1 = new snake(12, 2);
            var snakeIsSlime = snake1 is Slime;
            LogSystem.LogWithColor($"�D�D1���O�_���v�ܩi�G{snakeIsSlime}", "#f78");

        }
    }

    public class Goblin
    {
        public int attact;          // ���}�G�Ҧ����O�i�H�s��
        public int defense;
        private float moveSpeed;    // �p�H�G�����O�i�H�s���A��L���O�ҵL�k�Ѧs��
        protected float hp;         // �O�@�G�l���O�i�H�s��
        protected int lv = 5;

        public Goblin(int _attact, int _defense) 
        {
            attact = _attact;
            defense = _defense;
        }

        // virtual �����G���\�l���O�Ƽg
        public virtual void Move() 
        {
            LogSystem.LogWithColor("����L����", "#9f9");
        }
    }

    // �~�������O�i�H�~�ӥt�@�����O�A�֦������O������
    // �l���O�G�����O
    // C# �ȴ��ѳ�@�~��(�u���~�Ӥ@�����O)
    public class Slime : Goblin
    {
        protected int lv = 10;      // ���L�C�G���ܤ����O���ۦP�������W��

        public Slime(int _attact, int _defense) : base(_attact, _defense)
        {
        }

        public void Initlize() 
        {
            attact = 7;             // ���}�G�i�H�s��
            //moveSpeed = 3.5f;     // �p�H�G�L�k�s��
            hp = 10;                // �O�@�G�i�H�s��
            LogSystem.LogWithColor($"���šG{lv}(�v�ܩi �l���O�U�]�w������)", "#78f");
            LogSystem.LogWithColor($"���šG{base.lv}(�v�ܩi�~�ӭ����L�����O�]�w������)", "#78f");
        }

        // override �мg�G�мg�����O�� virtual ����r������
        // override ��ܭn�мg������ > ���U Enter �۰ʧ���
        public override void Move()
        {
            // base.Move();      // �����O�즳�����e
            LogSystem.LogWithColor("����", "#3f3");
        }
    }

    public class spider : Slime
    {
        public spider(int _attact, int _defense) : base(_attact, _defense)
        {
        }
    }
    public class snake : Goblin
    {
        public snake(int _attact, int _defense) : base(_attact, _defense)
        {
        }
    }
}

