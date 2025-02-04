using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ControlWithAnim : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float duration;
    private Vector3 to => player.eulerAngles + to2;
    private Vector3 to1;
    private Vector3 to2 = new(0, 90, 0);

    private Tween tween;

    private void Update()
    {
        if (tween != null && !tween.IsPlaying())
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                tween = player.DORotate(to, duration, RotateMode.Fast);
            }
        }

        if (tween != null && !tween.IsPlaying())
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                tween = player.DORotate(to2, duration, RotateMode.Fast);
            }
        }
    }
    
}