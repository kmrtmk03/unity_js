using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenModal : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {

#if !UNITY_EDITOR
        Calljs.JsDisplayModal();
#endif
    }


    private void OnTriggerExit(Collider other)
    {
#if !UNITY_EDITOR
        Calljs.JsHiddenModal();
#endif
    }
}
