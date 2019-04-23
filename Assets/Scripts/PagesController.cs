using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PagesController : MonoBehaviour
{
	public Image[] statusPageActive;
	public Sprite spriteEnablePageActive;
	public Sprite spritedisablePageActive;

	private Animator animator;
	private int currentPageIdx;

	private void Start()
	{
		currentPageIdx = 0;
		animator = GetComponent<Animator>();
	}

	public void SwitchPageRight()
	{
		if (currentPageIdx + 1 == statusPageActive.Length)
			return;

		SwitchPage(currentPageIdx + 2);
	}

	public void SwitchPageLeft()
	{
		if (currentPageIdx < 0)
			return;

		SwitchPage(currentPageIdx - 2);
	}

	public void SwitchPage(int newPageIdx)
	{
		newPageIdx--;
		if (currentPageIdx != newPageIdx)
		{
			animator.SetInteger("pageIdx", newPageIdx + 1);
			statusPageActive[currentPageIdx].sprite = spritedisablePageActive;
			currentPageIdx = newPageIdx;
			statusPageActive[newPageIdx].sprite = spriteEnablePageActive;
		}
	}
}
