using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SwitchHands : MonoBehaviour
{
    XRGrabInteractable grabInteractable;
    [SerializeField] Transform leftHandAttach;
    [SerializeField] Transform rightHandAttach;
    [SerializeField] XRBaseInteractor leftHandInteractor;
    [SerializeField] XRBaseInteractor rightHandInteractor;

    void Start()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
    }

    public void SwapHands()
    {
        if(grabInteractable.interactorsSelecting.Count > 0)
        {
            var interactor = grabInteractable.GetOldestInteractorSelecting();
            if (interactor == leftHandInteractor)
            {
                grabInteractable.attachTransform = leftHandAttach;
            }
            else if (interactor == rightHandInteractor)
            {
                grabInteractable.attachTransform = rightHandAttach;
            }
        }
    }
}
