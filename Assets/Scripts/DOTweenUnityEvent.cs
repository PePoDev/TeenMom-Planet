using DG.Tweening;
using UnityEngine;

public class DOTweenUnityEvent : MonoBehaviour
{
    
	public void TranslateX(float PosX)
	{
		transform.DOMoveX(PosX, 1f);
	}

	public void TranslateY(float PosY)
	{
		transform.DOMoveY(PosY, 1f);
	}
}
