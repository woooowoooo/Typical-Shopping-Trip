using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
	public string fullName = "Zoosmell Pooplord";
	public int speed = 5;
	public bool mask = false;
	
    // Start is called before the first frame update
    void Start()
    {
		if (1 > maskLevel)
		{
			mask = true;
		}
		else
		{
			mask = false;
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
