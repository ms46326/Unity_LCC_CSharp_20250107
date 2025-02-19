using AES.Tools;
using UnityEngine;
namespace KID
{
    /// <summary>
    /// 繼承 Inherit
    /// </summary>
    public class class_10_1_Inherit : MonoBehaviour
    {
        private void Awake()
        {
            var goblin1 = new Goblin(10, 1);
            LogSystem.LogWithColor($"哥布林1號的攻擊：{goblin1.attact}", "#f3d");
            LogSystem.LogWithColor($"哥布林1號的攻擊：{goblin1.defense}", "#f3d");
            var Slime1 = new Slime(3, 2);
            LogSystem.LogWithColor($"史萊姆1號的攻擊：{Slime1.attact}", "#3fd");
            LogSystem.LogWithColor($"史萊姆1號的攻擊：{Slime1.defense}", "#3fd");
            goblin1.Move();
            Slime1.Move();
            Slime1.Initlize();

            // 判斷史萊姆是否繼承哥布林
            // 類別A is 類別B ： 布林值
            var slimeIsGoblin = Slime1 is Goblin;
            LogSystem.LogWithColor($"史萊姆1號是否為哥布林：{slimeIsGoblin}", "#f33");

            var spider1 = new spider(15, 3);
            var spiderIsSlime = spider1 is Slime;
            var spiderIsGoblin = spider1 is Goblin;
            LogSystem.LogWithColor($"蜘蛛1號是否為史萊姆：{spiderIsSlime}", "#f33");
            LogSystem.LogWithColor($"蜘蛛1號是否為哥布林：{spiderIsGoblin}", "#f33");

            var snake1 = new snake(12, 2);
            var snakeIsSlime = snake1 is Slime;
            LogSystem.LogWithColor($"蛇蛇1號是否為史萊姆：{snakeIsSlime}", "#f78");

        }
    }

    public class Goblin
    {
        public int attact;          // 公開：所有類別可以存取
        public int defense;
        private float moveSpeed;    // 私人：此類別可以存取，其他類別皆無法供存取
        protected float hp;         // 保護：子類別可以存取
        protected int lv = 5;

        public Goblin(int _attact, int _defense) 
        {
            attact = _attact;
            defense = _defense;
        }

        // virtual 虛擬：允許子類別複寫
        public virtual void Move() 
        {
            LogSystem.LogWithColor("兩條腿移動", "#9f9");
        }
    }

    // 繼承讓類別可以繼承另一個類別，擁有該類別的成員
    // 子類別：父類別
    // C# 僅提供單一繼承(只能繼承一個類別)
    public class Slime : Goblin
    {
        protected int lv = 10;      // 綠色蚯蚓：提示父類別有相同的成員名稱

        public Slime(int _attact, int _defense) : base(_attact, _defense)
        {
        }

        public void Initlize() 
        {
            attact = 7;             // 公開：可以存取
            //moveSpeed = 3.5f;     // 私人：無法存取
            hp = 10;                // 保護：可以存取
            LogSystem.LogWithColor($"等級：{lv}(史萊姆 子類別下設定的等級)", "#78f");
            LogSystem.LogWithColor($"等級：{base.lv}(史萊姆繼承哥布林父類別設定的等級)", "#78f");
        }

        // override 覆寫：覆寫父類別有 virtual 關鍵字的成員
        // override 選擇要覆寫的成員 > 按下 Enter 自動完成
        public override void Move()
        {
            // base.Move();      // 父類別原有的內容
            LogSystem.LogWithColor("爬行", "#3f3");
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

