using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour  {
    [Range(0.0f, 1.0f)]
    public float topLimit;
    [Range(0.0f, 1.0f)]
    public float bottomLimit;
    public GameObject genericNPC;

    Vector2 topLimitVector;
    Vector2 bottomLimitVector;

    // Use this for initialization
    void Start () {
        topLimitVector = Camera.main.ViewportToWorldPoint(new Vector3(0.0f, topLimit, 0f));
        bottomLimitVector = Camera.main.ViewportToWorldPoint(new Vector3(0.0f, bottomLimit, 0f));
        for (int i = 0; i < 20; i++)
        {
            
        }
        
    }
	
	// Update is called once per frame
	void Update () {

	}


}
