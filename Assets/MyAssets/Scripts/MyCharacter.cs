using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacter : MonoBehaviour
{
    [SerializeField]
    private GameObject character = default;

    [SerializeField]
    private int defaultColor = 0;

    [SerializeField]
    private Material[] materials = default;

    [SerializeField]
    private GameObject myCam = default;

    private void Start()
    {
        //ChangeMaterial(defaultColor);
    }

    public void ChangeMaterial(int _index)
    {
        character.GetComponent<Renderer>().material = materials[_index];
    }

    public void CameraOn()
    {
        myCam.SetActive(true);
    }
}
