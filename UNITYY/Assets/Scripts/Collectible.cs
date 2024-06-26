using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public CollectableType type;
    public Sprite icon;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.GetComponent<Player>();

        if (player != null )
        {
            player.inventory.Add(this);
            Destroy(this.gameObject);
        }
    }

}

public enum CollectableType
{
    NONE, POTATO_SEED
}
