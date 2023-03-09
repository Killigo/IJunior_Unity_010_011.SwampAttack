using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDieTransition : Transition
{
    //private void OnEnable()
    //{
    //    Target.Died += OnDied;
    //}

    //private void OnDisable()
    //{
    //    Target.Died -= OnDied;
    //}

    //private void OnDied()
    //{
    //    NeedTransit = true;
    //}

    private void Update()
    {
        if (Target == null)
        {
            NeedTransit = true;
        }
    }
}