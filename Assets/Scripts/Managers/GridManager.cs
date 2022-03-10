using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : CustomBehaviour
{
    public GameObject Hexagon;
    public float MinXValue = -3.5f;
    private float mMaxXValue;
    public float MinYValue = -4f;
    private float mMaxYValue;
    public int BoardSizeX = 8;
    public int BoardSizeY = 9;
    private float mCurrentYValue;
    private float mCurrentXValue;

    public override void Initialize(GameManager gameManager)
    {
        base.Initialize(gameManager);

        InitializeWithCustomOptions();
        CreateBoard();
        //Debug.Log("init");
    }

    private void InitializeWithCustomOptions()
    {
        mMaxXValue = BoardSizeX + MinXValue -1;
        mMaxYValue = BoardSizeY + MinYValue -1;
        mCurrentXValue = MinXValue;
        mCurrentYValue = MinYValue;
    }

    private void CreateBoard()
    {
        for(float i = MinYValue; i <= mMaxYValue; i++)
        {
            var mHexagon = Instantiate(Hexagon);
            mHexagon.transform.position = new Vector2(mCurrentXValue, mCurrentYValue);
            //Debug.Log("init");
            mCurrentYValue++;
        }
    }
}
