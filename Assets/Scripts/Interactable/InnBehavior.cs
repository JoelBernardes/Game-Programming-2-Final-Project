using UnityEngine;

public class InnBehavior : InteractableBehavior
{
    [SerializeField] private Transform _teleportPoint;
    [SerializeField] private bool _defaultLastVisited;

    public override InteractableType Type => InteractableType.INN;
    public override bool Instant => true;
    public static Transform LastVisitedTeleportPoint;

    void Awake()
    {
        if (_defaultLastVisited) LastVisitedTeleportPoint = _teleportPoint;
    }

    public override void Interact()
    {
        base.Interact();
        LastVisitedTeleportPoint = _teleportPoint;
        DayManager.Ins.NextDay();
    }
}