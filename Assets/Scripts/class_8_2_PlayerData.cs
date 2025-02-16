using UnityEngine;
namespace MyNamespace
{
    /// <summary>
    /// 結構：通常用來保存資料，不能繼承 MonoBehaviour
    /// </summary>
    public struct class_8_2_PlayerData
    {
        public int lv;
        public float hp;
        
        public class_8_2_PlayerData(int _lv,float _hp) 
        {
            lv = _lv;
            hp = _hp;
        }
    }
}

