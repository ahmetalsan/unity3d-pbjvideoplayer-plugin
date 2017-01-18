using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VideoGameObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended) {
			Debug.Log("UNITY LOG: Tapped()");
			// call unity function that triggers call to native iOS code
			IosVideoPlayerWrapper.PlayVideo("http://devimages.apple.com/iphone/samples/bipbop/bipbopall.m3u8");
		}
	}
}
