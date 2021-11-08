using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class Calljs : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void Fuga();

    [DllImport("__Internal")]
    private static extern void HogeHoge();

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
            Fuga();

        if (Input.GetKeyDown(KeyCode.H))
            HogeHoge();
    }

    public void FromJs()
    {
        Debug.Log("From JS");
    }
}
