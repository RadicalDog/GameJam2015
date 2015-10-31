using UnityEngine;
using System.Collections;

public class TriangleScript : MonoBehaviour
{

    public float rotationSnap;
    public float scaleSnap;
    public int upperWidthLimit;
    public int upperHeightLimit;
    public GameObject topSpot;
    public GameObject bottomSpot;
    public Transform thisTransform;
    int rotationNumber = 0;
    int widthNumber = 0;
    int heightNumber = 0;

    void Start()
    {
        //rebuild(8, 2, 3, 5, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    scaleHeightUp();
        //}
        //if (Input.GetMouseButtonDown(1))
        //{
        //    scaleHeightDown();
        //}
    }

    public void rebuild(int width, int height, int rotation, float x, float y)
    {
        scaleWidth(width);
        rotateRectangle(rotation);
        scaleHeight(height);
        thisTransform.position = new Vector2(x, y);
    }

    public int getWidth()
    {
        return widthNumber;
    }

    public int getHeight()
    {
        return heightNumber;
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

    public void scaleWidth(int factor)
    {
        widthNumber = factor;
        thisTransform.localScale = new Vector3((widthNumber * scaleSnap), thisTransform.localScale.y, thisTransform.localScale.z);
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

    public void scaleHeight(int factor)
    {
        heightNumber = factor;
        thisTransform.localScale = new Vector3(thisTransform.localScale.x, (heightNumber * scaleSnap), thisTransform.localScale.z);
    }

    public int scaleHeightUp()
    {
        if (heightNumber < upperHeightLimit)
        {
            heightNumber += 1;
            scaleHeight(heightNumber);
        }
        return heightNumber;
    }

    public int scaleHeightDown()
    {
        if (heightNumber > 1)
        {
            heightNumber -= 1;
            scaleHeight(heightNumber);
        }
        return heightNumber;
    }

}
