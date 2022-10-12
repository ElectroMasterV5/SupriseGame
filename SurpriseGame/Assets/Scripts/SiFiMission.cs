using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiFiMission : MonoBehaviour
{
    private Ray ray;
    public int MissionNum = 3;
    public GameObject Player;
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

                if (raycastHit.transform.CompareTag("SiFiDoor"))
                {
                    Player.GetComponent<QuestContoller>().setMissionNum(MissionNum);
                }

            }
        }
    }
}
