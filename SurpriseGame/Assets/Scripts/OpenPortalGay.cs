using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPortalGay : MonoBehaviour
{
    public bool Open = false;
    private Ray ray;
    public GameObject B_Door;
    public GameObject O_Door;
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
                Debug.Log("Hitttt");
                if (raycastHit.transform.CompareTag("PortalDoor"))
                {
                    Debug.Log("teleport");
                    O_Door.GetComponent<OpenPortalGay>().SetOpenP();
                    B_Door.GetComponent<OpenPortalGay>().SetOpenP();
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
            O_Door.GetComponent<Rigidbody>().AddForce(new Vector3(1, 0, 1));
            B_Door.GetComponent<Rigidbody>().AddForce(new Vector3(-1, 0, -1));
        }
        if (Open)
        {
            O_Door.GetComponent<Rigidbody>().AddForce(new Vector3(-1, 0, -1));
            B_Door.GetComponent<Rigidbody>().AddForce(new Vector3(1, 0, 1));
        }
    }
}
