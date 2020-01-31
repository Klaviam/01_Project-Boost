﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyMapping : Singleton<KeyMapping>
{
    // Key mappings
    public KeyCode turnLeft = KeyCode.A;
    public KeyCode turnRight = KeyCode.D;
    public KeyCode boost = KeyCode.Space;
}
