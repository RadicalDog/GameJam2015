using UnityEngine;
using System.Collections;

public class CircleScript : MonoBehaviour
{

    public float scaleSnap;
    public int upperRadiusLimit;
    public GameObject centerSpot;
    public Transform thisTransform;
    int radiusNumber = 0;

    // Use this for initialization
    void Start()
    {
        //rebuild(10, 5, 5);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    scaleCircleUp();
        //}
        //if (Input.GetMouseButtonDown(1))
        //{
        //    scaleCircleDown();
        //}
    }

    public void rebuild(int radius, float x, float y)
    {
        thisTransform.position = new Vector2(x, y);
        scaleCircle(radius);
    }

    public void scaleCircle(int factor)
    {
        radiusNumber = factor;
        thisTransform.localScale = new Vector3((radiusNumber * scaleSnap), (radiusNumber * scaleSnap), thisTransform.localScale.z);
    }

    public int scaleCircleUp()
    {
        if (radiusNumber < upperRadiusLimit)
        {
            radiusNumber += 1;
            scaleCircle(radiusNumber);
        }
        return radiusNumber;
    }

    public int scaleCircleDown()
    {
        if (radiusNumber > 1)
        {
            radiusNumber -= 1;
            scaleCircle(radiusNumber);
        }
        return radiusNumber;
    }


}
