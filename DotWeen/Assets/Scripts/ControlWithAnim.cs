using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ControlWithAnim : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float duration1;
    [SerializeField] float duration2;
    [SerializeField] float duration3;
    [SerializeField] float HowManyTo;
    private Vector3 to => player.eulerAngles + to2;
    private Vector3 to1 => player.eulerAngles - to2;
    private Vector3 to2 = new(0, 5, 0);

    private Vector3 up1 = new(0, 1.5f, 0);
    private Vector3 up2 = new(0, 0.3f, 0);

    private Tween tween1;
    private Tween tween2;
    private Tween tween3;
    private Tween tween4;

    private void Update()
    {
        if (Input.GetKey(KeyCode.A))
        { 
            if (tween1 == null || !tween1.IsPlaying())
            {
                tween1 = player.DORotate(to, duration1, RotateMode.Fast);
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            if (tween2 == null || !tween2.IsPlaying())
            {
                tween2 = player.DORotate(to1, duration1, RotateMode.Fast);
            }
        }              
        
        if (Input.GetKey(KeyCode.Space))
        {
            if (tween3 == null || !tween3.IsPlaying())
            {
                tween3 = player.DOMove(up1, duration2);
            }
        }

        if (player.position.y == 1.5f)
        {
            tween4 = player.DOMove(up2, duration3);
        }

    }
    
}