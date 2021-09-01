using UnityEngine;

[CreateAssetMenu]
public class floatData : ScriptableObject
{
    public float num;

    public void AddNum(float val)
    {
        num += val;
    }

    public void ResetVal(float val)
    {
        num = val;
    }
    public void AddToZero (float val)
    {
        if (num<=0)
        {
            num = 0;
        }
        else
        {
            num += val;
        }
        
    }
}
