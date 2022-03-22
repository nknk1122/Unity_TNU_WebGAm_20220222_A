using UnityEngine;

namespace NKNK
{
    public class TopDownController : MonoBehaviour
    {
        #region ���:�O�s�t�λݭn�����,�Ҧp���ʳt�� �ʵe�ѼƦW�٩Τ��󵥸��
        // ���y�k:�׹��� ������� ���W�� (���w �w�]��);
        // [] �ݩ� Attritube
        // SerializeField �ǦC����� - ���i���� (�X�{�b�ݩʭ��O Inspector)
        // Header ���D
        // Range �d��:  
        [SerializeField, Header("���ʳt��"), Range(0, 500)]
        private float speed = 1.5f;
        private string parameterRun = "�}���]�B";
        private string parameterDead = "�}�����`";
        private Animator ani;
        private Rigidbody2D rig;
        #endregion

        #region �ƥ�:�{�����J�f(Unity)
        // ����ƥ�:����C�������@��,�B�z��l��
        private void Awake()
        {
            // GetComponent<�x��>() - ����������
            // ��� ���w ���o����<����W��>() - ���o���w����s������
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }
        #endregion

        #region ��k:���������欰,�Ҧp���ʥ\�� ��s�ʵe
        #endregion
    }
}
