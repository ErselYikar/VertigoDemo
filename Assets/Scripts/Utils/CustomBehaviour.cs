using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomBehaviour : MonoBehaviour
{
    #region Components

    public GameManager GameManager { get; set; }

    private Transform mTransform;

    public Transform Transform
    {
        get
        {
            if(mTransform == null)
            {
                mTransform = base.transform;
            }

            return mTransform;
        }
    }
    #endregion

    #region Methods
    public virtual void Initialize(GameManager gameManager)
    {
        GameManager = gameManager;
    }
    #endregion
}
