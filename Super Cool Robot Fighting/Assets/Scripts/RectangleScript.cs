using UnityEngine;
using System.Collections;

public class RectangleScript : MonoBehaviour
{

    public float rotationSnap;
    public float scaleSnap;
    public int upperLengthLimit;
    public int upperWidthLimit;
    public GameObject leftSpot;
    public GameObject middleSpot;
    public GameObject rightSpot;
    public Transform thisTransform;
    int rotationNumber = 0;
    int lengthNumber = 0;
    int widthNumber = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            scaleWidthUp();
        }
        if (Input.GetMouseButtonDown(1))
        {
            scaleWidthDown();
        }
    }

    public void rebuild(int length, int width, int rotation, float x, float y)
    {
        scaleLength(length);
        rotateRectangle(rotation);
        scaleWidth(width);
        thisTransform.position = new Vector2(x, y);
    }

    public int getLength()
    {
        return lengthNumber;
    }

    public int getRotation()
    {
        return rotationNumber;
    }

    public void rotateRectangle(int factor)
    {
        rotationNumber = factor;
        thisTransform.eulerAngles = new Vector3(thisTransform.eulerAngles.x, thisTransform.eulerAngles.y, rotationSnap * rotationNumber);
    }

    public int rotateRectangleClockwise()
    {
        rotationNumber += 1;
        rotateRectangle(rotationNumber);
        return rotationNumber;
    }

    public int rotateRectangleAnticlockwise()
    {
        if (rotationNumber != 1)
        {
            rotationNumber -= 1;
        }
        rotateRectangle(rotationNumber);
        return rotationNumber;
    }

    public void scaleLength(int factor)
    {
        lengthNumber = factor;
        thisTransform.localScale = new Vector3((lengthNumber * scaleSnap), thisTransform.localScale.y, thisTransform.localScale.z);
    }

    public int scaleLengthUp()
    {
        if (lengthNumber < upperLengthLimit)
        {
            lengthNumber += 1;
            scaleLength(lengthNumber);
        }
        return lengthNumber;
    }

    public int scaleLengthDown()
    {
        if (lengthNumber > 1)
        {
            lengthNumber -= 1;
            scaleLength(lengthNumber);
        }
        return lengthNumber;
    }

    public void scaleWidth(int factor)
    {
        lengthNumber = factor;
        thisTransform.localScale = new Vector3(thisTransform.localScale.x, (widthNumber * scaleSnap), thisTransform.localScale.z);
    }

    public int scaleWidthUp()
    {
        if (widthNumber < upperWidthLimit)
        {
            widthNumber += 1;
            scaleWidth(widthNumber);
        }
        return widthNumber;
    }

    public int scaleWidthDown()
    {
        if (widthNumber > 1)
        {
            widthNumber -= 1;
            scaleWidth(widthNumber);
        }
        return widthNumber;
    }

}
