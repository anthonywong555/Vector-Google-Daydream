using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventListener : MonoBehaviour {

	private Renderer _renderer;

	void Start () {
		_renderer = gameObject.GetComponent<Renderer> ();
	}

	public void OnEnter() {
		_renderer.material.color = Color.red;
	}

	public void OnExit() {
		_renderer.material.color = Color.white;
	}

	public void OnGrab() {
		Transform pointerTransform = GvrPointerInputModule.Pointer.PointerTransform;
		transform.SetParent (pointerTransform, true);
	}

	public void OnRelease() {
		transform.SetParent (null, true);
	}
}
