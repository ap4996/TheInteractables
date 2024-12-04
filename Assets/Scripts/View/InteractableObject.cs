using System;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public SpriteRenderer objectImage;
    public Tooltip tooltip;
    public ParticleSystem particles;
    public Animator animator;

    public static event Action OnHoverBegin, OnHoverEnd, OnInteracted;

    private bool IsHovering;
    private bool hasInteracted;

    /// <summary>
    /// Renders the interactable object
    /// </summary>
    /// <param name="objectDetails"></param>
    public void RenderObject(InteractiveObjectData.Details objectDetails)
    {
        IntializeValues();
        SetObjectImage(objectDetails.sprite);
        SetTooltip(objectDetails.tooltipMessage);
    }

    private void IntializeValues()
    {
        IsHovering = false;
        hasInteracted = false;
    }

    private void SetObjectImage(Sprite sprite)
    {
        objectImage.sprite = sprite;
    }

    private void SetTooltip(string text)
    {
        tooltip.SetTooltipMessage(text);
    }

    private void SetObjectAsInteractedWith()
    {
        hasInteracted = true;
        IsHovering = false;
        tooltip.HideTooltip();
        animator.SetTrigger("Interact");
        particles.Play();
        OnInteracted?.Invoke();
        objectImage.color = Color.blue;
    }

    private void OnMouseDown()
    {
        if (!hasInteracted)
        {
            SetObjectAsInteractedWith();
        }
    }

    private void OnMouseOver()
    {
        if (!IsHovering && !hasInteracted)
        {
            tooltip.ShowTooltip();
            IsHovering = true;
            OnHoverBegin?.Invoke();
        }
    }

    private void OnMouseExit()
    {
        IsHovering = false;
        tooltip.HideTooltip();
        if (!hasInteracted)
        {
            OnHoverEnd?.Invoke();
        }
    }
}
