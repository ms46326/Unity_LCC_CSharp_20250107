using AES.Tools;
using UnityEngine;
namespace KID
{
    /// <summary>
    /// �h�� Polymorphism
    /// </summary>
    public class class_10_2_Polymorphism : MonoBehaviour
    {
        private void Awake()
        {
            Trap trap1 = new Trap("����",3);
            Magic magic1 = new Magic("���̵d��",5);
            // �h���G�h�ث����A�i�H�ϥΤ����O�Ϊ̦ۤv������
            trap1.Information();
            trap1.Information(37);

            // �h���G�ŧi�ɨϥΤ����O�A��Ҥƪ����O�|�M�w����
            Card card1 = new Card("�@��d��", 0);
            Card magic2 = new Magic("�Ф�", 7);
            card1.Information();        // ����1�G�I�s Card ����k
            magic2.Information();       // ����2�G�I�s Magic ����k

        }
    }

    public class Card 
    {
        public string name;
        public int cost;
        public Card(string _name, int _cost) 
        {
            name = _name;
            cost = _cost;
        }
        public virtual void Information() 
        {
            LogSystem.LogWithColor($"{name}�o�O�@�i�d�P", "#3f3");
        }
    }

    public class Trap : Card
    {
        public Trap(string _name, int _cost) : base(_name, _cost)
        {
        }
        public void Information(int index)
        {
            LogSystem.LogWithColor($"�o�O�@�i�����d�P �s���G{index}", "#f77");
        }
    }

    public class Magic : Card
    {
        public Magic(string _name, int _cost) : base(_name, _cost)
        {
        }

        public override void Information() 
        {
            LogSystem.LogWithColor($"{name}�o�O�@�i�]�k�d�P", "#77f");
        }
    }
}

