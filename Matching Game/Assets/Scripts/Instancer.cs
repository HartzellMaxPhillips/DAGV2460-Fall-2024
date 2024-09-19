using UnityEngine;

[CreateAssetMenu]
public class Instancer : ScriptableObject
{
    public GameObject prefab;
    private int num;
    public void CreateInstance()
    {
        Instantiate(prefab);
    }
    
    public void CreateInstance(Vector3Data obj)
    {
        Instantiate(prefab, obj.value, Quaternion.identity);
    }

    public void CreateInstanceFromList(Vector3DataList obj)
    {
        foreach (var t in obj.vector3Dlist)
        {
            Instantiate(prefab, t.value, Quaternion.identity);
        }
    }
    
    public void CreateInstanceFromListCounting(Vector3DataList obj)
    {
        Instantiate(prefab, obj.vector3Dlist[num].value, Quaternion.identity);
        num++;
        if (num == obj.vector3Dlist.Count)
        {
            num = 0;
        }
    }
    
    public void CreateInstanceListRandomly(Vector3DataList obj)
    {
        num = Random.Range(0, obj.vector3Dlist.Count);
        Instantiate(prefab, obj.vector3Dlist[num].value, Quaternion.identity);
    }
}
