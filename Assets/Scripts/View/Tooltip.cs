using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Tooltip : MonoBehaviour
{
    public TMP_Text message;
    public Animator animator;

    public void SetTooltipMessage(string text)
    {
        message.text = text;
        LayoutRebuilder.ForceRebuildLayoutImmediate(GetComponent<RectTransform>());
    }

    public void ShowTooltip()
    {
        animator.SetTrigger("Show");
    }

    public void HideTooltip()
    {
        animator.SetTrigger("Hide");
    }
}
