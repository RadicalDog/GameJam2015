using UnityEngine;
using System.Collections;

public class UIButtons : MonoBehaviour {

    public int objectId;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnClick()
    {
        Debug.Log(gameObject.name);
    }

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
}
