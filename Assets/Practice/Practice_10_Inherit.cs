using AES.Tools;
using UnityEngine;
namespace KID
{
    public class Practice_10_Inherit
    {

    }

    public class Item 
    {
        public string name;
        
        public Item(string _name) => name = _name;

        public virtual void Use() 
        {
            LogSystem.LogWithColor($"{name} �D��A�ϥ� Item ��k", "#f33");
        }
    }

    public class Potion : Item 
    {
        public Potion(string _name) : base(_name)
        {
        }

        


    }





}

