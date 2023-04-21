using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OthelloTest : MonoBehaviour
{

    private int[,] _nums = new int[8, 8];

    [SerializeField]
    private GameObject _test;

    [SerializeField]
    private GameObject _blackCircle;

    [SerializeField]
    private GameObject _whiteCircle;

    private void Start()
    {
        _nums[3, 3] = 2;
        _nums[4, 4] = 2;
        _nums[4, 3] = 1;
        _nums[3, 4] = 1;

        for (int i = 0; i < _nums.GetLength(0); i++)
        {
            for (int j = 0; j < _nums.GetLength(1); j++)
            {
                if (_nums[i, j] == 1)
                {
                    Instantiate(_blackCircle, new Vector2(i, -j), Quaternion.identity);
                }
                else if (_nums[i, j] == 2)
                {
                    Instantiate(_whiteCircle, new Vector2(i, -j), Quaternion.identity);
                }
                Instantiate(_test, new Vector2(i, -j), Quaternion.identity);
            }
        }
    }

    private void Update()
    {

    }
}
