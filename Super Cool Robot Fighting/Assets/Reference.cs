using UnityEngine;
using System.Collections;

public class Reference : MonoBehaviour {

    public int ID;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnMouseDown()
    {
        UIButtons.objectId = ID;
    }
}
