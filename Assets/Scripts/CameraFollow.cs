using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	[SerializeField] private Transform followObject;
	[SerializeField] private Vector3 offset;

	private Transform cameraTransform;

	private void Start()
	{
		cameraTransform = Camera.main.transform;
	}

	private void Update()
	{

	}
}
