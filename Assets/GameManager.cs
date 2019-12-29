using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Scenes;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public SubScene subScene1;
    public SubScene subScene2;

    public static GameManager Instance { get; private set; }
    public GameManager()
    {
        Instance = this;
    }

    void Start()
    {
        var em = World.DefaultGameObjectInjectionWorld.EntityManager;
        var e = em.CreateEntity();
        em.AddComponentData(e, new CurrentScene { index = 1 });
    }
}
