using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	private Vector3 moveForce;
	public GUIText countText;

	private int count;

	void Start()
	{
		count = 0;
		TextRefresh();
	}


	
	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		moveForce = new Vector3 (moveHorizontal * speed , 0 , moveVertical * speed);
		rigidbody.AddForce (moveForce);


	}

	void OnTriggerEnter(Collider other) {
		Debug.Log ("trigered");
		if(other.gameObject.tag == "Pickup"){
			Debug.Log ("not ground tag");
			other.gameObject.SetActive(false);
			count=count + 1 ;
			TextRefresh();
		}
	}

	void TextRefresh()
	{
		countText.text = "Score: " + count.ToString ();
	}
}