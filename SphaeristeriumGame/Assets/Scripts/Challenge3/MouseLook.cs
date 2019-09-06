using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
	public Camera cam;

	private Vector3 mousePosition;

	private void Update()
	{
		mousePosition = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));

		transform.LookAt(mousePosition);
	}
}