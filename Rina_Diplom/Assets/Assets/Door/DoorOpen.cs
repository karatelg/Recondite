using System;
using UnityEngine;


[Serializable]
public class DoorStateData
{
    public Material material;
    public Color outlineColor = Color.white;
    public string title;
}

public class DoorOpen : MonoBehaviour
{
    public Animation anim;

    public int itemId;

    [SerializeField] private DoorStateData openedStateData;
    [SerializeField] private DoorStateData closedStateData;

    private DTInventory.DTInventory _inventory;

    private MeshRenderer _meshRenderer;

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
        if (_inventory.HasItem(itemId))
        {
            SetOutlineColor(openedStateData);
        }
        else
        {
            SetOutlineColor(closedStateData);
        }
    }

    void SetOutlineColor(DoorStateData data)
    {
        _meshRenderer.material = data.material;

        Title = data.title;
        
        if (_outline != null)
        {
            _outline.OutlineColor = data.outlineColor;
        }
    }

    public void Open()
    {
        anim.Play();
    }
}