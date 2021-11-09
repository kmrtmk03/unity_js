using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoTrigger : MonoBehaviour
{
    [SerializeField]
    private int myIndex = 0;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("photo-3");
#if !UNITY_EDITOR
        Calljs.JsDisplayModalInt(myIndex);
#endif
    }


    private void OnTriggerExit(Collider other)
    {
#if !UNITY_EDITOR
        Calljs.JsHiddenModal();
#endif
    }
}
