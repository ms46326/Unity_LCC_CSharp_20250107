using NUnit.Framework.Internal;
using UnityEngine;
namespace KID
{
    /// <summary>
    /// 陣列 Array
    /// </summary>
    public class class_6_2_Array : MonoBehaviour
    {
        #region 一 ~ 三微陣列
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
        public string[] deck2 = { "急凍鳥", "賭霞", "寶石海星" };

        // 二維陣列
        public string[,] inventory = { { "紅色藥水", "藍色藥水" }, { "炸彈", "金幣" } };

        // 三維陣列
        public string[,,] shop =
        {
            { {"小刀","美工刀"},{"武士刀","屠龍刀" } },
            { {"精靈球","高級球"},{"大師球","巢穴球" } }
        };
        #endregion

        private int[][] numbers = new int[2][];
        private int[][,] count = new int[2][,];


        private void Start()
        {
            #region 一維陣列
            Debug.Log($"<color=#f32>Cards 的第三張卡片：{cards[2]}</color>");



            deck2[2] = "傑尼龜";
            Debug.Log($"<color=#f39>編號[0,1]的道具：{deck2[2]}</color>");
            #endregion

            #region 二維與三維陣列
            // 存取二維陣列
            Debug.Log($"<color=#3f3>編號[0,1]的道具：{inventory[0, 1]}</color>");

            inventory[1, 1] = "好傷藥";
            Debug.Log($"<color=#3f3>編號[1,1]的道具：{inventory[1, 1]}</color>");

            // 存取三維陣列
            // 取得屠龍刀
            Debug.Log($"<color=#f3d>編號[0,1,1]的道具：{shop[0, 1, 1]}</color>");

            // 設定高級球為超級球
            shop[1, 0, 1] = "超級球";
            Debug.Log($"<color=#f3d>編號[1,0,1]的道具：{shop[1, 0, 1]}</color>");
            #endregion


            #region 陣列長度和維度
            // 獲得陣列的長度和維度
            // 一維 ~ 多維陣列的長度：陣列名稱.Length
            Debug.Log($"<color=#f93>一維 - 牌組 2 的長度：{deck2.Length}</color>");
            Debug.Log($"<color=#f93>二維 - 道具的長度：{inventory.Length}</color>");
            Debug.Log($"<color=#f93>三維 - 商品的長度：{shop.Length}</color>");
            // 陣列的維度：陣列名稱.Rank
            Debug.Log($"<color=#f39>一維 - 牌組 2 的長度：{deck2.Rank}</color>");
            Debug.Log($"<color=#f39>二維 - 道具的長度：{inventory.Rank}</color>");
            Debug.Log($"<color=#f39>三維 - 商品的長度：{shop.Rank}</color>"); 
            #endregion


            // 不規則陣列：基本練習
            // 指定第一列 numbers[0] = {1,3,5};  這是新版的寫法，目前版本不支援
            numbers[0] = new int[] { 1, 3, 5 };
            // 指定第二列，在放一個陣列，與第一陣列元素不同。
            numbers[1] = new int[] { 9, 8 };

            //取得數字 3 和 9
            Debug.Log($"<color=#3ff>不規則陣列的數字 3 ：{numbers[0][1]}</color>");
            Debug.Log($"<color=#3ff>不規則陣列的數字 9 ：{numbers[1][0]}</color>");

            //將 8 改成 6
            numbers[1][1] = 6;
            Debug.Log($"<color=#3ff>第二列的第二層 ：{numbers[1][1]}</color>");

            //不規則陣列：包含多微陣列
            count[0] = new int[,] { { 1, 1 },{ 1, 1 } };
            count[1] = new int[,] { { 2, 2, 2 }, { 2, 2, 2 } };
            Debug.Log($"<color=#3ff>count 第二列的 [ 0, 0 ] ：{count[1][0,0]}</color>");



        }



    }


}
