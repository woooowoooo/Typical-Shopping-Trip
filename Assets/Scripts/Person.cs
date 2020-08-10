using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
	public string Name;
	private bool Mask;
	private double maskLevel = 0.6;
	
    // Start is called before the first frame update
    void Start()
    {
		if (1 > maskLevel)
		{
			Mask = true;
		}
		else
		{
			Mask = false;
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
