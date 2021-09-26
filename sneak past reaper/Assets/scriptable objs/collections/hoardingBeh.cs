using UnityEngine;

public class hoardingBehaviour : MonoBehaviour
{
    private GameObject art;
    private MeshRenderer artMeshRenderer;
    public collectableSO newShinyObj;
    public collectionSO inventory;

    private void Awake()
    {
        ConfigItem();
    }

    public void SwapItem(collectableSO item)
    {
        newShinyObj = item;
        ConfigItem();
    }
    
    private void ConfigItem()
    {
        art = GetComponentInChildren<Transform>().gameObject;
        artMeshRenderer = GetComponentInChildren<MeshRenderer>();
        if (artMeshRenderer != null)
        {
            artMeshRenderer = newShinyObj.skinProj;
            artMeshRenderer.material = newShinyObj.skinColor;
        }
        EnableDisableCollectable(!newShinyObj.collected);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        inventory.pickedUp(newShinyObj);
        EnableDisableCollectable(false);
    }

    private void EnableDisableCollectable(bool value)
    {
        art.SetActive(value);
        GetComponent<Collider>().enabled = value;
    }
}