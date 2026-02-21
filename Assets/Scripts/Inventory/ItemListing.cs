using UnityEngine;

[System.Serializable]
public class ItemListing
{
    [SerializeField] public ItemSO item;
    [SerializeField] public int amount = 1;
    [SerializeField] public float cost = 0;
}