using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyAssets
{

    public class MyController : MonoBehaviour
    {
        [SerializeField]
        private GameObject myCharactor = default;
        private Animator animator = null;

        private void Start()
        {
            animator = myCharactor.GetComponent<Animator>();

        }

        private void Update()
        {
            //前後
            if (Input.GetKey(KeyCode.W))
            {
                this.WalkFront();
            }
            else if(Input.GetKey(KeyCode.S))
            {
                this.WalkBack();
            }

            //左右
            if (Input.GetKey(KeyCode.D))
            {
                this.TurnRight();
            }
            else if (Input.GetKey(KeyCode.A))
            {
                this.TurnLeft();
            }

            if(Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
            {
                animator.SetBool("isWalk", false);
            }
        }


        public void WalkFront()
        {
            gameObject.transform.position += transform.forward * Time.deltaTime * 2.0f;
            animator.SetBool("isWalk", true);
        }

        public void WalkBack()
        {
            gameObject.transform.position -= transform.forward * Time.deltaTime * 1.0f;
            animator.SetBool("isWalk", true);
        }

        public void TurnLeft()
        {
            gameObject.transform.Rotate(Vector3.up * Time.deltaTime * -100.0f);
        }

        public void TurnRight()
        {
            gameObject.transform.Rotate(Vector3.up * Time.deltaTime * 100.0f);
        }
    }
}