using UnityEngine;
namespace AES
{
    public class Practice_8_Class : MonoBehaviour
    {
        private void Awake()
        {
            // 實例化兩個 BOSS
            BOSS Boss1 = new BOSS("龍獸","龍之吐息",2999);
            BOSS Boss2 = new BOSS("烈空座","光束砲",3999);
            Boss1.BossName();
            Boss1.SecretName();
            Boss1.GetHP();
            Debug.Log($"<color=#f93>Boss名稱：{Boss2.name}，大絕招名稱：{Boss2.secretName}，血量：{Boss2.hp}");
        }        
    }
    
    // 建立 BOSS 類別，並擁有名稱、大絕招名稱以及血量
    public class BOSS 
    {
        public string name;
        public string secretName;
        public int hp;

        // 實作建構子可以賦予名稱、招式名稱與血量
        public BOSS(string _name, string _secretName, int _hp)
        {
            name = _name;
            secretName = _secretName;
            hp = _hp;
        }   

        public void BossName() 
        {
            Debug.Log($"<color=#33f>Boss 的名稱：{name}</color>");
        }

        public void SecretName() 
        {
            Debug.Log($"<color=#3f3>大絕招的名稱：{secretName}</color>");
        }

        public void GetHP() 
        {
            Debug.Log($"<color=#3f3>血量：{hp}</color>");
        }

    }
    

}

