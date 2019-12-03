using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SwipeableView;

public class SwipeableViewScener : SwipeableView.UISwipeableView<Card>
{
    public void UpdateData(List<Card> data)
    {
        base.Initialize(data);
    }
}
