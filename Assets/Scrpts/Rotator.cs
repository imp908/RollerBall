using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

	public float rotationSpeed;
	
	void Update()
	{
		transform.Rotate(0.0F, rotationSpeed , 0.0F, Space.World);
	}
}