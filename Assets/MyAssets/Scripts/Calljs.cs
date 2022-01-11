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

    [DllImport("__Internal")]
    private static extern void DisplayModal();

    [DllImport("__Internal")]
    private static extern void HiddenModal();

    [DllImport("__Internal")]
    private static extern void DisplayModalInt(int _index);

    [DllImport("__Internal")]
    private static extern void CompleteLoad();

    public void FromJs()
    {
        Debug.Log("From JS");
    }

    public static void JsDisplayModal()
    {
        DisplayModal();
    }

    public static void JsHiddenModal()
    {
        HiddenModal();
    }

    public static void JsDisplayModalInt(int _index)
    {
        DisplayModalInt(_index);
    }

    public static void JsCompleteLoad()
    {
        CompleteLoad();
    }
}
