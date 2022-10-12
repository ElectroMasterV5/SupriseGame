using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlayVideo : MonoBehaviour
{
    public VideoPlayer player;
    public int MissionNum = 5;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.GetComponent<AddForce>().OpenState())
        {
            player.Play();       
            Player.GetComponent<QuestContoller>().setMissionNum(MissionNum);
        
        }
        else
        {
            player.Stop();
        }
    }
}
