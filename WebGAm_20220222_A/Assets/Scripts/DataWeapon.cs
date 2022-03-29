using UnityEngine;

namespace NKNK
{
    






    [CreateAssetMenu(menuName = "NKNK/Data Weapon", fileName = "Data Weapon")]
    public class DataWeapon : ScriptableObject
    {
        [Header("����t��"), Range(0, 3500)]
        public float speedFly = 500;
        [Header("�����O"), Range(0, 1000)]
        public float attack = 10;
        [Header("�_�l�ƶq"), Range(1, 5)]
        public float countStart = 1;
        [Header("�ƶq�W��"), Range(0, 50)]
        public float countMax = 20;
        [Header("�������j"), Range(0, 5)]
        public float interval = 3.5f;


        [Header("�ͦ���m")]
        public Vector3[] v2SpawnPoint;
        [Header("�Z������")]
        public GameObject goWeapon;
    }
}
