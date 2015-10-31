using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RobotController : MonoBehaviour {

	// Contains data to be used in building and resetting robots

    public List<solids> DataSolids = new List<solids>();
    public List<joints> DataJoints = new List<joints>();

    public GameObject Rectangle;
    public GameObject Circle;
    public GameObject Triangle;

	void Start () {
<<<<<<< HEAD
        addShape(2, 0);
        addShape(2, 0);
        addShape(2, 1);
=======
        //addShape(3, 0);
        addShape(1, 1);
        ///addShape(2, 2);
>>>>>>> origin/Thomas


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

    //add shape
    public void addShape(int type, int connection)
    {
        Debug.Log("addShape()");
        solids crappySolid = new solids();
        crappySolid.ID = DataSolids.Count;
        DataSolids.Add(crappySolid);

        joints crappyJoint = new joints();
        crappyJoint.type = type;
        crappyJoint.from = crappySolid.ID;
        crappyJoint.to = connection;
        DataJoints.Add(crappyJoint);

        updateRobot();
    }

    private void jointBuild(joints obj)
    {
        //build the joints
        if (obj.from != 0)
        {
            obj.h = DataSolids[obj.to].o.AddComponent<HingeJoint2D>();
            obj.h.connectedBody = DataSolids[obj.from].o.GetComponent<Rigidbody2D>();

            if (obj.type == 2)
            {
                JointLimits limits = hingeJoint.limits;
                limits.min = 20;
                limits.max = 21
                obj.h.limits = limits;
                obj.h.useLimits = true;
            }
            
            obj.h.anchor = new Vector2(obj.conX, obj.conY);
            obj.h.connectedAnchor = new Vector2(obj.axX, obj.axY);
            Debug.Log("hinge " + obj.h);
        }
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
    public int ID = 0;
    public int height = 3;
    public int width = 3;
    public int rotation = 0;
    public float x = 0;
    public float y = 2;
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
    public int from;
    public int to;
    public int rootConnection;
    public int targConnection;
    public float conX = 0f;
    public float conY = 0f;
    public float axX = 0f;
    public float axY = 0.5f;
    public HingeJoint2D h;
}