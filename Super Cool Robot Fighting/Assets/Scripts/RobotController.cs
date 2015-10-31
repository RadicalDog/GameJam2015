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

    void updateRobot()
    {
        //Deal with updating robot
        
        //destroy
        deleteRobot();

        //create
        DataSolids.ForEach(solidBuild);
        DataJoints.ForEach(jointBuild);

    }

    private void jointBuild(joints obj)
    {
        //build the joints
        obj.h = DataSolids[1].o.AddComponent<HingeJoint2D>();
        obj.h.connectedBody = DataSolids[0].o.GetComponent<Rigidbody2D>();

        obj.h.anchor = new Vector2(obj.conX, obj.conY);
        obj.h.connectedAnchor = new Vector2(obj.axX, obj.axY);
        Debug.Log("hinge "+obj.h);
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
    //type 1: loose
    //type 2: fixed
    //type 3: motorised clockwise
    //type 4: motorised anti-clockwise
    public int type = 1;
    public int rootConnection;
    public int targConnection;
    public float conX = 0f;
    public float conY = 0f;
    public float axX = 0.5f;
    public float axY = 1f;
    public HingeJoint2D h;
}