using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommercialSpace 
{
    public class Infinity 
    {
        public static void Commandment( string value, Vector3 position)
        {
            var Box = Resources.Load<GameObject>(value);

            var obj = Object.Instantiate(Box, position, Quaternion.identity);

        }
    }
}
