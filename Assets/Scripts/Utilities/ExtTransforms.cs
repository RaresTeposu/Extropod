using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Transforms
{
    // Start is called before the first frame update
    public static void DestroyChildren(this Transform t, bool destroyImmediately = false)
    {
        foreach (Transform child in t)
        {
            if (destroyImmediately)
            {
                MonoBehaviour.DestroyImmediate(child.gameObject);
            }
            else
            {
                MonoBehaviour.Destroy(child.gameObject);
            }

        }
    }

    // Update is called once per frame
}
