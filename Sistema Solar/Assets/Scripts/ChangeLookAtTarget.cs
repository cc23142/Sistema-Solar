using UnityEngine;
using System.Collections;

public class ChangeLookAtTarget : MonoBehaviour {

	public GameObject target; // the target that the camera should look at
	private AudioSource backgroundAudio;

	void Start()
	{
		if (target == null)
		{
			target = this.gameObject;
			Debug.Log("ChangeLookAtTarget target not specified. Defaulting to parent GameObject");
		}
		backgroundAudio = GetComponent<AudioSource>();
		if (backgroundAudio == null)
		{
			Debug.Log($"O componente {gameObject.name} não tem audio source.");
		}
	}

	// Called when MouseDown on this gameObject
	void OnMouseDown () {
		LookAtTarget.target = target;
		if (backgroundAudio != null)
		{
			LookAtTarget.currentAudio = backgroundAudio;
		}
		Camera.main.fieldOfView = 60*target.transform.localScale.x;
	}
}
