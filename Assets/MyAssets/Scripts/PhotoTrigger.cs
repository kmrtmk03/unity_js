using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoTrigger : MonoBehaviour
{
    [SerializeField]
    private int myIndex = 0;

    private void OnTriggerEnter(Collider other)
    {
        GameObject gameObject = other.gameObject;
        bool isPlayer = gameObject.GetComponent<MyCharacter>().isActiveAndEnabled;

        if(isPlayer)
        {
            Debug.Log("Hit Collider");
#if !UNITY_EDITOR
            Calljs.JsDisplayModalInt(myIndex);
#endif
        }
    }


    private void OnTriggerExit(Collider other)
    {
        GameObject gameObject = other.gameObject;
        bool isPlayer = gameObject.GetComponent<MyCharacter>().isActiveAndEnabled;

        if (isPlayer)
        {
            Debug.Log("Leave Collider");
#if !UNITY_EDITOR
            Calljs.JsHiddenModal();
#endif
        }
    }
}
