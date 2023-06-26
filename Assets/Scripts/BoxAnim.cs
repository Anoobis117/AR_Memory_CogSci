using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxAnim : MonoBehaviour
{
    public GameObject box_move;
    public GameObject box_rotate;
    public GameObject box_scale;

    public void BoxMoveAnim () {
        box_move.GetComponent<Animation>().Play();
    }

    public void BoxRotateAnim() {
        box_rotate.GetComponent<Animation>().Play();
    }

    public void BoxScaleAnim () {
        box_scale.GetComponent<Animation>().Play();
    }

}
