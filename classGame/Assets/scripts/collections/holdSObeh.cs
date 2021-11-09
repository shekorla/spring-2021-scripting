using UnityEditor;
using UnityEngine;

public class holdSObeh : MonoBehaviour
{
    private GameObject art;
    private Mesh artMesh;
    private Material artColor;
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
        artMesh = GetComponentInChildren<MeshFilter>().mesh;
        if (artMesh != null)
        {
            artMesh = newShinyObj.skin;
            artColor = newShinyObj.skinColor;
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