﻿using Code.Extensions;
using Code.Gameplay.Logic;
using UnityEngine;

namespace Code.Gameplay.View
{
    public class MoveView : MonoBehaviour
    {
        [SerializeField] private MoverX _moverX;

        private void Update()
        {
            float sign = Mathf.Sign(_moverX.Speed);

            if (sign == 0)
            {
                return;
            }
            float x = sign * Mathf.Abs(transform.localScale.x);
            transform.localScale = transform.localScale.SetX(x);
        }
    }
}