using System.Collections.Generic;
using UnityEngine;

public class MerchantBehavior : InteractableBehavior
{
    [SerializeField] public ItemListing[] itemsForSale;

    public override void Interact()
    {
        UIManager.Ins.ShowMerchantInventory(true, itemsForSale);
        // this is so messy must fix
        base.Interact();
    }

    public override void Quit()
    {
        UIManager.Ins.ShowMerchantInventory(false);
        base.Quit();
    }
}