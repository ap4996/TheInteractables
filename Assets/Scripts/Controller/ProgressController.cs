using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressController : MonoBehaviour
{
    public static event Action<int, int> UpdateProgressUI;

    private int currentProgress;
    private int maxProgress = 3;

    private void Start()
    {
        InteractableObject.OnInteracted += UpdateProgress;
    }

    private void OnDestroy()
    {
        InteractableObject.OnInteracted -= UpdateProgress;
    }

    private void UpdateProgress()
    {
        ++currentProgress;
        if(currentProgress >= maxProgress)
        {
            currentProgress = maxProgress;
        }
        UpdateProgressUI?.Invoke(currentProgress, maxProgress);
    }

    public void SetMaxProgress(int progress)
    {
        maxProgress = progress;
        UpdateProgressUI?.Invoke(currentProgress, maxProgress);
    }
}
