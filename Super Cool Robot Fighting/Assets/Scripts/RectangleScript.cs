using UnityEngine;
using System.Collections;

public class RectangleScript : MonoBehaviour
{

    public float rotationSnap;
    public float scaleSnap;
    public int upperScaleLimit;
    public GameObject leftSpot;
    public GameObject middleSpot;
    public GameObject rightSpot;
    public Transform thisTransform;
    int rotationNumber = 0;
    int scaleNumber = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            scaleLengthUp();
            Debug.Log(scaleNumber);
        }
        if (Input.GetMouseButtonDown(1))
        {
            scaleLengthDown();
            Debug.Log(scaleNumber);
        }
    }

    public void rotateRectangle()
    {
        thisTransform.eulerAngles = new Vector3(thisTransform.eulerAngles.x, thisTransform.eulerAngles.y, rotationSnap * rotationNumber);
    }

    public int rotateRectangleClockwise()
    {
        rotationNumber += 1;
        rotateRectangle();
        return rotationNumber;
    }

    public int rotateRectangleAnticlockwise()
    {
        if (rotationNumber != 1)
        {
            rotationNumber -= 1;
        }
        rotateRectangle();
        return rotationNumber;
    }

    public void scaleLength(int factor)
    {
        scaleNumber = factor;
        thisTransform.localScale = new Vector3((scaleNumber * scaleSnap), thisTransform.localScale.y, thisTransform.localScale.z);
    }

    public int scaleLengthUp()
    {
        if (scaleNumber < upperScaleLimit)
        {
            scaleNumber += 1;
            scaleLength(scaleNumber);
        }
        return scaleNumber;
    }

    public int scaleLengthDown()
    {
        if (scaleNumber > 1)
        {
            scaleNumber -= 1;
            scaleLength(scaleNumber);
        }
        return scaleNumber;
    }



}
