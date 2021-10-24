/// IApplyDamage.cs
/// Jing Yuan Cheng 101257237
/// Last modified: 22/10/2021
/// This script contains an interface that is implemented in the bullet controller class.
/// It ensures that bullets have a ApplyDamage function.
/// version history
/// Version 1.1 original file

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IApplyDamage
{
    int ApplyDamage();
}
