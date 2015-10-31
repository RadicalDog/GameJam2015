using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RobotController : MonoBehaviour {

	// Contains data to be used in building and resetting robots

    public List<solids> DataSolids = new List<solids>();
    public List<joints> DataJoints = new List<joints>();

    public GameObject Rectangle;
    public GameObject Circle;

	void Start () {
        Debug.Log("adasdasds");
        for (int i = 0; i < 3; i++)
        {
            solids crappySolid = new solids();
            DataSolids.Add(crappySolid);
        }
        Debug.Log(DataSolids);

        joints simple = new joints();
        DataJoints.Add(simple);

        DataSolids[0].x = 1;
        DataSolids[2].x = -1;

        updateRobot();
	}
	
	// Update is called once per frame
	void Update () {
                
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
        obj.h = DataSolids[1].o.AddComponent<HingeJoint2D>();
        obj.h.connectedBody = DataSolids[0].o.GetComponent<Rigidbody2D>();
        Debug.Log("hinge "+obj.h);
            //.rigidbody2D;
    }

    private void solidBuild(solids obj)
    {
        //Build a solid!
        obj.o = Instantiate(Rectangle);
        obj.o.transform.parent = transform;
        obj.o.GetComponent<RectangleScript>().rebuild(obj.width, obj.height, obj.rotation, obj.x, obj.y);
    }

    void deleteRobot()
    {
        DataSolids.ForEach(deleteThisSolid);
        //DataJoints.ForEach(deleteThisJoint);
    }

    private void deleteThisSolid(solids obj)
    {
        Destroy(obj.o);
    }
    private void deleteThisJoint(joints obj)
    {
        throw new System.NotImplementedException();
    }
}

public class solids
{
    public int height = 3;
    public int width = 3;
    public int rotation = 0;
    public float x = 0;
    public float y = 4;
    public GameObject o;
    public int type = 1;
}

public class joints
{
    public int type = 1;
    public int rootConnection;
    public int targConnection;
    public HingeJoint2D h;
}