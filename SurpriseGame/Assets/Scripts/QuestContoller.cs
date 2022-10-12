using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class QuestContoller : MonoBehaviour
{
    public int MissionNum = 1;
    public TextMeshProUGUI MissionBar;
    public int MusicNumC = 1;
    public AudioSource QuestC;
    public GameObject QuestCube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (MissionNum == 2)
        {
            MissionBar.text = "Go back to your room.";
        }
        if (MissionNum == 3)
        {
            MissionBar.text = "You may not want to get in there.";
        }
        if (MissionNum == 4)
        {
            MissionBar.text = "Do not use the Emergency Exit when there is no emergency! You Still can't find your room? Fine I'll show you.";
        }
        if (MissionNum == 5)
        {
            MissionBar.text = "You got rick&rolled!!!";
        }
        if (MissionNum == 6)
        {
            MissionBar.text = "Turn on the light";
        }



        if (MusicNumC != MissionNum && (MissionNum==2 || MissionNum == 6))
        {
            QuestC.Play();
            MusicNumC = MissionNum;

        }
        if (QuestC.isPlaying)
        {
            QuestCube.SetActive(true);
        }
        if (!QuestC.isPlaying)
        {
            QuestCube.SetActive(false);
        }
    }
   public void setMissionNum(int a)
    {
        MissionNum = a;
    }
}
