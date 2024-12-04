using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public InteractableObjectsHandler interactableObjectsHandler;
    public ProgressController progressController;

    private void Start()
    {
        interactableObjectsHandler.SetObjects();
        progressController.SetMaxProgress(3);
    }
}
