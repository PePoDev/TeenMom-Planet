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
	private int pageIdx;

	private void Start()
	{
		pageIdx = 0;
		animator = GetComponent<Animator>();
	}

	public void SwitchPageRight()
	{
		if (pageIdx + 1 == statusPageActive.Length)
			return;

		SwitchPage(pageIdx++);
	}

	public void SwitchPageLeft()
	{
		if (pageIdx < 0)
			return;

		SwitchPage(pageIdx--);
	}

	public void SwitchPage(int pageIdx)
	{
		if (this.pageIdx != pageIdx)
		{
			animator.SetInteger("pageIdx", pageIdx);
			this.pageIdx = pageIdx;
			for (int i = 0; i < statusPageActive.Length; i++)
			{
				statusPageActive[i].sprite = pageIdx == i ? spriteEnablePageActive : spritedisablePageActive;
			}
		}
	}
}
