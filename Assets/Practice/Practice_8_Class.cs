using UnityEngine;
namespace AES
{
    public class Practice_8_Class : MonoBehaviour
    {
        private void Awake()
        {
            // ��Ҥƨ�� BOSS
            BOSS Boss1 = new BOSS("�s�~","�s���R��",2999);
            BOSS Boss2 = new BOSS("�P�Ůy","������",3999);
            Boss1.BossName();
            Boss1.SecretName();
            Boss1.GetHP();
            Debug.Log($"<color=#f93>Boss�W�١G{Boss2.name}�A�j���ۦW�١G{Boss2.secretName}�A��q�G{Boss2.hp}");
        }        
    }
    
    // �إ� BOSS ���O�A�þ֦��W�١B�j���ۦW�٥H�Φ�q
    public class BOSS 
    {
        public string name;
        public string secretName;
        public int hp;

        // ��@�غc�l�i�H�ᤩ�W�١B�ۦ��W�ٻP��q
        public BOSS(string _name, string _secretName, int _hp)
        {
            name = _name;
            secretName = _secretName;
            hp = _hp;
        }   

        public void BossName() 
        {
            Debug.Log($"<color=#33f>Boss ���W�١G{name}</color>");
        }

        public void SecretName() 
        {
            Debug.Log($"<color=#3f3>�j���۪��W�١G{secretName}</color>");
        }

        public void GetHP() 
        {
            Debug.Log($"<color=#3f3>��q�G{hp}</color>");
        }

    }
    

}

