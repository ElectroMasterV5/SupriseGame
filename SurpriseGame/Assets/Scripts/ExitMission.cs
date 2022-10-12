using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitMission : MonoBehaviour
{
    private Ray ray;
    public int MissionNum = 4;
    public GameObject Player;
    public GameObject Stairs;
    public GameObject HideRoom;
    public GameObject TrueDoor;
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

                if (raycastHit.transform.CompareTag("ExitDoor"))
                {
                    Player.GetComponent<QuestContoller>().setMissionNum(MissionNum);
                    Stairs.SetActive(false);
                    HideRoom.SetActive(true);
                    TrueDoor.SetActive(true);
                }

            }
        }
    }
}
