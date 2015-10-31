using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RobotController : MonoBehaviour {

	// Contains data to be used in building and resetting robots

    List<solids> DataSolids = new List<solids>();
    List<joints> DataJoints = new List<joints>();

	void Start () {
        Debug.Log("adasdasds");
        solids crappySolid = new solids();
        DataSolids.Add(crappySolid);
        DataSolids.Add(crappySolid);
        DataSolids.Add(crappySolid);
        Debug.Log(DataSolids);

        updateRobot();
	}
	
	// Update is called once per frame
	void Update () {

        //debugging without showing a billion messages
        if (Random.value < 0.02)
        {
            updateRobot();
        }
        
	}

    void updateRobot()
    {
        //Deal with updating robot
        Debug.Log("starting update");
        DataSolids.ForEach(solidBuild);
        DataJoints.ForEach(jointBuild);
    }

    private void jointBuild(joints obj)
    {
        //build the joints
    }

    private void solidBuild(solids obj)
    {
        //Build a solid!
        
    }
}

public class solids
{
    float height = 10;
    float width = 10;
    float rotation = 0;
    int type = 1;
}

public class joints
{
    int type = 1;
    int rootConnection;
    int targConnection;
}