using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "InteractableObjects", menuName = "InteractableObjects")]
public class InteractiveObjectData : ScriptableObject
{
    public List<Details> interactableObjects;

    [Serializable]
    public class Details
    {
        public int id;
        public string tooltipMessage;
        public Sprite sprite;
    }
}