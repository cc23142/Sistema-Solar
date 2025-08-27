using UnityEngine;
using System.Collections;

public class LookAtTarget : MonoBehaviour {

	static public GameObject target; // the target that the camera should look at
	static public AudioSource currentAudio;
	private AudioSource pastAudio = null;

	void Start () {
		if (target == null) 
		{
			target = this.gameObject;
			Debug.Log ("LookAtTarget target not specified. Defaulting to parent GameObject");
		}
	}

	// Update is called once per frame
	void Update()
	{
		if (target)
			transform.LookAt(target.transform);
		if (currentAudio != pastAudio)
		{
			if (pastAudio != null)
			{
				pastAudio.mute = true;
			}
			Debug.Log($"tocando {currentAudio.name}");
			pastAudio = currentAudio;
			currentAudio.mute = false;
		}
	}
}
