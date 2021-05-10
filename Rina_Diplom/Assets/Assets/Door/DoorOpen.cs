using System;
using System.Data.Common;
using UnityEngine;
using UnityEngine.Serialization;


[Serializable]
public class DoorStateData
{
    public Material material;
    public Color outlineColor = Color.white;
    public string title;
}

public class DoorOpen : MonoBehaviour
{
    public int itemId;
    
    [SerializeField] private DoorStateData openedStateData;
    [SerializeField] private DoorStateData closedStateData;

    private DTInventory.DTInventory _inventory;

    private MeshRenderer _meshRenderer;

    public Door door;

    public bool IsOpened { get; private set; } = false;

    private Outline _outline;

    public string Title { get; private set; }

    private void Start()
    {
        _outline = GetComponent<Outline>();
        _meshRenderer = GetComponent<MeshRenderer>();

        if (_inventory == null)
            _inventory = FindObjectOfType<DTInventory.DTInventory>();
    }

    // Update is called once per frame
    void Update()
    {

        if (IsOpened || _inventory.HasItem(itemId))
        {
            SetOutlineColor(openedStateData);
        }
        else
        {
            SetOutlineColor(closedStateData);
        }
        
        if (IsOpened)
        {
            _meshRenderer.material = openedStateData.material;
        }
        else
        {
            _meshRenderer.material = closedStateData.material;
        }
    }

    void SetOutlineColor(DoorStateData data)
    {
        Title = data.title;

        if (_outline != null)
        {
            _outline.OutlineColor = data.outlineColor;
        }
    }
    
    public void Open()
    {
        if (IsOpened || _inventory.HasItem(itemId))
        {
            _inventory.RemoveInventoryItem(itemId);
            IsOpened = true;
            door.Open();
        }
    }
}