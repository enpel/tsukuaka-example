using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameObjectExtensions
{
    public static bool IsPlayerObject(this GameObject gameObject)
    {
        return gameObject.CompareTag("Player");
    }

}
