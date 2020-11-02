using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Arcade
{
    public class PlayerInteraction : MonoBehaviour
    {
        public static Action<Vector3> OnFiringDetected;
        public ManoGestureTrigger firingHandGesture = ManoGestureTrigger.CLICK;



        // Update is called once per frame
        void Update()
        {
            HandInfo handInformation = ManomotionManager.Instance.Hand_infos[0].hand_info;
            DetectFiringTriggerGesture(handInformation);
        }

        public void DetectFiringTriggerGesture(HandInfo handInformation)
        {
            //This might require some smoothing;


            if (handInformation.gesture_info.mano_gesture_trigger == firingHandGesture)
            {
                if (OnFiringDetected != null)
                {//I am going to use POI directly, the edge of thumb and index.
                    float depthEstimation = handInformation.tracking_info.depth_estimation;
                    Vector3 firingPosition = ManoUtils.Instance.CalculateNewPosition(handInformation.tracking_info.poi, depthEstimation);

                    OnFiringDetected(firingPosition);
                }

            }
        }
    }
}

