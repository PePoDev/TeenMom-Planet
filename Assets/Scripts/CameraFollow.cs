using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	[SerializeField] private Transform followObject;
	[SerializeField] private Vector3 offset;
	[SerializeField] private float Min, Max;

	private Transform cameraTransform;

	private void Start()
	{
		cameraTransform = Camera.main.transform;
	}

	private void Update()
	{
		var newPos = followObject.position + offset;
		newPos.y = cameraTransform.position.y;

		if (newPos.x < Min)
		{
			newPos.x = Min;
		}

		if (newPos.x > Max)
		{
			newPos.x = Max;
		}

		cameraTransform.position = newPos + offset;
	}
}
