using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource backgroundMusic;
    // Start is called before the first frame update
    void Start()
    {
        backgroundMusic = GetComponent<AudioSource>();
        StartCoroutine(initialDelay());
    }

    IEnumerator initialDelay()
    {
        yield return new WaitForSeconds(PlayerController.initialDelay);
        backgroundMusic.Play();
    }
}
