using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateMap : MonoBehaviour {

	// Use this for initialization
	void Start () {
        for(int i=1;i<=8;i++)
            for(int j=1;j<=8;j++)  
                Instantiate(Resources.Load("floor", typeof(GameObject)), new Vector3(i+i/50.0F,0, j+j/50.0F), Quaternion.identity);


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
