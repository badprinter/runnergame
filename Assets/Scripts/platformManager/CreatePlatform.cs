using System.Collections.Generic;
using UnityEngine;

public class CreatePlatform : MonoBehaviour
{
    private float _offsetPosition = 16f;
    public List<GameObject> CreatePlatformAndReturn(List<GameObject> list, GameObject platformPrefab)
    {
        GameObject platform = Instantiate(platformPrefab);
        platform.transform.position = new Vector3(0,0, list.Count * _offsetPosition);
        list.Add(platform); 
        return list;
    }
}
