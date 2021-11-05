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
            if (Input.GetKey(KeyCode.W))
            {
                gameObject.transform.position += transform.forward * Time.deltaTime * 2.0f;
                animator.SetBool("isWalk", true);
            }
            else if(Input.GetKey(KeyCode.S))
            {
                gameObject.transform.position -= transform.forward * Time.deltaTime * 1.0f;
                animator.SetBool("isWalk", true);
            }
            else if (Input.GetKey(KeyCode.D))
            {
                gameObject.transform.Rotate(Vector3.up * Time.deltaTime * 150.0f);
            }
            else if (Input.GetKey(KeyCode.A))
            {
                gameObject.transform.Rotate(Vector3.up * Time.deltaTime * -150.0f);
            }

            if(Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
            {
                animator.SetBool("isWalk", false);
            }
        }
    }
}