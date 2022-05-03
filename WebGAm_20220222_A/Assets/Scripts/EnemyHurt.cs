using UnityEngine;

namespace NKNK
{
    public class EnemyHurt : HurtSystem
    {
        [SerializeField, Header("�ĤH���")]
        private DataEnemy data;

        private void Awake()
        {
            hp = data.hp;
        }
    }
}
