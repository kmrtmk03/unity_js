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

        //開発用
#if UNITY_EDITOR
        audioSource.Play();
#endif
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
