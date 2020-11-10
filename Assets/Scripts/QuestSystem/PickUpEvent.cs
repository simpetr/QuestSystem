using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpEvent : MonoBehaviour
{
    public delegate void ItemPickupHandler(Item item);
    public static event ItemPickupHandler OnPickup;

    public static void PickupItem(Item item)
    {
        if(OnPickup != null)
        {
            OnPickup(item);
        }
    }
}
