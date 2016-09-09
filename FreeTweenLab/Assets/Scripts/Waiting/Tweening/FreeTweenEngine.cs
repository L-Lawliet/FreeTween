using System.Collections;
using UnityEngine;

/// <summary>
///
/// name:FreeTweenEngine
/// author:Administrator
/// date:2016/8/8 18:13:50
/// versions:
/// introduce:
/// note:
/// 
/// </summary>
namespace Waiting.Tweening
{
    public class FreeTweenEngine : MonoBehaviour
    {
        private static FreeTweenEngine instance;

        private static bool hasInstance = false;

        public static FreeTweenEngine GetInstance()
        {
            if (!hasInstance)
            {
                GameObject go = new GameObject("FreeTweenEngine");

                instance = go.AddComponent<FreeTweenEngine>();
                hasInstance = true;
            }

            return instance;
        }



        void Start()
        {

        }

        void Update()
        {

        }
    }
}
