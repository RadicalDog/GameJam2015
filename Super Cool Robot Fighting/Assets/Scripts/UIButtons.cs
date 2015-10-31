using UnityEngine;
using System.Collections;

public class UIButtons : MonoBehaviour {

    #region [New Object Properties]
    public enum objectType
    {
        triangle,
        square,
        circle
    }

    public enum rotationDirection
    {
        clockwise,
        counterClockwise
    }

    public static rotationDirection rotation;
    public static objectType shape;
    #endregion

    public static int objectId;
    public GameObject player;
    public GameObject reference;

    public void OnClick()
    {
        Debug.Log(gameObject.name);
        Debug.Log(objectId);
    }

    #region [UIButton Methods]
    public void ResetButton()
    {
        OnClick();
    }

    public void ExpandHeight()
    {
        OnClick();
    }

    public void ExpandWidth()
    {
        OnClick();
        Debug.Log("Uhh "+ player.GetComponent<RobotController>().DataSolids[0].width);
        player.GetComponent<RobotController>().DataSolids[0].width += 1;
    }

    public void ReduceHeight()
    {
        OnClick();
    }

    public void ReduceWidth()
    {
        OnClick();
    }

    public void RotateCW()
    {
        OnClick();
    }

    public void RotateCCW()
    {
        OnClick();
    }

    public void AddComponent()
    {
        OnClick();
    }

    public void RemoveComponent()
    {
        OnClick();
    }
    #endregion

    #region [Difficulty Methods]
    public void EasyEnemy()
    {
        OnClick();
    }

    public void MediumEnemy()
    {
        OnClick();
    }

    public void HardEnemy()
    {
        OnClick();
    }
    #endregion

    #region [New Object Methods]
    public void ShapeMethods()
    {
        //GameObject[] shapeButtons = GameObject.FindGameObjectsWithTag("ShapeButton");

        //foreach (GameObject shapeButton in shapeButtons)
        //{
        //    if (gameObject.GetInstanceID() == shapeButton.GetInstanceID())
        //    {
              
        //    }
        //    else
        //    {

        //    }
        //}
    }

    public void Triangle()
    {
        shape = objectType.triangle;
        ShapeMethods();
    }

    public void Square()
    {
        shape = objectType.square;
        ShapeMethods();
        player.GetComponent<RobotController>().addShape(1, reference.GetComponent<Reference>().ID);
    }

    public void Circle()
    {
        shape = objectType.circle;
        ShapeMethods();
    }
    #endregion
}
