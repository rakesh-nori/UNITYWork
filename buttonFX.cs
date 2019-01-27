using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttonFX : MonoBehaviour {

    public AudioSource myFx;
    public AudioClip hoverFx;
    public AudioClip clickFx;
    public Button curr;

	public void HoverSound()
    {
        if (curr.interactable)
        {
            myFx.PlayOneShot(hoverFx);
        }
    }

    public void ClickSound()
    {
        if (curr.interactable)
        {
            myFx.PlayOneShot(clickFx);
        }
    }
}
