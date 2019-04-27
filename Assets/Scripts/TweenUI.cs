using DG.Tweening;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TweenUI : MonoBehaviour
{
	public float TweenDistance;
	public float TweenTime;

	private RectTransform thisObject;

	private void Start()
	{
		GetComponent<RectTransform>().DOAnchorPosX(TweenDistance, TweenTime);
		StartCoroutine(DelayLoadNextScene());
	}

	private IEnumerator DelayLoadNextScene()
	{
		yield return new WaitForSeconds(TweenTime + 0.25f);
		Initiate.Fade(SceneManager.GetActiveScene().buildIndex + 1, Color.black, 1f);
	}
}
