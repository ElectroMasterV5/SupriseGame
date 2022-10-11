using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject TeleportPos;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Fuck I hit the wall!");
        if (other.CompareTag("Player"))
        {
            Debug.Log("Fuck I hit the wall Again!");
            other.GetComponent<CharacterController>().enabled = false;
            other.GetComponent<Transform>().position = TeleportPos.GetComponent<Transform>().position;
            other.GetComponent<CharacterController>().enabled = true;
            Debug.Log(other.transform.position);

        }
    }
}
