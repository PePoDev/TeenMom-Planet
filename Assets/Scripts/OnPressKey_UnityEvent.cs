using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnPressKey_UnityEvent : MonoBehaviour
{
	public KeyCode targetKey;

	public UnityEvent OnPressKey;

	private void Update()
	{
		if (Input.GetKeyDown(targetKey))
		{
			OnPressKey.Invoke();
		}
	}
}
