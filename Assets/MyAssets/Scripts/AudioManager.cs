using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    private AudioSource audioSource = null;

    private void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    /// <summary>
    /// 音を再生する処理
    /// JSから呼ぶ
    /// </summary>
    public void PlaySound()
    {
        audioSource.Play();
    }
}
