using UnityEngine;

namespace NKNK
{



    public class HurtSystem : MonoBehaviour
    {
        [SerializeField, Header("��q"), Range(0, 10000)]
        private float hp;





        public void GetHurt(float damage)
        {
            hp -= damage;
            print("</color=pink>���쪺�ˮ`:" + damage + "</color>");

            if (hp <= 0) Dead();
        }




        private void Dead()
        {
            hp = 0;
            print("<color=pink>���⦺�`:" + gameObject + "</color>");
        }
    }
}