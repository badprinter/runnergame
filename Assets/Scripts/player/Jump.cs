using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private AnimationCurve _yAnimation;
    [SerializeField] private float _heght = 5;

    public void PlayAnimations(Rigidbody jumper, float duration)
    {
       StartCoroutine(AnimationByTime(jumper, duration));
    }

     private IEnumerator AnimationByTime(Rigidbody _jumper, float _duration)
     {
         float expiredSeconds = 0f;
         float progress = 0f;

         float startPositionY = _jumper.position.y;
         while (progress < 1)
         {
             expiredSeconds += Time.deltaTime;
             progress = expiredSeconds / _duration ;

             _jumper.position = new Vector3(transform.position.x, startPositionY + _yAnimation.Evaluate(progress) *_heght, transform.position.z);

             yield return null;
         }
     }


}
