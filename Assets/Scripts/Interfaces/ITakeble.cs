using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public interface ITakeble 
{
    public abstract void PickUp(Transform holdPos);

    public abstract void Drop(Transform dropPosition);
}
