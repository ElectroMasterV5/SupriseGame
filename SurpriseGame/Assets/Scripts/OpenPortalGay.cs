using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPortalGay : MonoBehaviour
{
    public bool Open = false;
    private Ray ray;
    public GameObject B_Door;
    public GameObject O_Door;
    public int DoorType;
    public ParticleSystem PP;
    public AudioSource GLaDOS;
    public AudioClip G1;
    public AudioClip G2;
    public AudioClip G3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {

            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit raycastHit, 10f))
            {
                
                if (raycastHit.transform.CompareTag("PortalDoor"))
                {
                   
                    this.GetComponent<OpenPortalGay>().SetOpenP();
                   
                }
               
            }
        }
        PortalOpen();
    }
    public void SetOpenP()
    {
        Open = !Open;

    }
    public void PortalOpen()
    {
        if (!Open)
        {
            PP.Stop();
            if (DoorType == 1)
            {
                int a = Random.Range(0, 3);
                if (a == 1)
                {
                    GLaDOS.clip = G1;
                    GLaDOS.Play();
                }
                if (a == 2 )
                {
                    GLaDOS.clip = G2;
                    GLaDOS.Play();
                }
                if (a == 0)
                {
                    GLaDOS.clip = G3;
                    GLaDOS.Play();
                }
                O_Door.GetComponent<Rigidbody>().AddForce(new Vector3(1, 0, 1));
            }
            if (DoorType == 2)
            {
                B_Door.GetComponent<Rigidbody>().AddForce(new Vector3(-1, 0, -1));
            }
         
        }
        if (Open)
        {
            PP.Play();
            
            if (DoorType == 1)
            {
               
                O_Door.GetComponent<Rigidbody>().AddForce(new Vector3(-1, 0, -1));
            }
            if (DoorType == 2)
            {
                B_Door.GetComponent<Rigidbody>().AddForce(new Vector3(1, 0, 1));
            }
            
        }
    }
}
