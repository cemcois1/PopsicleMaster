using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
[SelectionBase]
public class Barrier : MonoBehaviour,IDamageGiveable
{
    public void HitBarrier()
    {
        CharacterManager.CharacterStateChanged(CharacterState.Fall);
        
        if (true) CinemachineManager.ShakeScreen?.Invoke();
    }
}
