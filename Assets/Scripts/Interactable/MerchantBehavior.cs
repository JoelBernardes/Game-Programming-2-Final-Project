using System.Collections.Generic;
using UnityEngine;

public class MerchantBehavior : InteractableBehavior
{
    [SerializeField] public ItemListing[] itemsForSale;

    public override void Interact()
    {
        // this is so messy must fix
        UIManager.Ins.ShowMerchantInventory(true, itemsForSale);
        base.Interact();
    }

    public override void Quit()
    {
        UIManager.Ins.ShowMerchantInventory(false);
        base.Quit();
    }
}