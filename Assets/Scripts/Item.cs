using PixelCrushers.DialogueSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    /// <summary>
    /// Name of the item. Define items in the Dialogue Database in Unity.
    /// </summary>
    [SerializeField]
    [ItemPopup]
    private string itemName;

    /// <summary>
    /// How many of the items the player currently owns.
    /// This is a custom field that must be added to the Item template in the Dialogue Database in Unity.
    /// </summary>
    public int Count
    {
        get
        {
            return DialogueLua.GetItemField(itemName, nameof(this.Count)).asInt;
        }
        private set
        {
            DialogueLua.SetItemField(itemName, nameof(this.Count), value);
            DialogueManager.SendUpdateTracker();
            Debug.Log($"Collected {itemName}. Count: {Count}");
        }
    }

    /// <summary>
    /// Description of item. Define items in the Dialogue Database in Unity.
    /// </summary>
    public string Description => DialogueLua.GetItemField(itemName, nameof(this.Description)).asString;


    private new Collider collider;
    private new Renderer renderer;
    private Usable usable;

    private void Awake()
    {
        collider = GetComponent<Collider>();
        renderer = GetComponent<Renderer>();
        usable = GetComponent<Usable>();
    }

    /// <summary>
    /// You must call this function from a usable component in the Unity Editor. 
    /// Removes the item from the scene and adds it to the player's inventory by incrementing the Count.
    /// We just remove the collider, usable, and renderer components rather than destroying the whole item
    /// in order to let it finish playing any audio clips, etc. it might be doing.
    /// If there was a "collect" animation on the player, 
    /// you'd want to time this with the animation.
    /// </summary>
    public void CollectItem()
    {
        Count++;
        if (collider != null)
            collider.enabled = false;
        if (renderer != null)
            renderer.enabled = false;
        if (usable != null)
            Destroy(usable);
    }
}
