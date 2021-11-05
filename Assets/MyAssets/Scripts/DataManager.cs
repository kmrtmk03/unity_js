using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyAssets
{

    public class DataManager : MonoBehaviour
    {

        public static DataManager instance = null;

        private void Awake()
        {
            //ƒVƒ“ƒOƒ‹ƒgƒ“‚ğì¬
            if(instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(this);
            }
        }

    }


}
