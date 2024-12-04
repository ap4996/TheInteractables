using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ProgressUI : MonoBehaviour
{
    public TMP_Text progressText;

    private void Start()
    {
        ProgressController.UpdateProgressUI += SetProgress;
    }

    private void OnDestroy()
    {
        ProgressController.UpdateProgressUI -= SetProgress;
    }

    private void SetProgress(int currentProgress, int maxProgress)
    {
        progressText.text = $"Progress: {currentProgress}/{maxProgress}";
    }
}
