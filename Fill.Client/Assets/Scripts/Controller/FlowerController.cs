using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class FlowerController : MonoBehaviour 
{

    private bool isAnimation = false;
    void Start()
    {
        isAnimation = false;
    }

    void Update()
    {
        if (!isAnimation)
            SetAnimation();
    }

    void SetAnimation()
    {
        var rect = gameObject.GetComponent<RectTransform>();
        rect.DORotate(new Vector3(0f, 0f, 180f), 0.5f).OnComplete(
            () => {
                rect.DORotate(new Vector3(0f, 0f, 0), 0.7f);
            }).SetLoops(-1);

        isAnimation = true;
    }
}
