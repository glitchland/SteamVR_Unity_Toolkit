namespace VRTK
{
    using UnityEngine;
    using System.Collections;

    public class VRTK_ControllerAnimations : MonoBehaviour
    {

        public Animator anim;
        int idle = Animator.StringToHash("Idle");
        int point = Animator.StringToHash("Point");
        int grabLarge = Animator.StringToHash("GrabLarge");
        int grabSmall = Animator.StringToHash("GrabSmall");
        int grabStickUp = Animator.StringToHash("GrabStickUp");
        int grabStickFront = Animator.StringToHash("GrabStickFront");
        int thumbUp = Animator.StringToHash("ThumbUp");
        int fist = Animator.StringToHash("Fist");
        int gun = Animator.StringToHash("Gun");
        int gunShoot = Animator.StringToHash("GunShoot");
        int pushButton = Animator.StringToHash("PushButton");
        int spread = Animator.StringToHash("Spread");
        int middleFinger = Animator.StringToHash("MiddleFinger");
        int peace = Animator.StringToHash("Peace");
        int OK = Animator.StringToHash("OK");

        // Use this for initialization
        void Start()
        {
            if (!anim)
            {
                Debug.LogError("No animator assigned to VRTK_ControllerAnimations");
            }
        }

        public void Grab()
        {
            GrabSmall();
        }

        public void GrabSmall()
        {
            if (!anim)
                return;

            anim.SetTrigger(grabSmall);
        }

        public void GrabLarge()
        {
            if (!anim)
                return;

            anim.SetTrigger(grabLarge);
        }

        public void GrabStickUp()
        {
            if (!anim)
                return;

            anim.SetTrigger(grabStickUp);
        }

        public void GrabStickFront()
        {
            if (!anim)
                return;

            anim.SetTrigger(grabStickFront);
        }

        public void Idle()
        {
            if (!anim)
                return;

            anim.SetTrigger(idle);
        }
        
    }
}
