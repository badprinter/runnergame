using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class DestroyPlatformUseCase : MonoBehaviour
{
    public List<GameObject> DestroyPlatform(List<GameObject> list)
    {
       GameObject platform = list.First(); 
       Destroy(platform);
       list.Remove(platform);
       return list;
    }
}
