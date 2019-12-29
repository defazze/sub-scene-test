
using System;
using Unity.Entities;
using Unity.Scenes;
using UnityEngine;
using static Unity.Scenes.SceneSystem;
using Hash128 = Unity.Entities.Hash128;

public class InputSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            var sceneSystem = World.GetExistingSystem<SceneSystem>();
            var currentScene = GetSingleton<CurrentScene>();

            sceneSystem.UnloadScene(GetSceneGuid(currentScene.index));
            var nextIndex = currentScene.index + 1;
            if (nextIndex > 3) nextIndex = 1;

            sceneSystem.LoadSceneAsync(GetSceneGuid(nextIndex));
            SetSingleton(new CurrentScene { index = nextIndex });
        }
    }

    private Hash128 GetSceneGuid(int index)
    {
        switch (index)
        {

            case 1: return GameManager.Instance.subScene1.SceneGUID;
            case 2: return GameManager.Instance.subScene2.SceneGUID;
            case 3: return new Hash128("f7db457e07fa43b4692111519b46edb3");
            default: throw new NotImplementedException();
        }
    }
}
