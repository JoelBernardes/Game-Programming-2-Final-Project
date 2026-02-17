using UnityEngine;

[RequireComponent(typeof(Collider))]
public class InteractableMonitor : MonoBehaviour
{
    public InteractableBehavior Interactable { get; private set; }
    public bool Interacting { get; private set; }

    public void SetInteracting(bool interacting)
    {
        if (Interactable == null || Interactable.Instant)
        {
            Interacting = false;
            return;
        }

        Interacting = interacting;
    }

    void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Interactable")) return;
        if (other.TryGetComponent<InteractableBehavior>(out var interactable))
        {
            Interactable = interactable;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Interactable")) return;
        if (other.TryGetComponent<InteractableBehavior>(out var interactable))
        {
            if (!interactable == Interactable) return;
            if (Interacting)
            {
                Interacting = false;
                Interactable.Quit();
            }
            Interactable = null;
        }
    }
}