using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.Serialization;

public class platformManager : MonoBehaviour
{
    [FormerlySerializedAs("_platformPrefab")] [SerializeField] private GameObject platformPrefab;
    private List<GameObject> _platformsList = new List<GameObject>();

    private CreatePlatform _createPlatform;
    private DestroyPlatformUseCase _destroyPlatform;
    
    private void Start()
    {
        _createPlatform = gameObject.AddComponent<CreatePlatform>();
        _destroyPlatform = gameObject.AddComponent<DestroyPlatformUseCase>();
        
        for(int i = 0; i < 11; i++)
        {
            _platformsList = _createPlatform.CreatePlatformAndReturn(_platformsList, platformPrefab);
        }
    }

    
}
