using NUnit.Framework.Internal;
using UnityEngine;
namespace KID
{
    /// <summary>
    /// 陣列 Array
    /// </summary>
    public class class_6_2_Array : MonoBehaviour
    {
        // 不使用陣列的寫法：
        // 皮卡丘、小火龍、皮卡獸
        public string card1 = "皮卡丘", card2 = "小火龍", card3 = "皮卡獸";
        
        // 使用陣列的寫法： 
        // 陣列：用來儲存多筆相同類型的資料
        // 第一種：不指定值，透過 Unity 面板輸入
        // 修飾詞 資料類型[] 陣列名稱;
        public string[] cards;
        // 第二種：直接定義陣列的數量
        // 定義一個牌組1，可以放五張卡牌
        public string[] deck1 = new string[5];
        // 第三種：直接定義陣列的值 
        public string[] deck2 = {"急凍鳥","賭霞","寶石海星" };

        // 二維陣列
        public string[,] inventory = { {"紅色藥水","藍色藥水"},{"炸彈","金幣" } };

        // 三維陣列
        public string[,,] shop = 
        {
            { {"小刀","美工刀"},{"武士刀","屠龍刀" } },
            { {"精靈球","高級球"},{"大師球","巢穴球" } }
        };

        private void Start()
        {
            Debug.Log($"<color=#f32>Cards 的第三張卡片：{cards[2]}</color>");



            deck2[2] = "傑尼龜";
            Debug.Log($"<color=#f39>編號[0,1]的道具：{deck2[2]}</color>");

            // 存取二維陣列
            Debug.Log($"<color=#3f3>編號[0,1]的道具：{inventory[0, 1]}</color>");

            inventory[1, 1] = "好傷藥";
            Debug.Log($"<color=#3f3>編號[1,1]的道具：{inventory[1, 1]}</color>");

            // 存取三維陣列
            // 取得屠龍刀
            Debug.Log($"<color=#f3d>編號[0,1,1]的道具：{shop[0,1, 1]}</color>");

            // 設定高級球為超級球
            shop[1, 0, 1] = "超級球";
            Debug.Log($"<color=#f3d>編號[1,0,1]的道具：{shop[1, 0, 1]}</color>");


            // 獲得陣列的長度和維度
            // 一維 ~ 多維陣列的長度：陣列名稱.Length
            Debug.Log($"<color=#f93>一維 - 牌組 2 的長度：{deck2.Length}</color>");
            Debug.Log($"<color=#f93>二維 - 道具的長度：{inventory.Length}</color>");
            Debug.Log($"<color=#f93>三維 - 商品的長度：{shop.Length}</color>");
            // 陣列的維度：陣列名稱.Rank
            Debug.Log($"<color=#f39>一維 - 牌組 2 的長度：{deck2.Rank}</color>");
            Debug.Log($"<color=#f39>二維 - 道具的長度：{inventory.Rank}</color>");
            Debug.Log($"<color=#f39>三維 - 商品的長度：{shop.Rank}</color>");

        }



    }


}
