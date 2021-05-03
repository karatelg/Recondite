using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public Animation anim;

    public string title;

    public int itemId;

    public Material opened;
    public Material closed;

    [SerializeField]
    private Color outlineColorOpened = Color.white;
    
    [SerializeField]
    private Color outlineColorClosed = Color.white;
    
    private DTInventory.DTInventory _inventory;

    private MeshRenderer _meshRenderer;

    private Outline _outline;
    
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
            _meshRenderer.material = opened;
            SetOutlineColor(outlineColorOpened);
        }
        else
        {
            _meshRenderer.material = closed;
            SetOutlineColor(outlineColorClosed);
        }
    }

    void SetOutlineColor(Color value)
    {
        if (_outline != null)
        {
            _outline.OutlineColor = value;
        }
    }
    
    public void Open()
    {
        anim.Play();
    }
}