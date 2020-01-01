using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KafkaDisplay : MonoBehaviour {

	public TextMesh floatingText;

	// Use this for initialization
	void Start () {
		// floatingText = GetComponent<TextMesh>();
		// floatingText = gameObject.GetComponent(typeof(TextMesh)) as TextMesh;
		// floatingText = GetComponent(typeof(TextMesh)) as TextMesh;


		if(floatingText != null)
		{
			floatingText.text = "Heyyy";
			Debug.Log("Successfully got floatingText");
		}
		else
		{
			Debug.Log("Unable to get floatingText");
		}
 		
	}
	
	// Update is called once per frame
	void Update ()
	{
		string time = Time.time.ToString();
		if(floatingText != null && time != null)
		{
			floatingText.text = time;
			Debug.Log("Update time: " + time);
		}
		
	}
}
