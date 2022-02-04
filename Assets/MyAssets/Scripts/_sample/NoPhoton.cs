using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoPhoton : MonoBehaviour
{
    private void Awake()
    {
#if !UNITY_EDITOR
        Calljs.JsCompleteLoad();
#endif
    }
}
