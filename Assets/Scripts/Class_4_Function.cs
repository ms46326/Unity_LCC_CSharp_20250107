using UnityEditor.Experimental.GraphView;
using UnityEngine;
/// <summary>
/// 方法
/// 中文：方法、函式、函數、功能
/// 英文：Function、method(Unity)
/// </summary>
public class Class_4_Function : MonoBehaviour
{
    private void Awake()
    {
        #region 方法基本語法與參數呼叫
        // 呼叫方法：方法沒有呼叫不會執行
        // 方法名稱();
        FirstFunction();
        UseSkill("火球術", 30);
        UseSkill("冰錐術", 50);
        SpawnEnemy();
        SpawnEnemy("史萊姆");
        Fire(500);
        Fire(600, "保齡球");
        // 有多個選擇性參數時的呼叫
        // 買紅水，50 個
        BuyItem();
        // 買紅水，30 個
        // BuyItem(30); 錯誤：30會直接帶入到 item 參數導致資料類型不符合
        BuyItem(count: 30);
        // 買藍水，50 個
        BuyItem("藍水");
        // 買藍水，30 個
        BuyItem("藍水",30);
        #endregion



        Debug.Log($"<color=#66f>BMI：{BMI()}</color>");

    }
    //框選要整理的程式 > Ctrl + K S > #region 快速完成程式碼片段
    #region 方法基本語法與參數
    // 方法：
    // 包含一系列程式區塊
    // 方法語法：
    // 修飾詞 傳回資料類型 方法名稱 (參數1，參數2，...，參數N) {程式區塊}
    // 方法命名習慣：Unity 習慣使用大寫開頭命名方法
    // void 無傳回：使用此方法不會傳回資料
    private void FirstFunction()
    {
        Debug.Log("第一個方法");
    }

    // 參數語法：與區域變數相同 資料類型 參數名稱 (習慣用小寫或者加底線開頭)
    private void UseSkill(string skill, float cost)
    {
        Debug.Log($"<color=#f93>施放技能：{skill}</color>");
        Debug.Log($"<color=#f93>技能消耗：{cost}</color>");
    }

    private void SpawnEnemy(string enemy = "哥布林")
    {
        Debug.Log($"<color=#f33>生成敵人：{enemy}</color>");
    }

    // 沒有預設值稱為：必要參數，有預設值稱為選擇性參數
    // 選擇性參數要寫在右邊
    // 
    // 
    // 
    // 
    // 

    /// <summary>
    /// 
    /// </summary>
    /// <param name="speed"></param>
    /// <param name="fire"></param>
    private void Fire(int speed, string fire = "子彈")
    {
        Debug.Log($"<color=#66f>發射物件：{fire},速度：{speed}</color>");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="item">道具名稱</param>
    /// <param name="count">道具數量</param>
    private void BuyItem(string item = "紅水", int count = 50)
    {
        Debug.Log($"<color=#3f3>購買商品：{item},數量：{count}</color>");
    }
    #endregion





    private float BMI(float height = 1.68f, float Weight = 60)
    {
        return Weight / (height * height);
    }









}