using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class MenuPopup : MonoBehaviour
{
    public Button muteButton, closeButton;
    public TMP_Text buttonText;

    public static event Action<bool> OnMuteButtonPressed;

    private bool isMuted;

    private void OnEnable()
    {
        SetButtons();
    }

    private void SetButtons()
    {
        muteButton.onClick.RemoveAllListeners();
        muteButton.onClick.AddListener(MuteButtonDelegate);

        closeButton.onClick.RemoveAllListeners();
        closeButton.onClick.AddListener(CloseButtonDelegate);
    }

    private void CloseButtonDelegate()
    {
        gameObject.SetActive(false);
    }

    private void MuteButtonDelegate()
    {
        isMuted = !isMuted;
        SetButtonText();
        OnMuteButtonPressed?.Invoke(isMuted);
    }

    private void SetButtonText()
    {
        buttonText.text = isMuted ? "Unmute" : "Mute";
    }
}
