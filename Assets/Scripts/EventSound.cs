using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventSound : MonoBehaviour {
    AudioSource audioSource;

    void Start () {
        audioSource = GetComponent<AudioSource>();
    }

    void PlaySound () {
        audioSource.Play();
    }
}
