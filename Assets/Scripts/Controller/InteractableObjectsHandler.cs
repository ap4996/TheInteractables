using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObjectsHandler : MonoBehaviour
{
    public List<InteractableObject> interactableObjects;
    public InteractiveObjectData interactableObjectData;

    public void SetObjects()
    {
        var interactableObjectsDetail = interactableObjectData.interactableObjects;
        SetInteractableObjectDetails(interactableObjectsDetail);
    }

    private void SetInteractableObjectDetails(List<InteractiveObjectData.Details> interactableObjectsData)
    {
        for(int i = 0; i < interactableObjectsData.Count; ++i)
        {
            if(i < interactableObjects.Count) //to avoid ArgumentOutOfBoundsException
            {
                interactableObjects[i].gameObject.SetActive(true);
                interactableObjects[i].RenderObject(interactableObjectsData[i]);
            }
        }
    }
}
