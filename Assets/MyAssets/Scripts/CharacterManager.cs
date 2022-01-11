using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public static CharacterManager instance = null;

    [System.NonSerialized]
    public MyCharacter myCharacter = null;

    //
    private int materialIndex = 0;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void SetMaterialIndex(int _index)
    {
        materialIndex = _index;
    }

    public int MaterialIndex
    {
        set
        {
            materialIndex = value;
        }
    }

    public void ChangeMaterial()
    {
        myCharacter.ChangeMaterial(materialIndex);
    }
}
