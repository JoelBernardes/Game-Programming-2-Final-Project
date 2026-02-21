using UnityEngine;

public class PlayerStallBehavior : InteractableBehavior
{
    public override void Interact()
    {
        UIManager.Ins.ShowPlayerStall(true);
        base.Interact();
    }

    public override void Quit()
    {
        UIManager.Ins.ShowPlayerStall(false);
        base.Quit();
    }
}