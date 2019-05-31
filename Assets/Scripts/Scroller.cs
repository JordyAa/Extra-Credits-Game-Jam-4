using System;
using UnityEngine;
using Unity.Entities;

public class Scroller : MonoBehaviour
{
    public float speed = 1f;

    private void Update()
    {
        transform.Translate(0f, -speed * Time.deltaTime, 0f);
    }
}

internal class ScrollerSystem : ComponentSystem
{
    protected override void OnUpdate()
    {
        // todo: implement ecs.
    }
}
