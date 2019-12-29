using System.Collections;
using System.Collections.Generic;
using Unity.Scenes;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    public SubScene subScene1;
    // Start is called before the first frame update
    void Start()
    {
        var hash = subScene1.SceneGUID;
        Debug.Log(hash);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
