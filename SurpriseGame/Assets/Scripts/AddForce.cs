using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    public bool Open=false;
    public bool SlideOpen = false;
    private Ray ray;
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
                
                if (raycastHit.transform.CompareTag("Door"))
                {
                   
                    raycastHit.transform.GetComponent<AddForce>().SetOpen();
                }
                if (raycastHit.transform.CompareTag("SlideDoor"))
                {

                    raycastHit.transform.GetComponent<AddForce>().SetSlideOpen();
                }

            }
        }
        OpenDoor();
        OpenSlideDoor();
    }

    public void OpenDoor()
    {
        if (!Open)
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(1, 0, 1));
        }
        if (Open)
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(-1, 0, -1));
        }
    }
    public void OpenSlideDoor()
    {
        if (!SlideOpen)
        {
            if (this.GetComponent<Transform>().position.x > -3.3f)
            {
                this.GetComponent<Transform>().Translate(new Vector3(-1, 0, 0) * Time.deltaTime / 3f);
            }
            
        }
        if (SlideOpen)
        {
            if (this.GetComponent<Transform>().position.x < -2f)
            {
                this.GetComponent<Transform>().Translate(new Vector3(1, 0, 0) * Time.deltaTime / 3f);
            }
                
        }
    }
    public void SetOpen()
    {
        Open = !Open;
    }
    public void SetSlideOpen()
    {
        SlideOpen = !SlideOpen;
    }

}
