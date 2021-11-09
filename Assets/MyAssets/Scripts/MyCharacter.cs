using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacter : MonoBehaviour
{
    [SerializeField]
    private GameObject character = default;

    [SerializeField]
    private Material[] materials = default;

    public void ChangeMaterial(int _index)
    {
        character.GetComponent<Renderer>().material = materials[_index];
    }
}
