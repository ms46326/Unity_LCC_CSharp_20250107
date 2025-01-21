using UnityEngine;
//命名空間：
//將類別分類，類似倉庫的概念，不同倉庫可以有相同名稱類別。
//語法：namespace 命名空間名稱 { 內容 }
namespace KID
{
    /// <summary>
    /// 選取陳述式 Selection Statement
    /// 1. if 判斷式
    /// 2. Switch 判斷式
    /// </summary>
    public class class_5_1_Selection : MonoBehaviour
    {
        [SerializeField, Header("是否開門")]
        private bool isOpen;
        [SerializeField, Header("分數"), Range(0,100)]
        private int score = 100;
        [SerializeField, Header("武器")]
        private string weapon ;
        [SerializeField, Header("血量"),Range(0,100)]
        private float hp ;

        private void Awake()
        {
            // if判斷式
            // if (布林值) { 陳述式 }
            if (true)
            {
                Debug.Log("布林值為 True，會執行這裡。");
            }

            // 快速完成：輸入 if 選取 if 陳述式按 Enter 或 Tab
            if (false)
            {
                Debug.Log("布林值為 False，不會執行這裡而且會有綠蚯蚓。");
            }
        }

        // 更新事件：一秒鐘執行約 60 次 ( 60 FPS ) Frame Per Second
        private void Update()
        {
            // 常用快捷鍵
            // 1. 格式化 (排版) Ctrl + K D
            // 2. 程式碼片段 Ctrl + K S 選 region
            #region 判斷式 if
            Debug.Log("<color=#79f>更新事件</color>");

            // 如果 isOpen 布林值等於 True ，就顯示已經開門。
            if (isOpen)
            {
                Debug.Log("<color=#f93>已經開門</color>");
            }
            // 否則 isOpen 布林值等於 False ，就顯示關門了。
            else
            {
                Debug.Log("<color=#f93>關門了</color>");
            }

            // 比較運算子、邏輯運算子結果為布林值
            // if 會在最上方、else 會在最下方，中間可以有多個 else if 
            // 如果 分數 >= 60 就通過
            if (score >= 60)
            {
                Debug.Log("<color=#3f3>恭喜你 C# 通過了</color>");
            }
            // 否則 如果 分數 >= 40 可以補考
            else if (score >= 40)
            {
                Debug.Log("<color=#f96>你 C# 可以補考</color>");
            }
            // 否則 如果 分數 >= 20 可以補考但是要做一個 C# 小專題
            else if (score >= 20)
            {
                Debug.Log("<color=#f9a>你 C# 可以補考但是要做一個 C# 小專題</color>");
            }
            // 否則 當掉
            else
            {
                Debug.Log("<color=#f33>你的 C# 被當了</color>");
            }

            #endregion

            #region 判斷式 switch
            // switch 判斷式
            // switch (要判斷的值) { 陳述式 }
            // 快速完成：switch + ( Tab * 2 )
            switch (weapon)
            {
                // case 值:
                // 當判斷的值等於值時會執行這裡
                // break; 跳出判斷式
                // 如果武器等於小刀，攻擊力等於20
                case "蝴蝶刀":
                // 不加break，會一直往下執行，直到遇到break;
                case "小刀":
                    Debug.Log("<color=#ff3>攻擊力 ： 20</color>");
                    break;
                case "美工刀":
                    Debug.Log("<color=#ff3>攻擊力 ： 10</color>");
                    break;
                case "屠龍刀":
                    Debug.Log("<color=#ff3>攻擊力 ： 999</color>");
                    break;
                // else
                default:
                    Debug.Log("<color=#ff3>這是不能使用的武器</color>");
                    break; 
                    
            }
            #endregion

            #region Practice switch
            switch (hp)
            {
                case  >= 80:
                    Debug.Log("<color=#ff3>血量安全</color>");
                    break;
                case >= 60:
                    Debug.Log("<color=#ff3>健康狀態有狀況</color>");
                    break;
                case >= 40:
                    Debug.Log("<color=#ff3>警告，快喝水</color>");
                    break;
                case > 10:
                    Debug.Log("<color=#ff3>快死掉了</color>");
                    break;
                case <= 0 :
                    Debug.Log("<color=#ff3>你已經死了</color>");
                    break;
                default :
                    Debug.Log("<color=#ff3></color>");
                    break;
            } 
            #endregion
        }

    }

}
