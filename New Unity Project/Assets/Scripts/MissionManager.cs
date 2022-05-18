using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionManager : MonoBehaviour
{





    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startMission(Mission currentMission)
    {

    }

}

public class Objective
{
    public string objectiveText;
    public bool hasBeenCompleted;

    public void objective(string initObjText, bool initComplete)
    {
        objectiveText = initObjText;
        hasBeenCompleted = initComplete;
    }

    public string GetobjectiveText()
    {
        return objectiveText;
    }
}

public class Mission
{
    public string title;
    public Objective[] missionObjectives;
    public bool isActive;
    public string completionText;

    public void mission(string initTitle, string initCompText, Objective[] initObjectives)
    {
        title = initTitle;
        completionText = initCompText;
        missionObjectives = initObjectives;
        
    }
}



