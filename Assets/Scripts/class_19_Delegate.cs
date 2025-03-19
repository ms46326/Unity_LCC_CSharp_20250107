using AES.Tools;
using UnityEngine;
namespace KID.Class_19
{
    /// <summary>
    /// 委派 Delegate
    /// </summary>
    public class class_19_Delegate : MonoBehaviour
    {
        #region 複習可當參數的變數與元祖
        private void Awake()
        {
            Cure(10);
            Card(("史萊姆", 7));
        }


        // 將 float 當作參數
        private void Cure(float cure)
        {
            LogSystem.LogWithColor($"治癒的值：{cure}", "#3f3");
        }

        private void Card((string name, int index) card)
        {
            LogSystem.LogWithColor($"卡片：{card.name} | {card.index}", "#3f3");
        }
        #endregion

        // 1.宣告委派：簽章 (傳回與參數)
        // 宣告一個無傳回與無參數的委派
        private delegate void DelegateMethod();
        private delegate float Calculate();

        // 2.目標方法：簽章必須與委派相同
        #region 無傳回與吳參數方法
        private void Test()
        {
            LogSystem.LogWithColor("測試", "#f3f");
        }
        private void Talk()
        {
            LogSystem.LogWithColor("哈囉，你好：D", "#f39");
        }
        private void MagicCard()
        {
            LogSystem.LogWithColor("招喚小兵", "#3f3");
        } 
        #endregion
        private float Add(float numberA,float numberB)
        {
            float result = numberA + numberB;
            LogSystem.LogWithColor(result, "#7ff");
            return result;
        }
        private float Sub(float numberA, float numberB)
        {
            float result = numberA - numberB;
            LogSystem.LogWithColor(result, "#7ff");
            return result;
        }
        private float Mul(float numberA, float numberB)
        {
            float result = numberA * numberB;
            LogSystem.LogWithColor(result, "#7ff");
            return result;
        }

        // 3. 宣告變數存放方法 (預設為空值)
        private DelegateMethod delegateMethod;
        private Calculate calculate;

        // 4. 呼叫委派
        private void Start()
        {
            #region 基本委派
            delegateMethod = Test;          // 將方法 Test 存放到變數 delegateMethod 內
            delegateMethod += Talk;
            delegateMethod += MagicCard;
            delegateMethod -= Test;

            delegateMethod();
            #endregion

            //calculate += Add;


        }

        // 委派：將方法當作變數




    }
}

