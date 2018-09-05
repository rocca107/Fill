using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;
using ArrowCellCore;
using UnityEngine.UI;

public class FlowerController : UIBehaviour 
{
    private Tweener tween;

    void Start()
    {
        var rect = gameObject.GetComponent<RectTransform>();
        tween.Kill();

        tween =
        rect.DORotate(new Vector3(0f, 0f, 180f), 0.5f).OnComplete(
            () =>
            {
                rect.DORotate(new Vector3(0f, 0f, 0), 0.7f);
            }).SetLoops(-1);

        gameObject.GetRemoteComponent<Image>("aaa", img=>{
            Debug.Log("ないです");
        });
    }
}
