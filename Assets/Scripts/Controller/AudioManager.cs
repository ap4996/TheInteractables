using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip tooltipSound, interactionSound;

    private void Start()
    {
        InteractableObject.OnHoverBegin += PlayTooltipSound;
        InteractableObject.OnHoverEnd += PlayTooltipSound;
        InteractableObject.OnInteracted += PlayInteractionSound;
        MenuPopup.OnMuteButtonPressed += OnMuted;
    }

    private void OnDestroy()
    {
        InteractableObject.OnHoverBegin -= PlayTooltipSound;
        InteractableObject.OnHoverEnd -= PlayTooltipSound;
        InteractableObject.OnInteracted -= PlayInteractionSound;
        MenuPopup.OnMuteButtonPressed -= OnMuted;
    }

    private void OnMuted(bool mute)
    {
        audioSource.mute = mute;
    }

    private void PlayTooltipSound()
    {
        PlaySound(tooltipSound);
    }

    private void PlayInteractionSound()
    {
        PlaySound(interactionSound);
    }

    private void PlaySound(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }
}
