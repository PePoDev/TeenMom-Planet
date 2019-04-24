using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ColliderUnityEvent : MonoBehaviour
{
	public UnityEvent EventOnTriggerEnter2D;
	
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (EventOnTriggerEnter2D != null)
		{
			EventOnTriggerEnter2D.Invoke();
		}
	}
}
