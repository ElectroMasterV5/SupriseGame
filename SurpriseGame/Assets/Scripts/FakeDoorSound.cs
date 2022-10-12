using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeDoorSound : MonoBehaviour
{
    public GameObject OpenSound;
    private AudioSource openSound;

    // Start is called before the first frame update
    void Start()
    {
        openSound = OpenSound.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PlayopenSound()
    {
        openSound.Play();
    }
}
