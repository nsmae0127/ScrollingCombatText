using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	if (Input.GetKeyDown(KeyCode.C))
        {
            CombatTextManager.Instance.CreateText(transform.GetChild(0).transform.position, "-30", Color.red, false);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            CombatTextManager.Instance.CreateText(transform.GetChild(0).transform.position, "-60", Color.red, true);
        }
    }
}
