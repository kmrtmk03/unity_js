using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenModal : MonoBehaviour
{

    [SerializeField]
    private ParticleSystem ps = default;

    private void OnTriggerEnter(Collider other)
    {

        ps.Stop();

#if !UNITY_EDITOR
        Calljs.JsDisplayModal();
#endif
    }


    private void OnTriggerExit(Collider other)
    {
        ps.Play();

#if !UNITY_EDITOR
        Calljs.JsHiddenModal();
#endif
    }
}
