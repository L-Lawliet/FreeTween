using UnityEngine;
using System.Collections;
using Waiting.Tweening;


public class ValueTweening : MonoBehaviour
{
    public delegate float DelSetter(out float val);

    public float value = 0.0f;


	// Use this for initialization
	void Start () {
        DelSetter setter = Fun;

        setter(out value);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public float Fun(out float val)
    {
        val = 10.0f;

        return val;
    }
}
