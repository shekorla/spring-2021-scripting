using UnityEngine;

public class collectableSO : ScriptableObject
{
    public bool collected;
    public int costVal, sellVal;
    public GameObject IIIDself;
    public MeshRenderer skinProj;
    public Mesh skin; //this is what happens when I name variables at 2am
    public Material skinColor;

}
