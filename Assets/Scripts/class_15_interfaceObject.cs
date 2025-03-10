using AES.Tools;
using UnityEngine;
namespace KID.Class_15
{
    /// <summary>
    /// 介面物件：實作介面的物件
    /// </summary>
    public class class_15_interfaceObject
    {

    }

    // 介面的使用步驟
    // 1.定義介面與介面成員
    // 2.類別實作介面
    // 3.實作介面的成員

    // 步驟1.
    // 帶有「使用」功能的介面，遊戲內可被使用的物品
    public interface IUse   // 淺規則：只要是 I 開頭都是介面
    {
        // 不用宣告方法主體，不用寫大括號
        public void Use();
    }

    public interface IDestory
    {
        public void Destory();
    }

    // 步驟2
    // C# 單一繼承，多重實作介面
    public class Weapon : IUse  //這時候IUse會出現紅蚯蚓，點紅蚯蚓就是步驟3.
    {
        // 步驟3.
        public void Use()
        {
            // throw new System.NotImplementedException();  // 這行要刪掉，不然會出現錯誤
            LogSystem.LogWithColor("使用武器，施展武器技能", "#fa3");
        }
    }

    public class Potion : IUse , IDestory   //實作多重介面，實作第二個介面
    {
        public void Destory()
        {
            LogSystem.LogWithColor("藥水使用完畢，刪除", "#f11");
        }

        public void Use() 
        {
            LogSystem.LogWithColor("使用藥水，恢復體力", "#a3f");
        }
    }

    public class Chest : IUse, IDestory
    {
        public void Destory()
        {
            LogSystem.LogWithColor("寶箱使用完畢，刪除", "#f11");
        }

        public void Use()
        {
            LogSystem.LogWithColor("使用寶箱，獲得隨機道具", "#af3");
        }
    }



}

