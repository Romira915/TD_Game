﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EDef_attack : MonoBehaviour {

    Chara characs;
    BoxCollider2D Collider;

    // 最大の判定サイズ
    float max_x = 0.6085674f;
    float max_y = 2.144208f;

    float count;
    float Defattackspeed;

    void Start()
    {
        Collider = GetComponent<BoxCollider2D>();
        characs = GameObject.Find("Chara").GetComponent<Chara>();
        count = 0;
        Defattackspeed = 0.1f;
    }

    void Update()
    {
        count += Time.deltaTime;
        if (count >= Defattackspeed)
        {
            Collider.size = new Vector2(max_x, max_y);
            if (count >= Defattackspeed + 0.2f)
            {
                Collider.size = new Vector2(0.0001f, 0.0001f);
                Defattackspeed = Random.Range(1, 6);
                count = 0;
            }
        }
    }
}
